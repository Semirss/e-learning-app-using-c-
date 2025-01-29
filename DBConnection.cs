using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Skill_Nova
{
    internal class DBConnection
    {
        string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"Skill-Nova DB\";Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlCommand cmd;

        public DBConnection()
        {
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        public bool connect()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void closeConnection()
        {
            conn.Close();
        }

        public SqlCommand command()
        {
            return cmd;
        }
    }
}
