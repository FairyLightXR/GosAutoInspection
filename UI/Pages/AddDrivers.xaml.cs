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
    /// Логика взаимодействия для AddDrivers.xaml
    /// </summary>
    public partial class AddDrivers : Page
    {
        private Drivers addDriver;
        public AddDrivers(Drivers drivers)
        {
            InitializeComponent();
            addDriver = drivers ?? new Drivers();
            DataContext = addDriver;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(addDriver.Surname))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.Name))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.ThirdName))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.PassNum))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.LifeAdress))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.RegAdress))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.Company))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.PhoneNum))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.Email))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(addDriver.Photo))
                addDriver.Photo = "200-sleepy.png";

            if (builder.Length > 0)
            {
                MessageBox.Show(builder.ToString());
                return;
            }

            if (addDriver.GUID == 0)
            {
                Transition.Context.Drivers.Add(addDriver);
            }

            try
            {
                Transition.Context.SaveChanges();
                MessageBox.Show("Данные сохранены");
                Transition.MainFrame.Navigate(new DriverViewPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            Transition.MainFrame.GoBack();
        }
    }
}
