using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cinema
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=192.168.21.187,1433;Initial Catalog=cinemaDATA; Integrated Security=True;");
        public void openConnection()
        { 
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        { 
            return sqlConnection; 
        }
    }
}
