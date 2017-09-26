using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int comboCount = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (magicalNum == j + i)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNum}");
                       
                        return;
                    }
                    comboCount++;
                }
            }
            Console.WriteLine($"{comboCount} combinations - neither equals {magicalNum}");
           

        }
    }
}
