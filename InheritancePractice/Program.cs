using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boatOne = new Boat(2, 500, "White and Yellow", 70d, 0.78d);
            boatOne.Move();
            boatOne.Move();
            Console.WriteLine("Boat moved " + boatOne.GetDistanceTraveled());



        }
    }
}
