using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerRodina.Model
{
    public class User
    {
        private int userID;
        private string Surname;
        private string Name;
        
        public User(int id, string name, string surname)
        {
            this.userID = id;
            this.Name = name;
            this.Surname = surname;
        }
        public int getId()
        {
            return userID;
        }
        public string getName()
        {
            return Name;
        }
        public string getSurname()
        {
            return Surname;
        }
    }
}
