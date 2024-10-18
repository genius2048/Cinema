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
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=192.168.201.187,1433;Initial Catalog=cinemaDATA;User Id=123;Password=123;");
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
