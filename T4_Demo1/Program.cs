using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Initial Catalog=NFineBase;User ID=root;Password=12345;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            System.Data.DataTable schema = conn.GetSchema("TABLES");

        }
    }
}
