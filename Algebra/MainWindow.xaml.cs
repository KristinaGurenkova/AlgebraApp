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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Algebra.Views;
using System.Windows.Controls.Primitives;

namespace Algebra
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		DataBase dataBase = new DataBase();
		AddTheme addTheme;
		Equation equation;
		Cub cub;
		Theme theme;
		public MainWindow()
		{
			InitializeComponent();
			Load();
		}
		public void Load()
		{
			string query = "SELECT nameTheme FROM Theme ";
			SQLiteConnection connection = new SQLiteConnection("Data Source=algebra.db");
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			SQLiteDataAdapter data = new SQLiteDataAdapter(command);
			DataTable dt = new DataTable("Theme");
			data.Fill(dt);
			listThemeDG.ItemsSource = dt.DefaultView;
			data.Update(dt);
			connection.Close();
		}

		private void AddBt_Click(object sender, RoutedEventArgs e)
		{
			addTheme = new AddTheme();
			this.Close();
			addTheme.Show();
		}

		private void OpenTheme_Click(object sender, RoutedEventArgs e)
		{
			theme = new Theme();
			this.Close();
			theme.Show();
		}
		private void SolvingEquation_Click(object sender, RoutedEventArgs e)
		{
			equation = new Equation();
			this.Close();
			equation.Show();
		}

		private void tableCub_Click(object sender, RoutedEventArgs e)
		{
			cub = new Cub();
			cub.Show();
		}
	}
}
