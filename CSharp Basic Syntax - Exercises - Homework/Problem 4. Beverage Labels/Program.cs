using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfProduct = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double kcal = volume * (energyContent / 100);
            double sugars = (volume * sugarContent) / 100;

            Console.WriteLine("{0}ml {1}:", volume, nameOfProduct);
            Console.WriteLine("{0}kcal, {1}g sugars", kcal, sugars);
        }
    }
}
