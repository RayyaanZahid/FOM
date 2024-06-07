using Microsoft.Data.SqlClient;

namespace FOM
{
    internal class Connection
    {

        public static class DatabaseConnection
        {
            static SqlConnection Conn = null;

            public static SqlConnection GetConnection()
            {
                string DataSourceName = @"localhost";
                string DataBaseName = "fom";
                string UName = "sa";
                string uPass = "123";
                string strQuery = null;
                if (DataBaseName.Contains(".mdf"))
                {
                    strQuery = "Data Source=" + DataSourceName + ";Integrated Security=true;AttachDbFileName=" + DataBaseName;
                }
                else
                {
                    strQuery = "Data Source= " + DataSourceName + ";Initial Catalog=" + DataBaseName + ";User ID=" + UName + ";Password=" + uPass + "";
                }
                //Conn = new SqlConnection("Data Source= "  + DataSourceName + ";Initial Catalog=" + DataBaseName + ";User ID=" + UName + ";Password=" + uPass + "");

                SqlConnection Conn = new SqlConnection(strQuery);
                return Conn;
            }

        }
    }
}
