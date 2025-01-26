using MoneyManagerRodina.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        Window loginWindow;
        User user;

        Database database = new Database();
        public LoginPage(Window loginWindow)
        {
            InitializeComponent();
            this.loginWindow = loginWindow;
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Authorize())
            {
                ManagerWindow managerWindow = new ManagerWindow(user);
                managerWindow.Show();
                loginWindow.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.\nПопробуйте ещё раз.");
            }
        }

        private void RegistrateTextClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }

        private bool Authorize()
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Password;

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
            if (login.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Не все поля заполнены для авторизации.");
            }
            else if (CheckData(login, password))
            {
                return true;
            }
            return false;
        }

        private bool CheckData(string login, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT user_id, name, surname FROM users WHERE login = '{login}' AND password = '{password}'";

            try
            {
                SqlCommand command = new SqlCommand(query, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    var id = table.Rows[0].Field<int>("user_id");
                    var name = table.Rows[0].Field<string>("name");
                    var surname = table.Rows[0].Field<string>("surname");
                    user = new User(id, name, surname);
                    MessageBox.Show($"Добро пожаловать, {table.Rows[0].Field<string>("name")}.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
