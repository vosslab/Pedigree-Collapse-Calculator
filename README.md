# Pedigree Collapse Calculator
Pedigree Collapse Calculator will tell you how much percentage of your DNA is homozygous indicating what level of relationship your parents had. The tool will tell the percentage of collapse in your pedigree. It supports FTDNA, 23andMe and Ancestry files. Prebuilt executables are available in [releases](https://github.com/fiidau/Pedigree-Collapse-Calculator/releases/latest).

**Note:** *Keep watch for duplicated ancestors in your pedigree if you have high RoH. The value of RoH is certainly correct but the interpretation may or may not match exactly your pedigree. e.g., a 12.5% ROH representing first cousin parents could also mean double second cousins or quadruple third cousins.. and so on.  Hence, if you have parents as double second cousins, then you could have the same RoH level as if your parents are first cousins. The accuracy of the tool diminishes beyond 3rd cousin marriages.*

## Debian Install

First install the mono project C# compiler
```bash
sudo apt install mono-complete
```

Build the project
```bash
xbuild 'Pedigree Collapse Calculator.csproj'
```

Run the program
```bash
./bin/Debug/'Pedigree Collapse Calculator.exe'
```
