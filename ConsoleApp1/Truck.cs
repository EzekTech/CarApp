using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Vehicle , IDriveable
    {
        public override void StartEngine()
        {
            Console.WriteLine("Start the Truck");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Stop the Truck");
        }

        public string Drive()
        {
            return "Drive the Truck";
        }
         
    }
}
