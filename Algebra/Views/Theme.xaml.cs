using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Algebra.Views
{
	/// <summary>
	/// Логика взаимодействия для Theme.xaml
	/// </summary>
	public partial class Theme : Window
	{
		int id = 1;
		string query;
		SQLiteDataReader reader;
		SQLiteConnection connection;
		SQLiteCommand command;
		public Theme()
		{
			InitializeComponent();
			Open();
		}
		public void Open()
		{
			try
			{
				if (id >= 1)
				{
					query = $"SELECT nameTheme,contentTheme FROM Theme WHERE id = {id}";
					connection = new SQLiteConnection("Data Source=algebra.db");
					connection.Open();
					command = new SQLiteCommand(query, connection);
					reader = command.ExecuteReader();
					while (reader.Read())
					{
						string name = reader.GetString(0);
						string cont = reader.GetString(1);
						lbName.Content = name;
						content.Text = cont;
					}
					connection.Close();
				}
				else if(id < 1)
				{
					MessageBox.Show("Нет больше тем");
				}
			}
			catch
			{}
		}
		private void Left_Click(object sender, RoutedEventArgs e)
		{
			id--;
			Open();
		}

		private void Right_Click(object sender, RoutedEventArgs e)
		{
			id++;
			Open();
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			Close();
			mainWindow.Show();
		}
	}
}
