using GosAutoInspection.Utilities;
using GosAutoInspection.Entities;
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

namespace GosAutoInspection.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        List<UserLogin> usrLog = Transition.Context.UserLogin.ToList();
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {

            foreach (var item in usrLog)
            {
                if (LogTxt.Text == item.Login.ToString() || PasstxtBox.Password.ToString() == item.Password.ToString())
                {
                    Transition.MainFrame.Navigate(new DriverViewPage());
                }
                else
                {
                    MessageBox.Show("Неверный логин или пороль");
                }
            }
        }
    }
}
