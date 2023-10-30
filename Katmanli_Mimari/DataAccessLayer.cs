using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli_Mimari
{
    internal class DataAccessLayer
    {
        // Bu katmanda olması gerekenler...
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;

        // 
        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=.; Initial Catalog = AdoNet; User ID = sa; Password = 1";

        }
        internal void connectionConfig()
        {
            if(connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }
        internal int SaveData(Customer customer)
        {
            // Database içerisine kaydetme işlemleri olacak.
            return 1;
        }

    }
}
