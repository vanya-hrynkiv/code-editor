namespace FuckSize
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusTBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consoleView = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainInput
            // 
            this.mainInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainInput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainInput.Location = new System.Drawing.Point(0, 24);
            this.mainInput.Multiline = true;
            this.mainInput.Name = "mainInput";
            this.mainInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainInput.Size = new System.Drawing.Size(967, 376);
            this.mainInput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileBtn,
            this.saveFileBtn,
            this.exitBtn,
            this.runToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openFileBtn.BackgroundImage")));
            this.openFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(103, 22);
            this.openFileBtn.Text = "Open";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveFileBtn.BackgroundImage")));
            this.saveFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(103, 22);
            this.saveFileBtn.Text = "Save";
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 22);
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("runToolStripMenuItem.BackgroundImage")));
            this.runToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontBtn,
            this.wordWrapToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // FontBtn
            // 
            this.FontBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FontBtn.BackgroundImage")));
            this.FontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(134, 22);
            this.FontBtn.Text = "Font";
            this.FontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wordWrapToolStripMenuItem.BackgroundImage")));
            this.wordWrapToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusTBox
            // 
            this.statusTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTBox.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.statusTBox.Location = new System.Drawing.Point(0, 395);
            this.statusTBox.Multiline = true;
            this.statusTBox.Name = "statusTBox";
            this.statusTBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.statusTBox.Size = new System.Drawing.Size(967, 132);
            this.statusTBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.consoleView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 20);
            this.panel1.TabIndex = 4;
            // 
            // consoleView
            // 
            this.consoleView.AutoSize = true;
            this.consoleView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consoleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleView.Location = new System.Drawing.Point(3, 0);
            this.consoleView.Name = "consoleView";
            this.consoleView.Size = new System.Drawing.Size(52, 15);
            this.consoleView.TabIndex = 0;
            this.consoleView.Text = "Console";
            this.consoleView.Click += new System.EventHandler(this.consoleView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusTBox);
            this.Controls.Add(this.mainInput);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FuckSize Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileBtn;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem openFileBtn;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.TextBox statusTBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label consoleView;
    }
}

