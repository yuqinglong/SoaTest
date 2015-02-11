using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CalcImpl));
            try
            {
                host.Open();
                Console.WriteLine("service is open...");
                Console.ReadLine();
                host.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
