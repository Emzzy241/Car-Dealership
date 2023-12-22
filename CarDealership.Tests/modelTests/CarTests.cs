using CarDealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace CarDealership.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarConstructor_CreatesInstanceOfCar_Car()
        {
            Car myCar = new Car("a", "b", "c", true, "e");
            Assert.AreEqual(typeof(Car), myCar.GetType());
            
        }

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

        // [TestMethod]
        // public void GetCarEngineType_ReturnsCarEngineType_String()
        // {
        //     // Arrange
        //     Car myCar = new Car("a", "b", "c", true, "e");
        //     string expectedCarModel = "Toyota Camry";

        //     // Act

        // }



    }
}