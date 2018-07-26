using MySql.Data.MySqlClient;

namespace Pyvela.Data.Remote
{
    class DataBaseClass
    {
        private MySqlConnection conn;
        public void DataBase()
        {
            string connect = "server=185.111.107.111; uid=developer; database=testusers; password=DeV_PyVeLa_2018!_; SslMode=none";
            conn = new MySqlConnection(connect);
            conn.Open();
        }
        public bool Entrance(string email,string pass)
        {
            string show = "SELECT email,password FROM users WHERE email='"+email+"' and password='"+pass+"'";
            MySqlCommand comm = new MySqlCommand(show, conn);
            MySqlDataReader read = comm.ExecuteReader();

            if (read.Read() == true)
            {
                //while (read.Read())
                //{
                //    for (int i = 0; i < read.FieldCount; i++)
                //    {
                        
                //    }
                //}

                read.Close();
                conn.Close();
                return true;
            }
            else
            {
                read.Close();
                return false;
            }
        }

        public bool Registration()
        {

            return true;
        }
    }
}