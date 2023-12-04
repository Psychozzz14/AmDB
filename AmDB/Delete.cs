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
using System.Xml.Serialization;

namespace AmDB
{
	public partial class Delete : Form
	{
		
		public Delete(ListBox listBox)
		{
			InitializeComponent();
			connection.Open();
			
			foreach (string item in listBox.Items)
			{
				listBox1.Items.Add(item);
			}

		}
		private void Close(object sender, EventArgs e)
		{
			connection.Close();
			Close();
		}

		//Удаление строк из базы данных		
		private void DeleteItems(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				foreach (object item in listBox1.SelectedItems)
				{
					string sqlExpression = $"DELETE FROM HeroesOfRussia WHERE Name='{item}'";
					SqliteCommand command = new SqliteCommand(sqlExpression, connection);
					command.ExecuteNonQuery();
				}
				connection.Close();
				Close();
			}
		}
		
		public SqliteConnection connection = new SqliteConnection("Data Source = DB.db");
	}
}
