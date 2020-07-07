using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        //public int MyProperty { get; set; }

        public int SeatCount { get; set; }
        
        public void Drive();
    }
}
