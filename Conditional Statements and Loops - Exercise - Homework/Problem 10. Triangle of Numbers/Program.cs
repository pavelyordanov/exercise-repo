using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 1; j <= num; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
