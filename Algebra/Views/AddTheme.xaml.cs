using System;
using System.Collections.Generic;
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
	/// Логика взаимодействия для AddTheme.xaml
	/// </summary>
	public partial class AddTheme : Window
	{
		DataBase dataBase = new DataBase();

		public AddTheme()
		{
			InitializeComponent();
			dataBase.Connection();
		}

		private void AddBt_Click(object sender, RoutedEventArgs e)
		{
			dataBase.Add(name.Text, content.Text);
			MessageBox.Show("Тема добавлена");
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			this.Close();
		}
	}
}
