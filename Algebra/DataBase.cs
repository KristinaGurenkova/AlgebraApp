using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Xml.Linq;
using Algebra.Views;
using System.Windows;

namespace Algebra
{
	public class DataBase
	{
		SQLiteConnection connection;
		SQLiteCommand command;
		string query;
		public void Connection()
		{
			connection = new SQLiteConnection("Data Source=algebra.db");
		}
		public void Add(string name, string content)
		{
			if (name == " " || content == " ")
			{
				MessageBox.Show("Вы не ввели все значения");
			}
			else
			{
				query = $"INSERT INTO Theme (nameTheme, contentTheme) VALUES ('{name}','{content}')";
				command = new SQLiteCommand(query, connection);
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
		}
	}
}
