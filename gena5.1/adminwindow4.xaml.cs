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
using Microsoft.Win32;

namespace gena5._1
{
    public partial class adminwindow4 : Window
    {
        EmployeesTableAdapter employees = new EmployeesTableAdapter();
        public adminwindow4()
        {
            InitializeComponent();
            Employees.ItemsSource = employees.GetData();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow5 admin = new adminwindow5();
            admin.Show();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow3 admin = new adminwindow3();
            admin.Show();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (Employees.SelectedItem as DataRowView).Row[0];
            employees.InsertQuery(Employees_name.Text, Employees_subname.Text, Convert.ToInt32(RegistID), Convert.ToInt32(SalaryID));
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Employees.SelectedItem as DataRowView).Row[0];
            employees.DeleteQuery(Convert.ToInt32(id));
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Employees.SelectedItem as DataRowView).Row[0];
            employees.UpdateQuery(Employees_name.Text, Employees_subname.Text, Convert.ToInt32(RegistID), Convert.ToInt32(SalaryID), Convert.ToInt32(id));
        }
    }
}
