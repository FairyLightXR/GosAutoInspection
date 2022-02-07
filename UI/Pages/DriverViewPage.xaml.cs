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
using GosAutoInspection.Entities;
using GosAutoInspection.Utilities;

namespace GosAutoInspection.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для DriverViewPage.xaml
    /// </summary>
    public partial class DriverViewPage : Page
    {
        public DriverViewPage()
        {
            InitializeComponent();
            DriversLV.ItemsSource = Transition.Context.Drivers.ToList();
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
