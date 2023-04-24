using System;
using System.Collections.Generic;
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

    public partial class userwindow : Window
    {
        SalaryTableAdapter salary = new SalaryTableAdapter();
        UslugiTableAdapter uslugi = new UslugiTableAdapter();
        DonationsTableAdapter donations = new DonationsTableAdapter();
        public userwindow()
        {
            InitializeComponent();
            Salary.ItemsSource = salary.GetData();
            Uslugi.ItemsSource = uslugi.GetData();
            Donations.ItemsSource = donations.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userwindow2 user2 = new userwindow2();
            user2.Show();
        }
    }
}