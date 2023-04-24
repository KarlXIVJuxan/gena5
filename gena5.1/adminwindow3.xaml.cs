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
    public partial class adminwindow3 : Window
    {
        PriestTableAdapter priest = new PriestTableAdapter();
        public adminwindow3()
        {
            InitializeComponent();
            Priest.ItemsSource = priest.GetData();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow4 admin = new adminwindow4();
            admin.Show();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow2 admin = new adminwindow2();
            admin.Show();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (Priest.SelectedItem as DataRowView).Row[0];
            priest.InsertQuery(Priest_Name.Text, Religion.Text, Convert.ToInt32(RegistID), Convert.ToInt32(SalaryID));
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Priest.SelectedItem as DataRowView).Row[0];
            priest.DeleteQuery(Convert.ToInt32(id));
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Priest.SelectedItem as DataRowView).Row[0];
            priest.UpdateQuery(Priest_Name.Text, Religion.Text, Convert.ToInt32(RegistID), Convert.ToInt32(SalaryID), Convert.ToInt32(id));
        }
    }
}
