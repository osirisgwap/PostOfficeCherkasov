using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PostOfficeApp.Data
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PostOfficeDB;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}
