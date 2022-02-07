using GosAutoInspection.UI.Pages;
using GosAutoInspection.Utilities;
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

namespace GosAutoInspection
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Transition.MainFrame = MainFrame1;
            MainFrame1.Navigate(new AuthorizationPage());
        }

        private void MainFrame1_ContentRendered(object sender, EventArgs e)
        {

        }
    }
}
