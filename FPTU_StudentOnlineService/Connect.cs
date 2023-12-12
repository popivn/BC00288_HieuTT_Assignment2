using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    public class connect
    {
        private SqlConnection conn;
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public void myConnect(string sConnect)
        {
            try
            {
                this.conn = new SqlConnection(sConnect);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public connect()
        {
            try
            {
                string sConnect = @"Data Source=LAPTOP-GGH4Q27J\MSSQLSERVER01;Initial Catalog=StudentOnlineServiceSystem;Integrated Security=True;MultipleActiveResultSets=True";
                this.conn = new SqlConnection(sConnect);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
