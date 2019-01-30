//Author: Philippe Lumpkin
//File: Car.cs
//Purpose: Main class for the program to run from
//Date: 1/29/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    abstract class Car
    {
        public virtual string Company { get; }
        public virtual string Model { get; set; }
        public virtual int Speed { get; set; }
    }
}
