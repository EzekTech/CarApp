using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car : Vehicle , IDriveable
    {
        public override void StartEngine()
        {
            Console.WriteLine("Start the Car");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Stop the Car");
        }

        public string Drive()
        {
            return "Drive the Car";
        }

        
       

        
    }
}
