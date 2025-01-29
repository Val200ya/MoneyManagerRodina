using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerRodina.Model
{
    public class Database
    {
        private SqlConnection sqlConnection = new SqlConnection(
            @"Data Source=DESKTOP-I3TLLJD;Initial Catalog=MoneyManagerDB;Integrated Security=True;");
//510EC4
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
