using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceReference1.CalcClient c = new ServiceReference1.CalcClient();
            // Console.WriteLine(c.Add(1.0, 2.0));
            int i = 0;
            i = 1 + ++i;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
