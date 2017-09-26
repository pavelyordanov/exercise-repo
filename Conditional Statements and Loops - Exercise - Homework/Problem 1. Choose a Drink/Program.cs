using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
          string profession = Console.ReadLine();

            if (profession == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "Businessman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
