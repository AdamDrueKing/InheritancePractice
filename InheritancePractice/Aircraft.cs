using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Aircraft : Vehicle 
    {
        //fields
        private double altitude;

        //properties
        public double Altitude { get; }

        //constructor
        public Aircraft()
        {
            //default
        }

        public Aircraft(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            altitude = 0.0d;
        }

        public override void Move()
        {
            //refers to base class Move method; take altitude and += 10000d
            altitude += 10000.0d;
            base.Move();
        }

        public override string GetDistanceTraveled()
        {
            //
            return "Altitude " + altitude + "-" + base.GetDistanceTraveled();
        }

    }
}
