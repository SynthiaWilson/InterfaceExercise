using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
            public string carSound { get; set; }
            public bool carEconomy { get; set; }
        public double EngineSize { get; set; }
        public string Make {       get; set; }
        public string Model {       get; set; }
        public int SeatCount { get; set; }
        public string Logo { get; set; }
        public string MySlogan { get; set; }
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
