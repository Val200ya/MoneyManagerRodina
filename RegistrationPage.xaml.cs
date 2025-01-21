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

namespace MoneyManagerRodina
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private bool registrationSuccess = false;
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Registrate_Button_Click(object sender, RoutedEventArgs e)
        {
            registrationSuccess = CheckDataRegistration();
            if (registrationSuccess)
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Не получилось зарегистрироваться.\nПопробуйте ещё раз.");
            }
        }

        private bool CheckDataRegistration()
        {
            bool emptyFields = SurnameTextBox.Text.Equals("") ||
                NameTextBox.Text.Equals("") || LoginTextBox.Text.Equals("") || PasswordBox.Password.Equals("");
            return !emptyFields;
        }

        private void GoBackTextClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
