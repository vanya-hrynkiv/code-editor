using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FuckSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "C++ source files (*.cpp)|*.cpp|JavaScript (*.js)|*.js|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                {
                    mainInput.Text = reader.ReadToEnd();
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
                    writer.Write(mainInput.Text);
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
                mainInput.Font = fontDialog1.Font;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainInput.WordWrap = !mainInput.WordWrap;
        }
    }
}
