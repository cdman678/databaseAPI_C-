using System;
using MySql.Data.MySqlClient;
///using System.Collections.Generic;

namespace testfunctions
{
    class Test
    {
        public static void Main(string[] args)
        {
            //Connect testconn = new Connect();
            Plants testPlant = new Plants();
            MySqlDataReader plantlist = testPlant.ShowAll("masterPlants");
            
            //interact with plantlist HERE

            //this closes plantlist
            testPlant.Close();       
            Console.WriteLine("Done");
        }
    }
}
