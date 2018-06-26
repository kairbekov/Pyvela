using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MySql.Data.MySqlClient;

namespace Pyvela
{
    class DataBase
    {

        public string comm;
        
        

        public void Conn(string c)
        {
            string connect = "server=185.111.107.111; uid=developer; database=testusers; password=DeV_PyVeLa_2018!_; SslMode=none";
            comm = c;
            MySqlConnection conn = new MySqlConnection(connect);
            conn.Open();

            MySqlCommand cm = new MySqlCommand(comm, conn);
            MySqlDataReader read = cm.ExecuteReader();

            while (read.Read())
            {

                for (int i = 1; i < read.FieldCount; i++)
                {
                    Console.WriteLine(read[i]);
                }
                Console.WriteLine("------------------");
            }

            read.Close();
        }
        public void Get()
        {


        }
    }
}