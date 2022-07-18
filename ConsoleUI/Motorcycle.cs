using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive");
        }

        public bool HasSideCar { get; set; }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motocycle is virtually in drive");
        }
    }


}
