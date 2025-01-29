using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerRodina.Model
{
    public class User
    {
        private int user_id;
        private string surname;
        private string name;
        private string login;
        private string password;
        
        public User(int id, string name, string surname, string login, string password)
        {
            this.user_id = id;
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.password = password;
        }
        public int getId()
        {
            return user_id;
        }
        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }
        public string getLogin()
        {
            return login;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
