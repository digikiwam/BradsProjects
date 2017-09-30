using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckinLoopy
{
    class Program
    {
        /// <summary>
        /// Loops and Shit
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string cat = "Oswin";
            int age = 10;

            for (int i = 0; i <= age; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("jack");

                }
                else
                {
                    Console.WriteLine(i + " " + cat);
                }

            }
            string[] myArray = {"oswin","jack","hel","delilah","sampson" };

            foreach (var pet in myArray)
            {
                Console.WriteLine($"These are the animals we know.{pet}");

            }

            List<string> myList = new List<string>();
            myList.Add("milk");
            myList.Add("eggs");
            myList.Add("bread");
            myList.Add("cheese");
            myList.Add("burritos");
            myList.Add("butter");

            int j = 0;
            while(j < myList.Count)
            {
                Console.WriteLine(j + " " + myList[j]);
                j++;
            }

            foreach (var item in myList)
            {
                Console.WriteLine($"This is inside of foreach {item}");
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);

            }




            Console.ReadLine();

        }
    }
}
