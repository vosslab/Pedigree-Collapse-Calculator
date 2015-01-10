namespace Collapse_Calculator
{
    partial class CollapseCalcFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollapseCalcFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.neanPercent = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_MatchNoCall = new System.Windows.Forms.CheckBox();
            this.tb_BasePairs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_SNPs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_GapToBreak = new System.Windows.Forms.TextBox();
            this.tb_AllowedErrors = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "BROWSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(589, 426);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "y-str.org";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select File";
            // 
            // neanPercent
            // 
            this.neanPercent.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neanPercent.ForeColor = System.Drawing.Color.Gray;
            this.neanPercent.Location = new System.Drawing.Point(12, 79);
            this.neanPercent.Name = "neanPercent";
            this.neanPercent.Size = new System.Drawing.Size(306, 85);
            this.neanPercent.TabIndex = 3;
            this.neanPercent.Text = "0.00%";
            this.neanPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(70, 164);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(188, 17);
            this.result.TabIndex = 5;
            this.result.Text = "pedigree collapsed";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(9, 426);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(65, 13);
            this.statusLbl.TabIndex = 11;
            this.statusLbl.Text = "Select file ...";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 217);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_AllowedErrors);
            this.groupBox1.Controls.Add(this.tb_GapToBreak);
            this.groupBox1.Controls.Add(this.tb_SNPs);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_BasePairs);
            this.groupBox1.Controls.Add(this.cb_MatchNoCall);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(307, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 357);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Runs of Homozygosity Segment Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basepair Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SNP Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gap to break";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Allowed Errors";
            // 
            // cb_MatchNoCall
            // 
            this.cb_MatchNoCall.AutoSize = true;
            this.cb_MatchNoCall.Checked = true;
            this.cb_MatchNoCall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MatchNoCall.Location = new System.Drawing.Point(15, 305);
            this.cb_MatchNoCall.Name = "cb_MatchNoCall";
            this.cb_MatchNoCall.Size = new System.Drawing.Size(95, 17);
            this.cb_MatchNoCall.TabIndex = 4;
            this.cb_MatchNoCall.Text = "Match no-calls";
            this.cb_MatchNoCall.UseVisualStyleBackColor = true;
            // 
            // tb_BasePairs
            // 
            this.tb_BasePairs.Location = new System.Drawing.Point(97, 26);
            this.tb_BasePairs.Name = "tb_BasePairs";
            this.tb_BasePairs.Size = new System.Drawing.Size(100, 20);
            this.tb_BasePairs.TabIndex = 5;
            this.tb_BasePairs.Text = "1000000";
            this.tb_BasePairs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Base-pair threshold for each segment";
            // 
            // tb_SNPs
            // 
            this.tb_SNPs.Location = new System.Drawing.Point(97, 95);
            this.tb_SNPs.Name = "tb_SNPs";
            this.tb_SNPs.Size = new System.Drawing.Size(100, 20);
            this.tb_SNPs.TabIndex = 7;
            this.tb_SNPs.Text = "150";
            this.tb_SNPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(15, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SNP count threshold for each segment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(15, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Break the segment if distance between two SNPs is greater";
            // 
            // tb_GapToBreak
            // 
            this.tb_GapToBreak.Location = new System.Drawing.Point(97, 167);
            this.tb_GapToBreak.Name = "tb_GapToBreak";
            this.tb_GapToBreak.Size = new System.Drawing.Size(100, 20);
            this.tb_GapToBreak.TabIndex = 8;
            this.tb_GapToBreak.Text = "100000";
            this.tb_GapToBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_AllowedErrors
            // 
            this.tb_AllowedErrors.Location = new System.Drawing.Point(97, 233);
            this.tb_AllowedErrors.Name = "tb_AllowedErrors";
            this.tb_AllowedErrors.Size = new System.Drawing.Size(100, 20);
            this.tb_AllowedErrors.TabIndex = 9;
            this.tb_AllowedErrors.Text = "1";
            this.tb_AllowedErrors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(15, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tick if you want to match no-calls";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(15, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Number of mismatching SNPs to consider as matching";
            // 
            // CollapseCalcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neanPercent);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollapseCalcFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedigree Collapse Calculator";
            this.Load += new System.EventHandler(this.CollapseCalcFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label neanPercent;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_MatchNoCall;
        private System.Windows.Forms.TextBox tb_SNPs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_BasePairs;
        private System.Windows.Forms.TextBox tb_AllowedErrors;
        private System.Windows.Forms.TextBox tb_GapToBreak;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

