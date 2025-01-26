using MoneyManagerRodina.Model;
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

namespace MoneyManagerRodina
{
    /// <summary>
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        User user;
        public ManagerWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            ManagerFrame.Navigate(new HomePage());
        }

        private void HomeImageClick(object sender, MouseButtonEventArgs e)
        {
            ManagerFrame.Navigate(new HomePage());
        }

        private void IncomeImageClick(object sender, MouseButtonEventArgs e)
        {
            ManagerFrame.Navigate(new IncomePage());
        }

        private void SpendingsImageClick(object sender, MouseButtonEventArgs e)
        {
            ManagerFrame.Navigate(new SpendingsPage());
        }

        private void AccountImageClick(object sender, MouseButtonEventArgs e)
        {
            ManagerFrame.Navigate(new AccountPage(user));
        }

        private void SettingsImageClick(object sender, MouseButtonEventArgs e)
        {
            ManagerFrame.Navigate(new SettingsPage());
        }
    }
}
