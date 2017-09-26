using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                double sum = quantity * 0.70;
                Console.WriteLine("The Athlete has to pay {0:F2}.", sum);
            }
            else if (profession == "Businessman")
            {
                double sum = quantity * 1.00;
                Console.WriteLine("The Businessman has to pay {0:F2}.", sum);
            }
            else if (profession == "Businesswoman")
            {
                double sum = quantity * 1.00;
                Console.WriteLine("The Businesswoman has to pay {0:F2}.", sum);
            }
            else if (profession == "SoftUni Student")
            {
                double sum = quantity * 1.70;
                Console.WriteLine("The SoftUni Student has to pay {0:F2}.", sum);
            }
            else
            {
                double sum = quantity * 1.20;
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, sum);
            }
        }
    }
}
