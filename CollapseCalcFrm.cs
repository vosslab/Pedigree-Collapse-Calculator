using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Collapse_Calculator
{
    public partial class CollapseCalcFrm : Form
    {

        long match_bp = 0;
        string filename = null;
        const long TOTAL_BP = 2881033286;
        bool m_match_no_call = true;        
        long m_BasePairs = 1000000;
        long m_GapToBreak=100000;
        long m_SNPs=150;
        long m_AllowedErrors = 1;
        Dictionary<int, string> message = new Dictionary<int, string>();
        long m_match_error_count=0;
        int segcount = 0;
        public CollapseCalcFrm()
        {
            InitializeComponent();
        }

        private void CollapseCalcFrm_Load(object sender, EventArgs e)
        {
           m_AllowedErrors = (long)(m_SNPs * 4 / 100); //allow 4% errors

           message.Add(0, "Based on @segcount@ ROH segments, your parents may not only be siblings (incest) but their parents might also be siblings (incest for multiple generations).");
           message.Add(1, "Based on @segcount@ ROH segments, your parents may be siblings (incest).");
           message.Add(2, "Based on @segcount@ ROH segments, your parents may be first cousins.");
           message.Add(3, "Based on @segcount@ ROH segments, your parents may be second cousins.");
           message.Add(4, "Based on @segcount@ ROH segments, your parents may be third cousins.");
           message.Add(5, "Based on @segcount@ ROH segments, your parents may be fourth cousins.");
           message.Add(6, "Based on @segcount@ ROH segments, your parents may be fifth cousins.");
        }

        public byte[] Zip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public byte[] Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return mso.ToArray();
            }
        }

        public void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                filename = dialog.FileName;
                match_bp = 0;
                neanPercent.Text = "0.00%";
                neanPercent.ForeColor = Color.Gray;
                statusLbl.Text = "Calculating ...";
                button1.Enabled = false;
                segcount = 0;
                //
                try
                {
                    m_AllowedErrors = long.Parse(tb_AllowedErrors.Text);
                    m_BasePairs = long.Parse(tb_BasePairs.Text);
                    m_GapToBreak = long.Parse(tb_GapToBreak.Text);
                    m_SNPs = long.Parse(tb_SNPs.Text);
                    m_match_no_call = cb_MatchNoCall.Checked;
                    backgroundWorker2.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private string getAutosomalText(string file)
        {
            string text = null;

            if (file.EndsWith(".gz"))
            {
                StringReader reader = new StringReader(Encoding.UTF8.GetString(Unzip(File.ReadAllBytes(file))));
                text = reader.ReadToEnd();
                reader.Close();

            }
            else if (file.EndsWith(".zip"))
            {
                using (var fs = new MemoryStream(File.ReadAllBytes(file)))
                using (var zf = new ZipFile(fs))
                {
                    var ze = zf[0];
                    if (ze == null)
                    {
                        throw new ArgumentException("file not found in Zip");
                    }
                    using (var s = zf.GetInputStream(ze))
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            text = sr.ReadToEnd();
                        }
                    }
                }
            }
            else
                text = File.ReadAllText(file);
            return text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.y-str.org/");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            StringReader reader = new StringReader(getAutosomalText(filename));
            string line = null;
            string[] data = null;            
            long segment_start = 0;
            long segment_end = 0;
            string chr=null;
            string pchr=null;
            int i_chr=-1;
            int snp_count = 0;
            m_match_error_count = 0;
            segcount = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("#") || line.StartsWith("RSID"))
                    continue;
                line = line.Replace("\"", "").Replace("\t", ",");
                data = line.Split(new char[] { ',' });
                if (data.Length == 5)
                    data[3] = data[3] + data[4];
                
                    chr=data[1];

                if (!int.TryParse(chr, out i_chr))
                    continue;
                if (i_chr > 22 || i_chr <= 0)
                    continue;

                if (!isMatch(data[3], snp_count) || chr != pchr || long.Parse(data[2]) - segment_end > m_GapToBreak)
                {
                    if (segment_end - segment_start >= m_BasePairs && snp_count > m_SNPs)
                    {
                        match_bp = match_bp + (segment_end - segment_start);
                        segcount++;
                    }

                    segment_start = long.Parse(data[2]);
                    snp_count = 0;
                    m_match_error_count = 0;
                }
                segment_end = long.Parse(data[2]);
                pchr=chr;
                snp_count++;
            }
            reader.Close();
        }

        private bool isMatch(string p,int snp_count)
        {
            if (p == ReverseString(p))
                return true;
            if (p.IndexOfAny(new char[] { '0', '?', '-' }) != -1 && m_match_no_call)
                return true;
            m_match_error_count++;
            if(m_match_error_count<m_AllowedErrors*snp_count/m_SNPs)
                return true;
            return false;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }        

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            double percent = match_bp * 100.0 / TOTAL_BP;// excluding X chromosome
            neanPercent.Text = percent.ToString("#0.00") + "%";
            neanPercent.ForeColor = Color.Black;
            statusLbl.Text = "";
            button1.Enabled = true;
            try
            {
                if (percent >= 50)
                {
                    MessageBox.Show(message[0].Replace("@segcount@", segcount.ToString()), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    double total = 50;
                    for (int i = 0; i < 100; i++)
                    {
                        if (total / Math.Pow(2, i) > percent && percent > total / Math.Pow(2, i + 1))
                        {
                            if (total / Math.Pow(2, i) - percent > percent - total / Math.Pow(2, i + 1))
                                MessageBox.Show(message[i + 1].Replace("@segcount@", segcount.ToString()), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show(message[i].Replace("@segcount@", segcount.ToString()), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                               
            }
            
        }   
    }
}
