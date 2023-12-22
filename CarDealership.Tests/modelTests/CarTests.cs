using CarDealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace CarDealership.Tests
{
    [TestClass]
    public class CarTests : IDisposable
    {
        public void Dispose()
        {
            Car.RemoveAllCars();
        }
        // First Test: Testing for Creating Instance of car class
        [TestMethod]
        public void CarConstructor_CreatesInstanceOfCar_Car()
        {
            Car myCar = new Car("a", "b", "c", true, "e");
            Assert.AreEqual(typeof(Car), myCar.GetType());
            
        }

        // Second Test: Test to get car model (an auto-implemented property)
        [TestMethod]
        public void GetCarModel_GetsTheCarModel_String()
        {
            // Arrange
            Car myCar = new Car("Tesla Model Y Prime", "b", "c", true, "e");
            string expectedCarModel = "Tesla Model Y Prime";

            // Act
            string returnedCarModel = myCar.CarModel;

            // Assert
            Assert.AreEqual(expectedCarModel, returnedCarModel);

        }

        // Third Test: Test to set car model (an auto-implemented property)
        [TestMethod]
        public void SetCarModel_SetsCarModel_Void()
        {
            // Arrange
            Car myCar = new Car("a", "b", "c", true, "e");
            string newCarModel = "Tesla Model Y Prime";
            
            // Act
            myCar.CarModel = newCarModel;

            // Assert
            Assert.AreEqual(newCarModel, myCar.CarModel);
        }

        // Fourth Test: Test to get car engine type(an auto-implemented property) 
        [TestMethod]
        public void GetCarEngineType_ReturnsCarEngineType_String()
        {
            // Arrange
            Car myCar = new Car("Toyota Camry", "Electric vehicle", "c", true, "e");
            string expectedCarModel = "Electric vehicle";

            // Act
            string returnedCarModel = myCar.CarEngineType;

            // Assert
            Assert.AreEqual(expectedCarModel, returnedCarModel);

        }

        // Fifth Test: Test to set car engine type(an auto-implemented property)
        [TestMethod]
        public void SetCarEngineType_SetsCarEngineType_Void()
        {
            // Arrange
            Car myCar = new Car("a", "b", "c", true, "e");
            string setCarEngineType = "Electric vehicle";

            // Act
            myCar.CarEngineType = setCarEngineType;

            // Assert
            Assert.AreEqual(setCarEngineType, myCar.CarEngineType);
        }

        // Sixth Test: Test to get car's security system (an autoo-implemented property)
        [TestMethod]
        public void GetCarSecuritySystem_ReturnsCarSecuritySystem_String()
        {
            // Arrange
            Car myCar = new Car("a", "b", "Immobilization and Alarm security system", true, "e");
            string expectedCarSecuritySystem = "Immobilization and Alarm security system";

            // Act
            string returnedCarSecuritySystem = myCar.CarSecuritySystem;

            // Assert
            Assert.AreEqual(expectedCarSecuritySystem, returnedCarSecuritySystem);
        }

        // Seventh Test: Test to set my car's security system(an auto-implemented property)
        [TestMethod]
         public void SetCarSecuritySystem_SetsCarSecuritySystem_Void()
        {
            // Arrange
            Car myCar = new Car("a", "b", "c", true, "e");
            string setCarSecuritySystem = "Alarm";

            // Act
            myCar.CarSecuritySystem = setCarSecuritySystem;

            // Assert
            Assert.AreEqual(setCarSecuritySystem, myCar.CarSecuritySystem);
        }

        // Eight Test: Test to get my car's whether car is driverless or not(an auto-implemented property)
        [TestMethod]
        public void GetCarIsDriverless_GetsWhetherCarIsDriverless_Bool()
        {
            // Arrange
            Car myCar = new Car("a", "b", "c", false, "e");
            bool expectedCarIsDriverless = false;

            // Act
            bool returnedCarIsDriverless = myCar.CarIsDriverless;

            // Assert
            Assert.AreEqual(expectedCarIsDriverless, returnedCarIsDriverless);

        }
        // Ninth Test: Test to set my car to driverless(an auto-implemented property)

        [TestMethod]
         public void SetCarIsDriverless_SetsCarIsDriverless_Bool()
        {
            // Arrange
            Car myCar = new Car("a", "b", "c", false, "e");
            bool setCarIsDriverless = true;

            // Act
            myCar.CarIsDriverless = setCarIsDriverless;

            // Assert
            Assert.AreEqual(setCarIsDriverless, myCar.CarIsDriverless);

        }

        // Tenth Test: Test to get my car's color(an auto-implemented property)
        [TestMethod]
        public void GetCarColor_GetsCarColor_String()
        {
            // Arrange
            Car myCar = new Car("a", "b", "c", false, "purple");
            string expectedCarColor = "purple";

            // Act
            string returnedCarColor = myCar.CarColor;

            // Assert
            Assert.AreEqual(expectedCarColor, returnedCarColor);

        }

        // Eleventh Test: Test to set my car's color(an auto-implemented property)
         [TestMethod]
         public void SetCarColor_SetsCarColor_String()
        {
            // Arrange
            Car myCar = new Car("a", "b", "c", false, "purple");
            string setCarColor = "green";

            // Act
            myCar.CarColor = setCarColor;

            // Assert
            Assert.AreEqual(setCarColor, myCar.CarColor);

        }

        // Twelfth Test: Testing my list of cars
        [TestMethod]
        public void GetAllCars_GetsAllInstancesOfCars_List()
        {
            // Arrange
            Car myCar1 = new Car("Toyota Corolla", "ICE", "Alarm", false, "hotpink");
            Car myCar2 = new Car("Toyota Camry", "ICE", "Alarm", false, "purple");
            Car myCar3 = new Car("Tesla Model X", "Electric vehicle", "Immobilization", true, "red");
            List<Car> expectedListOfCars = new List<Car>(){myCar1, myCar2, myCar3};

            // Act
            List<Car> returnedListOfCars = Car.GetAllCars();

            // Assert
            CollectionAssert.AreEqual(expectedListOfCars, returnedListOfCars);

        }

        // Thirteenth Test: Find different cars by their unique ID
        [TestMethod]
        public void FindCar_ReturnsCarWithUniqueId_Car()
        {
            // Arrange
            Car myCar = new Car("Toyota Camry", "ICE", "Alarm", false, "purple");
            Car myCar2 = new Car("Tesla Model X", "Electric vehicle", "Immobilization", true, "red");
            
            // Act
            Car result = Car.FindCar(2);

            // Assert
            Assert.AreEqual(myCar2, result);

        }  





    }
}