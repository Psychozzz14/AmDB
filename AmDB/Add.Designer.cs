namespace AmDB
{
	partial class Add
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
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			richTextBox1 = new RichTextBox();
			groupBox1 = new GroupBox();
			button2 = new Button();
			button1 = new Button();
			button3 = new Button();
			pictureBox1 = new PictureBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(31, 15);
			label1.TabIndex = 0;
			label1.Text = "Имя";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 27);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(262, 23);
			textBox1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 53);
			label2.Name = "label2";
			label2.Size = new Size(62, 15);
			label2.TabIndex = 2;
			label2.Text = "Описание";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(291, 9);
			label3.Name = "label3";
			label3.Size = new Size(35, 15);
			label3.TabIndex = 3;
			label3.Text = "Фото";
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(12, 71);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
			richTextBox1.Size = new Size(262, 308);
			richTextBox1.TabIndex = 4;
			richTextBox1.Text = "";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(button1);
			groupBox1.Location = new Point(-22, 385);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(836, 118);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			// 
			// button2
			// 
			button2.Location = new Point(643, 22);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "Добавить";
			button2.UseVisualStyleBackColor = true;
			button2.Click += AddToDB;
			// 
			// button1
			// 
			button1.Location = new Point(735, 22);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Отмена";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Close;
			// 
			// button3
			// 
			button3.Location = new Point(291, 26);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 6;
			button3.Text = "Загрузить";
			button3.UseVisualStyleBackColor = true;
			button3.Click += LoadImage;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(291, 71);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(497, 308);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// Add
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pictureBox1);
			Controls.Add(button3);
			Controls.Add(groupBox1);
			Controls.Add(richTextBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Add";
			Text = "Добавление";
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private RichTextBox richTextBox1;
		private GroupBox groupBox1;
		private Button button2;
		private Button button1;
		private Button button3;
		private PictureBox pictureBox1;
	}
}