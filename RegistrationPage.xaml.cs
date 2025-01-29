using MoneyManagerRodina.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace MoneyManagerRodina
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {

        Database database = new Database();
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Registrate_Button_Click(object sender, RoutedEventArgs e)
        {
            if (RegistrateSuccess())
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Не получилось зарегистрироваться.\nПопробуйте ещё раз.");
            }
        }

        private bool RegistrateSuccess()
        {
            var name = NameTextBox.Text;
            var surname = SurnameTextBox.Text;
            var login = RegLoginTextBox.Text;
            var password = RegPasswordTextBox.Password;
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                password = builder.ToString();
            }

            if (insertUser(name, surname, login, password))
            {
                return true;
            }

            return false;
        }

        private bool insertUser(string name, string surname, string login, string password)
        {

            string query = $"INSERT INTO Users (Name, Surname, Login, Password) VALUES('{name}','{surname}','{login}','{password}')";

            try
            {
                SqlCommand command = new SqlCommand(query, database.GetConnection());
                database.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else { return false; }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void GoBackTextClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
