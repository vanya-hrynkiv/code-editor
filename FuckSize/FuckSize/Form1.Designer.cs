namespace FuckSize
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.UderMenuPanel = new System.Windows.Forms.Panel();
			this.topPanel = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FontBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BottomButtonsPanel = new System.Windows.Forms.Panel();
			this.consoleView = new System.Windows.Forms.Label();
			this.ConsolePanel = new System.Windows.Forms.Panel();
			this.consoleRTBox = new System.Windows.Forms.RichTextBox();
			this.FoldersRootPanel = new System.Windows.Forms.Panel();
			this.CodePanel = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.UderMenuPanel.SuspendLayout();
			this.topPanel.SuspendLayout();
			this.BottomButtonsPanel.SuspendLayout();
			this.ConsolePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// UderMenuPanel
			// 
			this.UderMenuPanel.Controls.Add(this.topPanel);
			this.UderMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.UderMenuPanel.Location = new System.Drawing.Point(0, 0);
			this.UderMenuPanel.Name = "UderMenuPanel";
			this.UderMenuPanel.Size = new System.Drawing.Size(984, 25);
			this.UderMenuPanel.TabIndex = 0;
			// 
			// topPanel
			// 
			this.topPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(984, 24);
			this.topPanel.TabIndex = 2;
			this.topPanel.Text = "menuStrip1";
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
			// BottomButtonsPanel
			// 
			this.BottomButtonsPanel.Controls.Add(this.consoleView);
			this.BottomButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomButtonsPanel.Location = new System.Drawing.Point(0, 539);
			this.BottomButtonsPanel.Name = "BottomButtonsPanel";
			this.BottomButtonsPanel.Size = new System.Drawing.Size(984, 22);
			this.BottomButtonsPanel.TabIndex = 1;
			// 
			// consoleView
			// 
			this.consoleView.AutoSize = true;
			this.consoleView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.consoleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.consoleView.Location = new System.Drawing.Point(3, 3);
			this.consoleView.Name = "consoleView";
			this.consoleView.Size = new System.Drawing.Size(52, 15);
			this.consoleView.TabIndex = 1;
			this.consoleView.Text = "Console";
			this.consoleView.Click += new System.EventHandler(this.consoleView_Click);
			// 
			// ConsolePanel
			// 
			this.ConsolePanel.Controls.Add(this.consoleRTBox);
			this.ConsolePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ConsolePanel.Location = new System.Drawing.Point(0, 429);
			this.ConsolePanel.Name = "ConsolePanel";
			this.ConsolePanel.Size = new System.Drawing.Size(984, 110);
			this.ConsolePanel.TabIndex = 2;
			// 
			// consoleRTBox
			// 
			this.consoleRTBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleRTBox.Location = new System.Drawing.Point(0, 0);
			this.consoleRTBox.Margin = new System.Windows.Forms.Padding(1);
			this.consoleRTBox.Name = "consoleRTBox";
			this.consoleRTBox.ReadOnly = true;
			this.consoleRTBox.Size = new System.Drawing.Size(984, 110);
			this.consoleRTBox.TabIndex = 7;
			this.consoleRTBox.Text = "";
			// 
			// FoldersRootPanel
			// 
			this.FoldersRootPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.FoldersRootPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.FoldersRootPanel.Location = new System.Drawing.Point(0, 25);
			this.FoldersRootPanel.Name = "FoldersRootPanel";
			this.FoldersRootPanel.Size = new System.Drawing.Size(200, 404);
			this.FoldersRootPanel.TabIndex = 3;
			// 
			// CodePanel
			// 
			this.CodePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CodePanel.Location = new System.Drawing.Point(200, 25);
			this.CodePanel.Name = "CodePanel";
			this.CodePanel.Size = new System.Drawing.Size(784, 404);
			this.CodePanel.TabIndex = 4;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.CodePanel);
			this.Controls.Add(this.FoldersRootPanel);
			this.Controls.Add(this.ConsolePanel);
			this.Controls.Add(this.BottomButtonsPanel);
			this.Controls.Add(this.UderMenuPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.UderMenuPanel.ResumeLayout(false);
			this.UderMenuPanel.PerformLayout();
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			this.BottomButtonsPanel.ResumeLayout(false);
			this.BottomButtonsPanel.PerformLayout();
			this.ConsolePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel UderMenuPanel;
		private System.Windows.Forms.MenuStrip topPanel;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFileBtn;
		private System.Windows.Forms.ToolStripMenuItem saveFileBtn;
		private System.Windows.Forms.ToolStripMenuItem exitBtn;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FontBtn;
		private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
		private System.Windows.Forms.Panel BottomButtonsPanel;
		private System.Windows.Forms.Label consoleView;
		private System.Windows.Forms.Panel ConsolePanel;
		private System.Windows.Forms.RichTextBox consoleRTBox;
		private System.Windows.Forms.Panel FoldersRootPanel;
		private System.Windows.Forms.Panel CodePanel;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
	}
}

