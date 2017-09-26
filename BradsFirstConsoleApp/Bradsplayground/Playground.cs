using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradsplayground
{
    class Playground
    {
        static void Main(string[] args)
        {
            string myName = "Braydon";
            string lastName = "Stewart";
            int myAge = 21;
            int myYear = 2015;
            string mySchool = "Greenbush";
            string myDad = "John";
            

            Console.WriteLine($"Hi my name is {myName} {lastName} and i am {myAge} years old");
            Console.WriteLine($"I graduated from { mySchool} in {myYear}");
            Console.WriteLine($"My dads name is {myDad} {lastName}. He is teaching me how to code");
            Console.ReadKey();
        }
    }
}
