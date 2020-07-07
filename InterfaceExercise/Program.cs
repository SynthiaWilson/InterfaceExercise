using System;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
             * DONE Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany
            // DONE
            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car = new Car();
            car.carEconomy = true;
            car.carSound = "Vroom";
            car.EngineSize = 400.3;
            car.Logo = "Mountain image";
            car.SeatCount = 5;
            car.Make = "BMW";
            car.Model = "385i";
            car.MySlogan = "Driving is our American Pleasure";
           
            
            Truck truck = new Truck();
            truck.LenghtOfBed = 9;
            truck.NumberOfWheels = 8;
            truck.Logo = "Punsisher Image";
            truck.Make = "Long Bed";
            truck.Model = "Ford";
            truck.Slogan = "Hit the Road with us!";
            truck.EngineSize = 8.5;
            
           
            SUV suv = new SUV();
            suv.isFourWheel = true;
            suv.isOffRoad = true;


            Console.WriteLine($" This is the car {car.Make} and the slogan is {car.MySlogan}");
            Console.WriteLine($" This is the length of the bed {truck.SeatCount}");
            Console.WriteLine($" This is the SUV it is {suv.isFourWheel} that is is a 4 wheel");
        }
    }
}
