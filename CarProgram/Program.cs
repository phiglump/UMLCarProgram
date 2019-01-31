//Author: Philippe Lumpkin
//File: Program.cs
//Purpose: Main class for the program to run from
//Date: 1/29/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = null;
            string answer;
            Console.WriteLine("Welcome User!");
            Console.WriteLine("Would you like a Toyota or a Suzuki?");
            answer = Console.ReadLine();

            if (answer == "Toyota" || answer == "toyota")
            {
                ToyotaFactory t = new ToyotaFactory();
                factory = t;
            }
            else if (answer == "Suzuki" || answer == "suzuki")
            {
                SuzukiFactory s = new SuzukiFactory();
                factory = s;
            }
            else
            {
                Console.WriteLine("There was an error please try again.");
            }

            CarAssembler car = new CarAssembler();
            car.AssembleCar(factory);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
 