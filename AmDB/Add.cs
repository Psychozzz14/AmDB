using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmDB
{
	public partial class Add : Form
	{
		public Add()
		{
			InitializeComponent();
		}
		private void Close(object sender, EventArgs e)
		{
			this.Close();
		}

		//Загрузка фото
		private void LoadImage(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";

			ofd.Multiselect = false;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pictureBox1.Image = new Bitmap(ofd.FileName);
				}
				catch
				{
					MessageBox.Show("Не удалось открыть файл");
				}
			}

		}

		//Загрузка строки в базу данных
		private void AddToDB(object sender, EventArgs e)
		{
			SqliteConnection connection = new SqliteConnection("Data Source = DB.db");
			
			connection.Open();

			var stream = new MemoryStream();
			pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
			byte[] bytes = stream.ToArray();

			SqliteParameter imageParameter = new SqliteParameter("@image", bytes);
			if (textBox1.Text.Contains("'") || richTextBox1.Text.Contains("'"))
			{
				textBox1.Text = "Хорошая попытка";
				richTextBox1.Text = "Но меня так не проведешь";
			}
			string sqlExpression = $"INSERT INTO HeroesOfRussia (name,info,image) VALUES ('{textBox1.Text}', '{richTextBox1.Text}', @image)";
			
			SqliteCommand command = new SqliteCommand(sqlExpression, connection);
			command.Parameters.Add(imageParameter);
			command.ExecuteNonQuery();

			connection.Close();
			this.Close();
		}
	}
}