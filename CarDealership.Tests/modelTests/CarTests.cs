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

    }
}