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
    public partial class adminwindow2 : Window
    {
        RoleTableAdapter role = new RoleTableAdapter();
        public adminwindow2()
        {
            InitializeComponent();
            Role.ItemsSource = role.GetData();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow3 admin = new adminwindow3();
            admin.Show();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow admin = new adminwindow();
            admin.Show();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (Role.SelectedItem as DataRowView).Row[0];
            role.InsertQuery(Role_Name.Text);
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Role.SelectedItem as DataRowView).Row[0];
            role.DeleteQuery(Convert.ToInt32(id));
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Role.SelectedItem as DataRowView).Row[0];
            role.UpdateQuery(Role_Name.Text, Convert.ToInt32(id));
        }
    }
}
