﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class HelloModel
    {

        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>
            {
                new Car {Id = 1, Make = "BMW", Model = "899" },
                new Car {Id = 2, Make = "AMW", Model = "899" },
                new Car {Id = 3, Make = "CMW", Model = "899" },
                new Car {Id = 4, Make = "5MW", Model = "899" }

            };
            return cars;
        }

    }

    public class Car
    {
        public int Id { get; set; }
        public string  Make { get; set; }
        public string  Model { get; set; }
    }



}