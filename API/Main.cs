using System;

namespace testfunctions
{
    class Test
    {
        public static void Main(string[] args)
        {
            Connect testconn = new Connect();
            testconn.Select();
            Console.WriteLine("done");
        }
    }
}
