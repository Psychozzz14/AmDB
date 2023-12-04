using Microsoft.Data.Sqlite;
using System.Data;

namespace AmDB
{
	public partial class MainApp : Form
	{
		public SqliteConnection connection = new SqliteConnection($"Data Source=DB.db");
		public MainApp()
		{
			InitializeComponent();
		}
		private void MainApp_Load(object sender, EventArgs e)
		{
			connection.Open();
			string sqlExpression = "SELECT * FROM HeroesOfRussia";
			listBox1.Items.Clear();
			foreach (string item in ReadStrings(sqlExpression, 0))
			{
				listBox1.Items.Add(item);
			}
			connection.Close();
		}

		//Вызов форм
		private void ContentsToolMenuItem_Click(object sender, EventArgs e)
		{
			Contents contents = new Contents();
			contents.Show();
		}
		private void AddToolMenuItem_Click(object sender, EventArgs e)
		{
			Add add = new();
			add.ShowDialog();
		}
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Delete delete = new Delete(listBox1);
			delete.ShowDialog();
		}
		private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Modify modify = new Modify(listBox1);
			modify.ShowDialog();
		}
		
		//Листбокс
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			connection.Open();
			if (listBox1.SelectedItem != null)
			{
				string sqlExpression = $"SELECT * FROM HeroesOfRussia WHERE Name = '{listBox1.SelectedItem}';";
				pictureBox1.Image = ReadImage(sqlExpression);
				label1.Text = ReadStrings(sqlExpression, 1)[0];
			}
			connection.Close();
		}
		private void ListBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (listBox1.IndexFromPoint(e.Location) != ListBox.NoMatches) 
				{
					listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
				}
				deleteListboxToolStripMenuItem.Enabled = (listBox1.IndexFromPoint(e.Location) != ListBox.NoMatches);
				modifyListboxToolStripMenuItem.Enabled = (listBox1.IndexFromPoint(e.Location) != ListBox.NoMatches);
			}
		}
		private void DeleteListboxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			connection.Open();
			DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				string sqlExpression = $"DELETE FROM HeroesOfRussia WHERE Name='{listBox1.SelectedItem}'";
				SqliteCommand command = new SqliteCommand(sqlExpression, connection);
				command.ExecuteNonQuery();
				MainApp_Load(sender, new EventArgs());
			}
			connection.Close();
		}

		//Модальное окно о приложении
		private void InfoToolMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show
			(
				"База данных 'Герои России'\nШишонин Иван Евгеньевич\nСпасибо маме и папе!",
				"О программе",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
		
		//Поисковая строка
		private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBox1.Height = 444;
			textBox1.Visible = true;
			searchButton.Visible = true;
			searchClose.Visible = true;
		}
		private void CloseSearchButton_Click(object sender, EventArgs e)
		{
			listBox1.Height = 484;
			textBox1.Visible = false;
			searchButton.Visible = false;
			searchClose.Visible = false;
		}
		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex == -1)
			{
				listBox1.SelectedIndex = listBox1.Items.Count - 1;
			}
			int index = SearchEngine(listBox1.SelectedIndex + 1, listBox1.Items.Count);
			if (index == -1)
			{
				MessageBox.Show("Нет совпадений", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				listBox1.SelectedIndex = index;
			}

		}
		private void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SearchButton_Click((object)sender, e);
			}
		}

		//Закрытие приложения
		private void Close(object sender, EventArgs e)
		{
			Close();
		}		

		//Чтение из базы данных
		public List<string> ReadStrings(string sqlExpression, int index)
		{
			List<string> result = new List<string> { };
			SqliteCommand command = new SqliteCommand(sqlExpression, connection);
			SqliteDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					result.Add(reader.GetString(index));
				}
			}
			return result;
		}
		public Image ReadImage(string sqlExpression)
		{
			SqliteCommand command = new SqliteCommand(sqlExpression, connection);
			SqliteDataReader reader = command.ExecuteReader();
			reader.Read();
			Image result = Image.FromStream(reader.GetStream(2));
			return result;
		}

		//Поиск
		public int SearchEngine(int selectedItem, int items)
		{
			string? str;
			int index;
			for (int i = selectedItem; i < items + selectedItem; i++)
			{
				str = listBox1.Items[i % items].ToString();
				index = str.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase);
				if (index > -1) return i % items;
			}
			return -1;
		}
	}
}