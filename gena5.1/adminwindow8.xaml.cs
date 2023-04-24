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
    public partial class adminwindow8 : Window
    {
        SalaryTableAdapter salary = new SalaryTableAdapter();
        public adminwindow8()
        {
            InitializeComponent();
            Salary.ItemsSource = salary.GetData();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow9 admin = new adminwindow9();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow7 admin = new adminwindow7();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (Salary.SelectedItem as DataRowView).Row[0];
            salary.InsertQuery(sAlary.Text);
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Salary.SelectedItem as DataRowView).Row[0];
            salary.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Salary.SelectedItem as DataRowView).Row[0];
            salary.UpdateQuery(sAlary.Text, Convert.ToInt32(id));
        }
    }
}
