//Author: Philippe Lumpkin
//File: ToyotaFactory.cs
//Purpose: Main class for the program to run from
//Date: 1/29/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class ToyotaFactory : CarFactory
    {
        public override Car GetCar()
        {

            Toyota tCar = new Toyota
            {
                Model = "",
                Speed = 0
            };
            Console.WriteLine("");
            Console.WriteLine(tCar.Company);
            Console.WriteLine(tCar.Model);
            Console.WriteLine(tCar.Speed);
            return tCar;
        }
    }
}
