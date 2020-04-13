using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

//--------- For Compiller -------------
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text.RegularExpressions;
//-------------------------------------

namespace FuckSize
{
    public partial class Form1 : Form
    {
        InputField mainCodeField;
        public Form1()
        {
            InitializeComponent();
            ConsolePanel.Height = 0;
            ConsolePanel.Visible = false;
            this.KeyPreview = true;

            mainCodeField = new InputField();
            CodePanel.Controls.Add(mainCodeField);
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "C++ source files (*.cpp)|*.cpp|JavaScript (*.js)|*.js|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                {
                    //mainInput.Text = reader.ReadToEnd();
                    mainCodeField.CodeText = reader.ReadToEnd();
                }
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "C++ source files (*.cpp)|*.cpp|JavaScript (*.js)|*.js|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default))
                {
                    //writer.Write(mainInput.Text);
                    writer.Write(mainCodeField.CodeText);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //mainInput.Font = fontDialog1.Font;
                mainCodeField.SetFont = fontDialog1.Font;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mainInput.WordWrap = !mainInput.WordWrap;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SharpCompiler();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                SharpCompiler();
            }
        }

        public void SharpCompiler()
        {
            this.consoleRTBox.Text = "";

            // Need for version of compiler
            CSharpCodeProvider provider = new CSharpCodeProvider(new Dictionary<string, string> { { "CompilerVersion", "v4.0" } });


            // Need for create an exe file 
            // File name - test.exe (need create user interface for this)
            CompilerParameters parameters = new CompilerParameters(new string[] { "mscorlib.dll", "System.Core.dll" }, "test.exe", true);

            parameters.GenerateExecutable = true;

            // Catch errors (if it exists)
            //CompilerResults results = provider.CompileAssemblyFromSource(parameters, this.mainInput.Text);
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, mainCodeField.CodeText);

            if (results.Errors.HasErrors)
            {
                // Write all the mistakes
                foreach (CompilerError error in results.Errors.Cast<CompilerError>())
                {
                    this.consoleRTBox.Text += $"Line {error.Line}:    {error.ErrorText}";
                }
            }
            else
            {
                this.consoleRTBox.Text = "... Successfully ...";

                // Where need save exe file
                Process.Start($"{Application.StartupPath}/test.exe");
            }
        }

        private void consoleView_Click(object sender, EventArgs e)
        {
            if (ConsolePanel.Visible)
            {
                ConsolePanel.Height = 0;
                ConsolePanel.Visible = false;
            }
            else
            {
                ConsolePanel.Height = 110;
                ConsolePanel.Visible = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mainCodeField.AddLineNumbers();
        }
    }
}
