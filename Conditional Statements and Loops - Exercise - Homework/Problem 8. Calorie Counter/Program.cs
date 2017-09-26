using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int cheeseCalories = 500;
            int tomatoSauceCalories = 150;
            int salamiCalories = 600;
            int pepperCalories = 50;

            int totalCalories = 0;

            int ingredientsCount = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= ingredientsCount; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCalories = cheeseCalories + totalCalories;
                        break;
                    case "tomato sauce":
                        totalCalories = tomatoSauceCalories + totalCalories;
                        break;
                    case "salami":
                        totalCalories = salamiCalories + totalCalories;
                        break;
                    case "pepper":
                        totalCalories = pepperCalories + totalCalories;
                        break;
                    default:
                        break;                     
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
