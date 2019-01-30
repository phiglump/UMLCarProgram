//Author: Philippe Lumpkin
//File: Suzuki.cs
//Purpose: Main class for the program to run from
//Date: 1/29/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class Suzuki : Car
    {
        private string company;
        private string model;
        private int speed;

        public override string Company
        {
            get
            {
                return company;
            }
        }

        public override string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = "Jimmy";
            }
        }

        public override int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = 130;
            }
        }
    }
}
