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

    public partial class userwindow2 : Window
    {
        ScladTableAdapter sclad = new ScladTableAdapter();
        Church_goodsTableAdapter church = new Church_goodsTableAdapter();
        Employees_ProfessionTableAdapter employees = new Employees_ProfessionTableAdapter();
        public userwindow2()
        {
            InitializeComponent();
            Sclad.ItemsSource = sclad.GetData();
            Church_God.ItemsSource = church.GetData();
            Employees_Profession.ItemsSource = employees.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userwindow user1 = new userwindow();
            user1.Show();
        }
    }
}
