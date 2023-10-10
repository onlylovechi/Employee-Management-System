using Oracle.ManagedDataAccess.Client;
using PHANQUYENADMIN.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN.DAO
{
    internal class DataProvider
    {
        private OracleConnection conn;
        public static DataProvider Instance { get; set; }
        public static DataProvider getInstance(string user,string password)
        {
            if(Instance == null)
            {
                Instance = new DataProvider(user,password);
                if (Instance.conn == null)
                {
                    Instance = null;
                }
            }
            return Instance;
        }

        public static void close()
        {
            Instance.conn.Close();
            Instance.conn = null;
            Instance = null;
        }
        private DataProvider(String username,String passowrd)
        {

            string connectionString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
     + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
     + "xepdb1" + ")));Password=" + passowrd + ";User ID=" + username;

                conn = new OracleConnection(connectionString);
            
                try
                {
                    conn.Open();
                    MessageBox.Show("Đăng nhập thành công!");
                }
                catch (OracleException ex)
                {
                conn.Close();
                conn = null;
                }
        }
        public int ExecuteNonQuery(string query)
        {
            int result = 0;

            OracleCommand command = new OracleCommand(query, conn);

            result = command.ExecuteNonQuery();

            return result;
        }

        public object ExecuteScalar(string query)
        {
            object result = null;

            OracleCommand command = new OracleCommand(query, conn);
            result = command.ExecuteScalar();

            return result;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            OracleCommand command = new OracleCommand(query, conn);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
                
                    adapter.Fill(dataTable);            

            return dataTable;
        }
        public DataTable ExecuteProcedure(string query)
        {
            DataTable dataTable = new DataTable();

            OracleCommand command = new OracleCommand(query, conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(command);

            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}



