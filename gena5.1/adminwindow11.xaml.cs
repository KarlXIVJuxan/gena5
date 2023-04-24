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

namespace gena5._1
{
    public partial class adminwindow11 : Window
    {
        ScladTableAdapter sclad = new ScladTableAdapter();
        public adminwindow11()
        {
            InitializeComponent();
            Sclad.ItemsSource = sclad.GetData();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow12 admin = new adminwindow12();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow10 admin = new adminwindow10();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (Sclad.SelectedItem as DataRowView).Row[0];
            sclad.InsertQuery(QantityOfGods.Text, Convert.ToInt32(TowarNameID), Convert.ToInt32(EmployeesID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Sclad.SelectedItem as DataRowView).Row[0];
            sclad.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Sclad.SelectedItem as DataRowView).Row[0];
            sclad.UpdateQuery(QantityOfGods.Text, Convert.ToInt32(TowarNameID), Convert.ToInt32(EmployeesID), Convert.ToInt32(id));
        }
    }
}
