//Author: Philippe Lumpkin
//File: SuzukiFactory.cs
//Purpose: Main class for the program to run from
//Date: 1/29/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class SuzukiFactory : CarFactory
    {
        public override Car GetCar()
        {
            Suzuki sCar = new Suzuki
            {
                Model = "",
                Speed = 0
            };
            Console.WriteLine("");
            Console.WriteLine(sCar.Company);
            Console.WriteLine(sCar.Model);
            Console.WriteLine(sCar.Speed);
            return sCar;
        }
    }
}
