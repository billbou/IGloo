using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
namespace test1
{
	/// <summary>
	/// Interaction logic for CafeBarRestaund.xaml
	/// </summary>
	public partial class CafeBarRestaund : Window
	{
		public int result = 0 ;
		public CafeBarRestaund()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void pisw_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			cafebar ca = new cafebar();
			ca.Show();
            this.Close();
		}

		private void TextBox_DataContextChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
		{
			
		}

		private void Button_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.result += 10;
		
			
		}

		private void Label_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			
			 textbox.Text = this.result.ToString() + "€";
		}

		private void Button_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			//result = result + 8;
		}

		private void Button_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			//result = result + 8;
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			this.result += 10;
			textbox.Text = this.result.ToString()+ "€";
		}

		private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			this.result += 8;
			textbox.Text = this.result.ToString()+ "€";
		}

		private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 9;
			textbox.Text = this.result.ToString()+ "€";
			// TODO: Add event handler implementation here.
		}

		private void Button_Click_3(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 14;
			textbox.Text = this.result.ToString()+ "€";// TODO: Add event handler implementation here.
		}

		private void Button_Click_4(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 20;
			textbox.Text = this.result.ToString()+ "€";
			// TODO: Add event handler implementation here.
		}

		private void Button_Click_5(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 3;
			textbox.Text = this.result.ToString()+ "€";// TODO: Add event handler implementation here.
		}

		private void Button_Click_6(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 5;
			textbox.Text = this.result.ToString()+ "€";
			// TODO: Add event handler implementation here.
		}

		private void Button_Click_7(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 7;
			textbox.Text = this.result.ToString()+ "€";
			// TODO: Add event handler implementation here.
		}

		private void Button_Click_8(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 9;
			textbox.Text = this.result.ToString()+ "€";
			// TODO: Add event handler implementation here.
		}

		private void Button_Click_9(object sender, System.Windows.RoutedEventArgs e)
		{
			this.result += 12;
			textbox.Text = this.result.ToString()+ "€";
			// TODO: Add event handler implementation here.
		}
	}
}