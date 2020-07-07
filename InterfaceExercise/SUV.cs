using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public bool isFourWheel { get; set; }
        public bool isOffRoad { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public string Logo { get; set; }
        public string MySlogan { get; set; }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
