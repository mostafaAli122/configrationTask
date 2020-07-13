using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Configration.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Configration.service.ConfigrationService));


            host.Open();


            Console.WriteLine("Service Is Running !!!");
            Console.ReadLine();

            host.Close();
        }
    }
}
