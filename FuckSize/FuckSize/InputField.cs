using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FuckSize
{
    class InputField : Panel
    {
        // Field for code
        RichTextBox codeRTBox;

        //Column for lines of code
        RichTextBox linesRTBox;
        Panel linesPanel;
        Panel codePanel;

        public InputField()
        {
            this.Dock = DockStyle.Fill;
            linesPanel = new Panel();
            linesPanel.Dock = DockStyle.Left;
            linesPanel.Width = 35;
            
            codePanel = new Panel();
            codePanel.Location = new Point(linesPanel.Location.X + 35, linesPanel.Location.Y);
            codePanel.Width = this.Width - 35;
            codePanel.Height = this.Height;
            codePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            linesRTBox = new RichTextBox();
            linesRTBox.Dock = DockStyle.Fill;
            linesRTBox.ScrollBars = RichTextBoxScrollBars.None;
            linesRTBox.Font = new System.Drawing.Font("Consolas", 10F);
            linesRTBox.ReadOnly = true;
            linesRTBox.Enabled = false;
            linesRTBox.SelectionAlignment = HorizontalAlignment.Center;
            linesRTBox.MouseDown += linesRTB_MouseDown;
            
            linesPanel.Controls.Add(linesRTBox);

            codeRTBox = new RichTextBox();
            codeRTBox.Font = linesRTBox.Font;
            codeRTBox.Dock = DockStyle.Fill;
            codeRTBox.Focus();
            codeRTBox.Select();
            codeRTBox.Text = " ";
            codeRTBox.SelectionChanged += codeRTB_SelectionChanged;
            codeRTBox.VScroll += codeRTB_VScroll;
            codeRTBox.TextChanged += codeRTB_TextChanged;
            codeRTBox.FontChanged += codeRTB_FontChanged;
            codePanel.Controls.Add(codeRTBox);

            this.Controls.Add(linesPanel);
            this.Controls.Add(codePanel);
        }

        public void AddLineNumbers()
        {
            
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            Console.WriteLine(codeRTBox.Lines.Length);
            // get First Index & First Line from richTextBox1    
            int First_Index = codeRTBox.GetCharIndexFromPosition(pt);
            int First_Line = codeRTBox.GetLineFromCharIndex(First_Index);

            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;

            // get Last Index & Last Line from richTextBox1    
            int Last_Index = codeRTBox.GetCharIndexFromPosition(pt);
            int Last_Line = codeRTBox.GetLineFromCharIndex(Last_Index);

            // set Center alignment to LineNumberTextBox    
            linesRTBox.SelectionAlignment = HorizontalAlignment.Center;

            // set LineNumberTextBox text to null & width to getWidth() function value    
            linesRTBox.Text = "";
            linesRTBox.Width = getWidth();

            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 2; i++)
            {
                linesRTBox.Text += i + 1 + "\n";
            }
            
        }
        private void DeleteLine(RichTextBox rtb, int a_line)
        {
            int start_index = rtb.GetFirstCharIndexFromLine(a_line);
            int count = rtb.Lines[a_line].Length;

            // Eat new line chars
            if (a_line < rtb.Lines.Length - 1)
            {
                count += rtb.GetFirstCharIndexFromLine(a_line + 1) -
                    ((start_index + count - 1) + 1);
            }

            rtb.Text = rtb.Text.Remove(start_index, count);
        }

        int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1    
            int line = codeRTBox.Lines.Length;

            if (line <= 99) w = 20 + (int)codeRTBox.Font.Size;
            else if (line <= 999) w = 30 + (int)codeRTBox.Font.Size;
            else w = 50 + (int)codeRTBox.Font.Size;

            return w;
        }

        public string CodeText { get { return codeRTBox.Text; } set { codeRTBox.Text = value; } }
        public Font SetFont { set { codeRTBox.Font = value; } }
        public DockStyle SetDock { set { this.Dock = value; } }

        private void codeRTB_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = codeRTBox.GetPositionFromCharIndex(codeRTBox.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void codeRTB_VScroll(object sender, EventArgs e)
        {
            linesRTBox.Text = "";
            AddLineNumbers();
            linesRTBox.Invalidate();
        }

        private void codeRTB_TextChanged(object sender, EventArgs e)
        {
            if (codeRTBox.Text == "")
            {
                AddLineNumbers();
            }

            // Color text
            var currentSelStart = codeRTBox.SelectionStart;
            var currentSelLength = codeRTBox.SelectionLength;

            codeRTBox.SelectAll();
            codeRTBox.SelectionColor = SystemColors.WindowText;

            var matches = Regex.Matches(codeRTBox.Text, @"\bclass\b");
            foreach (var match in matches.Cast<Match>())
            {
                codeRTBox.Select(match.Index, match.Length);
                codeRTBox.SelectionColor = Color.Blue;
            }

            codeRTBox.Select(currentSelStart, currentSelLength);
            codeRTBox.SelectionColor = SystemColors.WindowText;
        }

        private void codeRTB_FontChanged(object sender, EventArgs e)
        {
            linesRTBox.Font = linesRTBox.Font;
            codeRTBox.Select();
            AddLineNumbers();
        }

        private void linesRTB_MouseDown(object sender, MouseEventArgs e)
        {
            codeRTBox.Select();
            linesRTBox.DeselectAll();
        }
       
    }
}
