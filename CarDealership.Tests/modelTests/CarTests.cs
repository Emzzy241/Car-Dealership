using CarDealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace CarDealership.Tests
{
    [TestClass]
    public class CarTests
    {
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

        // Seventh Test: Test to se my car's security system(an auto-implemented property)
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

        // [TestMethod]
        // public void GetCarIsDriverless_GetsWhetherCarIsDriverless_Bool()
        // {
        //     // Arrange
        //     Car myCar = new Car("a", "b", "c", false, "e");
        //     bool expectedCarIsDriverless = false;

        //     // Act
        //     bool returnedCarIsDriverless = myCar.CarIsDriverless;

        //     // Assert

            
        // }






    }
}