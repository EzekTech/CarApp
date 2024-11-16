using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Motorcycle : Vehicle , IDriveable
    {
        public override void StartEngine()
        {
            Console.WriteLine("Start the Motorcycle");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Stop the Motorcycle");
        }

        public string Drive()
        {
            return "Drive the Motorcycle";
        }

        
        
    }
}
