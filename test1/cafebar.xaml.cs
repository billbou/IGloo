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
	/// Interaction logic for cafebar.xaml
	/// </summary>
	public partial class cafebar : Window
	{
		public cafebar()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void parigile_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			CafeBarRestaund ba = new CafeBarRestaund();
			ba.Show();
            this.Close();
		}

		

		private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			
			lobby lo = new lobby();
			lo.Show();
            this.Close();
			// TODO: Add event handler implementation here.
		}
	}
}