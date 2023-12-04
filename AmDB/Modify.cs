using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmDB
{
	public partial class Modify : Form
	{
		public SqliteConnection connection = new SqliteConnection("Data Source = DB.db");
		public Modify(ListBox listBox)
		{
			InitializeComponent(); 
			foreach (string item in listBox.Items)
			{
				listBox1.Items.Add(item);
			}
			listBox1.SelectedItem = listBox.SelectedItem;
			listBox1_SelectedIndexChanged(listBox, new EventArgs());
		}
		private void Close(object sender, EventArgs e)
		{
			connection.Close();
			this.Close();
		}

		//Загрузка в листбокс
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			connection.Open();
			if (listBox1.SelectedItem != null)
			{
				string sqlExpression = $"SELECT * FROM HeroesOfRussia WHERE Name = '{listBox1.SelectedItem}';";
				SqliteCommand command = new SqliteCommand(sqlExpression, connection);
				SqliteDataReader reader = command.ExecuteReader();
				reader.Read();
				Image image = Image.FromStream(reader.GetStream(2));
				pictureBox1.Image = image;
				textBox1.Text = (string)listBox1.SelectedItem;
				richTextBox1.Text = reader.GetString(1);
			}
			else
			{
				pictureBox1.Image = null;
				textBox1.Text = "Имя...";
				richTextBox1.Text = "Описание...";

			}
			connection.Close();
		}

		//Загрузка фото
		private void LoadImage(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG|All Files(*.*)|*.*";

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

		//Изменение строки в базе данных
		private void ModifyDB(object sender, EventArgs e)
		{
			connection.Open();

			var stream = new MemoryStream();
			pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
			byte[] bytes = stream.ToArray();

			SqliteParameter imageParameter = new SqliteParameter("@image", bytes);
			string sqlExpression = $"UPDATE HeroesOfRussia SET name = '{textBox1.Text}', info = '{richTextBox1.Text}', image = @image WHERE name = '{listBox1.SelectedItem}'";

			SqliteCommand command = new SqliteCommand(sqlExpression, connection);
			command.Parameters.Add(imageParameter);
			command.ExecuteNonQuery();

			connection.Close();
			this.Close();
		}
		
	}
}
