namespace AmDB
{
	partial class MainApp
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
			menuStrip1 = new MenuStrip();
			FoundationMenuItem = new ToolStripMenuItem();
			searchToolStripMenuItem = new ToolStripMenuItem();
			addToolStripMenuItem = new ToolStripMenuItem();
			deleteToolStripMenuItem = new ToolStripMenuItem();
			modifyToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			HelpMenuItem = new ToolStripMenuItem();
			HelpToolMenuItem = new ToolStripMenuItem();
			InfoToolMenuItem = new ToolStripMenuItem();
			listBox1 = new ListBox();
			contextMenuStrip1 = new ContextMenuStrip(components);
			AddListboxToolStripMenuItem = new ToolStripMenuItem();
			deleteListboxToolStripMenuItem = new ToolStripMenuItem();
			modifyListboxToolStripMenuItem = new ToolStripMenuItem();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			label1 = new Label();
			button1 = new Button();
			textBox1 = new TextBox();
			searchButton = new Button();
			searchClose = new Button();
			menuStrip1.SuspendLayout();
			contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = SystemColors.MenuBar;
			menuStrip1.Items.AddRange(new ToolStripItem[] { FoundationMenuItem, HelpMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(0, 2, 0, 2);
			menuStrip1.Size = new Size(1184, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// FoundationMenuItem
			// 
			FoundationMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, addToolStripMenuItem, deleteToolStripMenuItem, modifyToolStripMenuItem, exitToolStripMenuItem });
			FoundationMenuItem.Name = "FoundationMenuItem";
			FoundationMenuItem.Size = new Size(48, 20);
			FoundationMenuItem.Text = "Фонд";
			// 
			// searchToolStripMenuItem
			// 
			searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			searchToolStripMenuItem.ShortcutKeyDisplayString = "F1";
			searchToolStripMenuItem.ShortcutKeys = Keys.F1;
			searchToolStripMenuItem.Size = new Size(150, 22);
			searchToolStripMenuItem.Text = "Найти...";
			searchToolStripMenuItem.Click += SearchToolStripMenuItem_Click;
			// 
			// addToolStripMenuItem
			// 
			addToolStripMenuItem.Name = "addToolStripMenuItem";
			addToolStripMenuItem.ShortcutKeyDisplayString = "F2";
			addToolStripMenuItem.ShortcutKeys = Keys.F2;
			addToolStripMenuItem.Size = new Size(150, 22);
			addToolStripMenuItem.Text = "Добавить";
			addToolStripMenuItem.Click += AddToolMenuItem_Click;
			// 
			// deleteToolStripMenuItem
			// 
			deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			deleteToolStripMenuItem.ShortcutKeyDisplayString = "F3";
			deleteToolStripMenuItem.ShortcutKeys = Keys.F3;
			deleteToolStripMenuItem.Size = new Size(150, 22);
			deleteToolStripMenuItem.Text = "Удалить";
			deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
			// 
			// modifyToolStripMenuItem
			// 
			modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			modifyToolStripMenuItem.ShortcutKeyDisplayString = "F4";
			modifyToolStripMenuItem.ShortcutKeys = Keys.F4;
			modifyToolStripMenuItem.Size = new Size(150, 22);
			modifyToolStripMenuItem.Text = "Изменить";
			modifyToolStripMenuItem.Click += ModifyToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
			exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
			exitToolStripMenuItem.Size = new Size(150, 22);
			exitToolStripMenuItem.Text = "Выход";
			exitToolStripMenuItem.Click += Close;
			// 
			// HelpMenuItem
			// 
			HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { HelpToolMenuItem, InfoToolMenuItem });
			HelpMenuItem.Name = "HelpMenuItem";
			HelpMenuItem.Size = new Size(65, 20);
			HelpMenuItem.Text = "Справка";
			// 
			// HelpToolMenuItem
			// 
			HelpToolMenuItem.Name = "HelpToolMenuItem";
			HelpToolMenuItem.ShortcutKeyDisplayString = "F10";
			HelpToolMenuItem.ShortcutKeys = Keys.F10;
			HelpToolMenuItem.Size = new Size(180, 22);
			HelpToolMenuItem.Text = "Содержание";
			HelpToolMenuItem.Click += ContentsToolMenuItem_Click;
			// 
			// InfoToolMenuItem
			// 
			InfoToolMenuItem.Name = "InfoToolMenuItem";
			InfoToolMenuItem.Size = new Size(180, 22);
			InfoToolMenuItem.Text = "О программе";
			InfoToolMenuItem.Click += InfoToolMenuItem_Click;
			// 
			// listBox1
			// 
			listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			listBox1.ContextMenuStrip = contextMenuStrip1;
			listBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 20;
			listBox1.Location = new Point(0, 21);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(220, 484);
			listBox1.TabIndex = 1;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			listBox1.MouseDown += ListBox1_MouseDown;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { AddListboxToolStripMenuItem, deleteListboxToolStripMenuItem, modifyListboxToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(129, 70);
			// 
			// AddListboxToolStripMenuItem
			// 
			AddListboxToolStripMenuItem.Name = "AddListboxToolStripMenuItem";
			AddListboxToolStripMenuItem.Size = new Size(128, 22);
			AddListboxToolStripMenuItem.Text = "Добавить";
			AddListboxToolStripMenuItem.Click += AddToolMenuItem_Click;
			// 
			// deleteListboxToolStripMenuItem
			// 
			deleteListboxToolStripMenuItem.Name = "deleteListboxToolStripMenuItem";
			deleteListboxToolStripMenuItem.Size = new Size(128, 22);
			deleteListboxToolStripMenuItem.Text = "Удалить";
			deleteListboxToolStripMenuItem.Click += DeleteListboxToolStripMenuItem_Click;
			// 
			// modifyListboxToolStripMenuItem
			// 
			modifyListboxToolStripMenuItem.Name = "modifyListboxToolStripMenuItem";
			modifyListboxToolStripMenuItem.Size = new Size(128, 22);
			modifyListboxToolStripMenuItem.Text = "Изменить";
			modifyListboxToolStripMenuItem.Click += ModifyToolStripMenuItem_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(226, 21);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(500, 514);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(label1);
			panel1.Location = new Point(732, 21);
			panel1.Name = "panel1";
			panel1.Size = new Size(440, 514);
			panel1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(3, 3);
			label1.MaximumSize = new Size(415, 0);
			label1.Name = "label1";
			label1.Size = new Size(0, 20);
			label1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(0, 512);
			button1.Name = "button1";
			button1.Size = new Size(220, 23);
			button1.TabIndex = 4;
			button1.Text = "Обновить базу";
			button1.UseVisualStyleBackColor = true;
			button1.Click += MainApp_Load;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(0, 465);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(197, 23);
			textBox1.TabIndex = 5;
			textBox1.Visible = false;
			textBox1.KeyDown += TextBox1_KeyDown;
			// 
			// searchButton
			// 
			searchButton.Location = new Point(0, 489);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(220, 23);
			searchButton.TabIndex = 6;
			searchButton.Text = "Искать далее";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Visible = false;
			searchButton.Click += SearchButton_Click;
			// 
			// searchClose
			// 
			searchClose.Location = new Point(197, 465);
			searchClose.Name = "searchClose";
			searchClose.Size = new Size(23, 23);
			searchClose.TabIndex = 7;
			searchClose.Text = "X";
			searchClose.UseVisualStyleBackColor = true;
			searchClose.Visible = false;
			searchClose.Click += CloseSearchButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(1184, 561);
			Controls.Add(searchClose);
			Controls.Add(searchButton);
			Controls.Add(textBox1);
			Controls.Add(listBox1);
			Controls.Add(button1);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "Form1";
			Text = "AmDB - Герои России";
			Load += MainApp_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem FoundationMenuItem;
		private ToolStripMenuItem HelpMenuItem;
		private ToolStripMenuItem HelpToolMenuItem;
		private ToolStripMenuItem InfoToolMenuItem;
		private ListBox listBox1;
		private PictureBox pictureBox1;
		private Panel panel1;
		private Label label1;
		private ToolStripMenuItem searchToolStripMenuItem;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripMenuItem modifyToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private Button button1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem AddListboxToolStripMenuItem;
		private ToolStripMenuItem deleteListboxToolStripMenuItem;
		private ToolStripMenuItem modifyListboxToolStripMenuItem;
		private TextBox textBox1;
		private Button searchButton;
		private Button searchClose;
	}
}