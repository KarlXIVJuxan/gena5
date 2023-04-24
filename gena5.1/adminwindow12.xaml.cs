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
    public partial class adminwindow12 : Window
    {
        Church_goodsTableAdapter church = new Church_goodsTableAdapter();
        public adminwindow12()
        {
            InitializeComponent();
            ChurchGoods.ItemsSource = church.GetData();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminwindow admin = new adminwindow();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            adminwindow11 admin = new adminwindow11();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (ChurchGoods.SelectedItem as DataRowView).Row[0];
            church.InsertQuery(TowarName.Text, TowarPrice.Text);
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (ChurchGoods.SelectedItem as DataRowView).Row[0];
            church.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (ChurchGoods.SelectedItem as DataRowView).Row[0];
            church.UpdateQuery(TowarName.Text, TowarPrice.Text, Convert.ToInt32(id));
        }
    }
}
