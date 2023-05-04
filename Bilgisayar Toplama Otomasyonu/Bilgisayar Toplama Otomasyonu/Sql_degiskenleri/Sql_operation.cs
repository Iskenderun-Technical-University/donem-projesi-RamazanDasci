using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bilgisayar_Toplama_Otomasyonu.Sql_degiskenleri
{
    internal class Sql_operation

    {

        public static SqlConnection sqlConnect = new SqlConnection("Data Source=DESKTOP-T3I6H3S\\SQLEXPRESS;Initial Catalog=With_Computer;Integrated Security=True");

        public static void checkedConnection(SqlConnection Checking)
        {
            if(Checking.State == ConnectionState.Closed)
            {
                Checking.Open();
            }
            else
            {

            }
        }



    }

}
