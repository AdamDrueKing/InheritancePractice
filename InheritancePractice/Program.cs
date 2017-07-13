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



            Automobile carOne = new Automobile (4, 20, 4, 5, 5000, "Red", 260);
            carOne.Move();

            //Change color to gold
            carOne.Color = "Gold";
            Console.WriteLine("Automobile " + carOne.GetDistanceTraveled());


            Aircraft planeOne = new Aircraft(100, 1000000, "purple", 600);
            //get plane to move
            planeOne.Move();
            planeOne.Move();
            Console.WriteLine("Aircraft " + planeOne.GetDistanceTraveled());


            Appliances stove = new Appliances( )

        }
    }
}
