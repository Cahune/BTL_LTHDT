using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_TN_TranBaoChau
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-OF-CAHU\SQLEXPRESS03;Initial Catalog=QuanLyPhongKham;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
