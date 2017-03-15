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

namespace test1
{
	/// <summary>
	/// Interaction logic for lobby.xaml
	/// </summary>
	public partial class lobby : Window
	{
		public lobby()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void booking_Click(object sender, System.Windows.RoutedEventArgs e)
		{
		Booking bo = new Booking();
			bo.Show();
            this.Close();
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			MainWindow mo = new MainWindow();
			mo.Show();
            this.Close();
		}

		

		private void Image_ContextMenuClosing(object sender, System.Windows.Controls.ContextMenuEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void Label_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			dwmatioslux dw = new dwmatioslux();
			dw.Show();
            this.Close();
			// TODO: Add event handler implementation here.
		}

		private void Label_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			aplodwmatio ap = new aplodwmatio();
			ap.Show();
            this.Close();
			// TODO: Add event handler implementation here.
		}

		private void Label_MouseDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			cafebar ar = new cafebar();
			ar.Show();
            this.Close();
			// TODO: Add event handler implementation here.
		}

		private void Label_MouseDown_3(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}
	}
}