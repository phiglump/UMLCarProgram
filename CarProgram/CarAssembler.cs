//Author: Philippe Lumpkin
//File: CarAssembler.cs
//Purpose: Main class for the program to run from
//Date: 1/29/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class CarAssembler
    {
        public void AssembleCar(CarFactory factory)
        {
            factory.GetCar();
        }
    }
}
