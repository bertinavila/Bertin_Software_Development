using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PRG_322_351
{
    public enum Serializer_Source
    {
        From_Nothing,
        From_File,
        From_Sql
    }

    public class Serializer
    {
        public Serializer(Serializer_Source src = Serializer_Source.From_Nothing)
        {
            
        }

        public void Serialize(Student s)
        {
            _Load_Student_From_Sql( s );
        }

        private void _Load_Student_From_Sql(Student s, String host = "127.0.0.1", String user = "root", String database = "PRG_351")
        {
            MySqlConnection con = new MySqlConnection();
            String ThatConnectionStringThough = "server=" + host + ";uid=" + user + ";database=" + database;
            con.ConnectionString = ThatConnectionStringThough;
            con.Open();
            if (con.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Too bad");
                return;
            }
            String query = "select * from Students";
            MySqlCommand cmd = new MySqlCommand( query, con );
            MySqlDataReader reader = cmd.ExecuteReader();
            int FieldCount = reader.FieldCount;
            for (int i = 0; i < FieldCount; i++)
            {
                String CurrentField = reader.GetString(i);
            }
            
            // Anything below assumes connection is functional

        }
    }
}
