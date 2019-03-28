using System;

namespace testfunctions
{
    class Test
    {
        public static void Main(string[] args)
        {
            //Connect testconn = new Connect();
            Plants testPlant = new Plants();
            testPlant.ShowPlants();
            Console.WriteLine("done");
        }
    }
}
