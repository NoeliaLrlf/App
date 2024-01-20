using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class SqlManager
    {
        private SqlCommand Cmd { get; set; }
        private SqlConnection Conn { get; set; }
        private string _databaseConection;

        public SqlManager(string databaseConection)
        {
            _databaseConection = databaseConection;
        }
        public void Open()
        {

            Conn = new SqlConnection(_databaseConection);
            try
            {

                Conn.Open(); 
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }

        }

        public SqlDataReader Execute(string operation)
        {
            try
            {
                Cmd = new SqlCommand(operation, Conn);

                return Cmd.ExecuteReader();
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
                return Cmd.ExecuteReader();
            }
            
        }

        public void Close()
        {
           Conn.Close();
        }
    }
}
