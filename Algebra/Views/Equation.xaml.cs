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
	/// Логика взаимодействия для Equation.xaml
	/// </summary>
	public partial class Equation : Window
	{
		public Equation()
		{
			InitializeComponent();
		}
		private void discrimenant_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				int a, b, c;
				double d, x1, x2;
				a = int.Parse(txtA.Text);
				b = int.Parse(txtB.Text);
				c = int.Parse(txtC.Text);
				d = Math.Pow(b, 2) - 4 * a * c;
				if (d > 0)
				{
					x1 = (-b + Math.Sqrt(d)) / (2 * a);
					x2 = (-b - Math.Sqrt(d)) / (2 * a);
					textBkx1.Text = "x1= " + x1.ToString("0.0");
					textBkx2.Text = "x2= " + x2.ToString("0.0");
				}
				else if (d == 0)
				{
					x1 = -b / (2 * a);
					textBkx1.Text = "x1= " + x1.ToString("0.0");
				}
				else
				{
					MessageBox.Show("Уравнение не имеет корней");
				}
			}
			catch
			{
				MessageBox.Show("Не все значения введены");
			}
		}

		private void vieta_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				int a, b, c;
				a = int.Parse(txtA.Text);
				b = int.Parse(txtB.Text);
				c = int.Parse(txtC.Text);
				double sum = -(b + a);
				double prod = c * a;
				textBkx1.Text = "Сумма корней: " + sum.ToString();
				textBkx2.Text = "Произведение корней: " + prod.ToString();
			}
			catch
			{
				MessageBox.Show("Не все значения введены");
			}
		}
		private void Back_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			this.Close();
			mainWindow.Show();
		}
	}
}
