using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyFarmManagementSystem
{
    internal class DBconnection
    {
        public string connectionstring = @"Data Source = NAVEENR;
                                    Initial Catalog = DairyFarmDB; Integrated Security = True";
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            return conn;
        }
    }
}
