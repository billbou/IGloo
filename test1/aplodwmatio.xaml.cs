﻿using System;
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
	/// Interaction logic for aplodwmatio.xaml
	/// </summary>
	public partial class aplodwmatio : Window
	{
		public aplodwmatio()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			lobby lo = new lobby();
			lo.Show();
            this.Close();
		}

		private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			
			lobby lo = new lobby();
			lo.Show();
            this.Close();// TODO: Add event handler implementation here.
		}

		private void Image_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		

		

		
	}
}