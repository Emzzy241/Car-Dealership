using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> myCarsList = Car.GetAllCars();
            return View(myCarsList);
        }

        [HttpGet("cars/new")]
        public ActionResult New()
        {
            return View();
        }

        // View for displaying the car
        [HttpPost("/cars")]
        public ActionResult Create(string newCarModel, string newCarEngineType, string newCarSecuritySystem, bool newCarIsDriverless, string newCarColor)
        {
            Car myCar = new Car(newCarModel, newCarEngineType, newCarSecuritySystem, newCarIsDriverless, newCarColor);
            return RedirectToAction("Index");
        }
       
        [HttpGet("/cars/{id}")]
        public ActionResult Show(int id)
        {
            Car foundCar = Car.FindCar(id);
            return View(foundCar);
        }

        
        [HttpGet("/cars/delete")]
        public ActionResult Delete()
        {
            return View();
        }
        
        [HttpPost("/cars/deleteall")]
        public ActionResult DeleteAll()
        {
            Car.RemoveAllCars();
            return RedirectToAction("Index");
        }
    }
}