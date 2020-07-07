using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public int LenghtOfBed { get; set; }
            public int NumberOfWheels { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public string MySlogan { get; set; }

        public void Drive()
        {
            Console.WriteLine("You are driving a Truck");
        }
    }
}
