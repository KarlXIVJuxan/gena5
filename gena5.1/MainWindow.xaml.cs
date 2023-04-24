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
using System.Windows.Navigation;
using System.Windows.Shapes;
using gena5._1.gn5churchDataSetTableAdapters;

namespace gena5._1
{
    public partial class MainWindow : Window
    {
        RegistTableAdapter regist = new RegistTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            var allLogins = regist.GetData().Rows;
            for (int i = 0; i < allLogins.Count; i++)
            {
                if (allLogins[i][1].ToString() == LoginTbx.Text &&
                    allLogins[i][1].ToString() == PasswordTbx.Password)
                {
                    int roleId = (int)allLogins[i][3];
                    switch (roleId)
                    {
                        case 1:
                            adminwindow adm1 = new adminwindow();
                            adm1.Show();
                            break;
                        case 2:
                            userwindow user1 = new userwindow();
                            user1.Show();
                            break;
                    }
                }
            }
        }
    }
}
