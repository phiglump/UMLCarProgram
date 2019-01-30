//Author: Philippe Lumpkin
//File: CarFactory.cs
//Purpose: Main class for the program to run from
//Date: 1/29/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    abstract class CarFactory
    {
        public Car GetCar()
        {
            Car newCar = new Car();
        }
    }
}
