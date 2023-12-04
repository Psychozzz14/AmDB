namespace AmDB
{
	partial class Modify
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
			richTextBox1 = new RichTextBox();
			pictureBox1 = new PictureBox();
			listBox1 = new ListBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			textBox1 = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(732, 39);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(440, 473);
			richTextBox1.TabIndex = 0;
			richTextBox1.Text = "4werterer";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(226, 39);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(500, 473);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// listBox1
			// 
			listBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 20;
			listBox1.Location = new Point(0, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(220, 484);
			listBox1.TabIndex = 2;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// button1
			// 
			button1.Location = new Point(1097, 526);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Отмена";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Close;
			// 
			// button2
			// 
			button2.Location = new Point(1016, 526);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 4;
			button2.Text = "Изменить";
			button2.UseVisualStyleBackColor = true;
			button2.Click += ModifyDB;
			// 
			// button3
			// 
			button3.Location = new Point(226, 10);
			button3.Name = "button3";
			button3.Size = new Size(101, 23);
			button3.TabIndex = 5;
			button3.Text = "Загрузить фото";
			button3.UseVisualStyleBackColor = true;
			button3.Click += LoadImage;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(732, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(440, 23);
			textBox1.TabIndex = 6;
			// 
			// Modify
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1184, 561);
			Controls.Add(textBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(listBox1);
			Controls.Add(pictureBox1);
			Controls.Add(richTextBox1);
			Name = "Modify";
			Text = "Изменение";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox richTextBox1;
		private PictureBox pictureBox1;
		private ListBox listBox1;
		private Button button1;
		private Button button2;
		private Button button3;
		private TextBox textBox1;
	}
}