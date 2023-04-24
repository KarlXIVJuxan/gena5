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

    public partial class adminwindow6 : Window
    {
        Church_ServiceTableAdapter church = new Church_ServiceTableAdapter();
        public adminwindow6()
        {
            InitializeComponent();
            Church_Service.ItemsSource = church.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow7 admin = new adminwindow7();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow5 admin = new adminwindow5();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (Church_Service.SelectedItem as DataRowView).Row[0];
            church.InsertQuery(ServiceTime.Text, EmployeesColvo.Text, Convert.ToInt32(PriestID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Church_Service.SelectedItem as DataRowView).Row[0];
            church.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Church_Service.SelectedItem as DataRowView).Row[0];
            church.UpdateQuery(ServiceTime.Text, EmployeesColvo.Text, Convert.ToInt32(PriestID), Convert.ToInt32(id));
        }
    }
}
