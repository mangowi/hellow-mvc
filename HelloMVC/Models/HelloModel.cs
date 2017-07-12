using System;
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
                new Car {Id = 1, Make = "BMW", Model = "499" },
                new Car {Id = 2, Make = "AUD", Model = "599" },
                new Car {Id = 3, Make = "VoksWagon", Model = "699" },
                new Car {Id = 4, Make = "Aston Martin", Model = "799" }

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