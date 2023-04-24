using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
    public partial class adminwindow9 : Window
    {
        UslugiTableAdapter uslugi = new UslugiTableAdapter();
        public adminwindow9()
        {
            InitializeComponent();
            Uslugi.ItemsSource = uslugi.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow10 admin = new adminwindow10();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow8 admin = new adminwindow8();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (Uslugi.SelectedItem as DataRowView).Row[0];
            uslugi.InsertQuery(Title.Text, Price.Text, Convert.ToInt32(EmployeesID), Convert.ToInt32(PriestID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Uslugi.SelectedItem as DataRowView).Row[0];
            uslugi.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Uslugi.SelectedItem as DataRowView).Row[0];
            uslugi.UpdateQuery(Title.Text, Price.Text, Convert.ToInt32(EmployeesID), Convert.ToInt32(PriestID), Convert.ToInt32(id));
        }
    }
}
