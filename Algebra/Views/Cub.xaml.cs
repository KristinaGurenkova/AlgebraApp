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
	/// Логика взаимодействия для Cub.xaml
	/// </summary>
	public partial class Cub : Window
	{
		DataBase dataBase = new DataBase();
		public Cub()
		{
			InitializeComponent();
			TableCub();
		}
		public void TableCub()
		{
			string query = "SELECT number,result FROM tableSquares";
			SQLiteConnection connection = new SQLiteConnection("Data Source=algebra.db");
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			SQLiteDataAdapter data = new SQLiteDataAdapter(command);
			DataTable dt = new DataTable("tableSquares");
			data.Fill(dt);
			listThemeDG.ItemsSource = dt.DefaultView;
			data.Update(dt);
			connection.Close();
		}
	}
}
