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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace test1
{
	/// <summary>
	/// Interaction logic for Booking.xaml
	/// </summary>
	public partial class Booking : Window
	{
		
		string dwmatio ;
		string plhrwmh ;
		public Booking()
		{
			this.InitializeComponent();
		string k =	DateTime.Today.ToString("dd-MM-yyyy");    	
		   dateTimePicker1.Text = k;
		   dateTimePicker2.Text = k;
			 dwmatio = "επιλέξατε απλό δωμάτιο ";
			 plhrwmh = "τρόπο πληρομής πιστοτική ";
			
		}
		public void check()
		{ 
			if (pistotikh.IsChecked == true)
			{
				
				metrhta.IsChecked = false;
			
			}
		}	
		public void check2()
		{
			if (metrhta.IsChecked == true)
			{
				pistotikh.IsChecked = false;
			}
		}
		public void checkarisma()
		{ 
			if (lux.IsChecked == true)
			{
				
				
				aplo.IsChecked = false;
				
			}
		}	
		public void checkarisma2()
		{
			if (aplo.IsChecked == true)
			{
				lux.IsChecked = false;
			}
		}
         
		public  void elegxosformas()
    {
       string theDate = dateTimePicker1.Text;
        string theDate2 = dateTimePicker2.Text;
       // int ArxikiHm = dateTimePicker1.Text.Year * 1000 + dateTimePicker1.Text.Month * 100 + dateTimePicker1.Text.Day;
       // int TelikiHm = dateTimePicker2.Value.Year * 1000 + dateTimePicker2.Value.Month * 100 + dateTimePicker2.Value.Day;
       {
      
   }
		
        if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z]"))
        {
            MessageBox.Show("δεν προσθέσατε όνομα");
        }
        else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z]"))
        {
            MessageBox.Show("δεν προσθέσατε επώνυμο");
        }
        else if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
        {
            MessageBox.Show("δεν προσθέσατε άτομα");
        }
        //  else if (ArxikiHm > TelikiHm)
        //{
          //  MessageBox.Show("lathos hmerominia");
        //}

        else
        {

            MessageBox.Show("Ολοκληρώθηκε η κράτηση με στοιχεία : "+ "Όνομα :"  + textBox1.Text + "    "+ "Επώνυμο :" + textBox2.Text + "  Απο  " + theDate + "   Εως  " + theDate2 + "    " + dwmatio + " Με "+ plhrwmh );
			
	   		
   
        }
        
    }

		private void button1_Click(object sender, System.Windows.RoutedEventArgs e)
		{
		 elegxosformas();
		}

		private void aplo_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			checkarisma2();
			 dwmatio = "επιλέξατε απλό δωμάτιο";
		}
		
		private void aplo_Unchecked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void lux_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			checkarisma();
			 dwmatio = "επιλέξατε Lux δωμάτιο ";
		}

		private void pisw_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			lobby lo = new lobby();
			lo.Show();
            this.Close();
		}

		private void metrhta_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			check2();
			plhrwmh = "Τρόπο πληρομής μετρητά";
		}

		private void pistotikh_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			check();
			plhrwmh = "Τρόπο πληρομής πιστοτική";
		}

		private void TextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		

		
	}
}