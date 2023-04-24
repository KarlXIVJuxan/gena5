using System;
using System.Collections.Generic;
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
using gena5._1.gn5churchDataSetTableAdapters;
using gena5._1;


namespace gena5._1
{
    public partial class adminwindow5 : Window
    {
        DonationsTableAdapter donations = new DonationsTableAdapter();
        public adminwindow5()
        {
            InitializeComponent();
            Donations.ItemsSource = donations.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow6 admin = new adminwindow6();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow4 admin = new adminwindow4();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (Donations.SelectedItem as DataRowView).Row[0];
            donations.InsertQuery(Thedonatoinsquantity.Text, Thesummofthealldonations.Text, Convert.ToInt32(EmployeesID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Donations.SelectedItem as DataRowView).Row[0];
            donations.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Donations.SelectedItem as DataRowView).Row[0];
            donations.UpdateQuery(Thedonatoinsquantity.Text, Thesummofthealldonations.Text, Convert.ToInt32(EmployeesID), Convert.ToInt32(id));
        }
    }
}
