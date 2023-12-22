using System;
using System.Collections.Generic;


namespace CarDealership.Models
{
    public class Car
    {

        // E.g: Tesla Model Y or Y prime

        public string CarModel { get; set; }

        // Whether car is an electric vehicle or an ICE(Internal combustion engine)
        public string CarEngineType { get; set; }

        // 2 security systems for cars are: Immobilizer and Alarm system
        public string CarSecuritySystem { get; set; }

        // checks whether car is driverless or autonomous... Once car is not driverless, it is a conventional or tradition car 
        public bool CarIsDriverless { get; set; }


        public string CarColor { get; set; }

        public int Id { get; }
        
        private static List<Car> _myCarsInstances = new List<Car>(){};
        
        
        
        
        

        public Car(string myCarModel, string myCarEngineType, string myCarSecuritySystem, bool myCarIsDriverLess, string myCarColor)
        {
            CarModel = myCarModel;
            CarEngineType = myCarEngineType;
            CarSecuritySystem = myCarSecuritySystem;
            CarIsDriverless = myCarIsDriverLess;
            CarColor = myCarColor;
            _myCarsInstances.Add(this);
            Id = _myCarsInstances.Count;
        }

        public static List<Car> GetAllCars()
        {
            return _myCarsInstances;
        }

        public static void RemoveAllCars()
        {
            _myCarsInstances.Clear();
        }

        public static Car FindCar(int searchCarId)
        {
            return _myCarsInstances[searchCarId-1];
        }
    }
}