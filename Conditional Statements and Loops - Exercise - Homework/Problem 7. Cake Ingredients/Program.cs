﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredientCount = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
                ingredientCount++;
            }

            Console.WriteLine($"Preparing cake with {ingredientCount} ingredients.");
        }
    }
}
              
