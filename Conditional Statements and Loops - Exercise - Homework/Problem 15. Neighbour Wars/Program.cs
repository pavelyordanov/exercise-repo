using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHp = 100;
            int goshoHp = 100;
            int turn = 0;

            while (peshoHp > 0 || goshoHp > 0)
            {
                turn++;
                if (turn % 2 !=0)
                {
                    goshoHp -= peshoDmg;
                    if (goshoHp < 1)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHp} health.");
                    }
                }
                else
                {
                    peshoHp -= goshoDmg;
                    if (peshoHp < 1)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHp} health.");
                    }
                }
                if (turn % 3 ==0)
                {
                    peshoHp += 10;
                    goshoHp += 10;
                }
            }          
        }
    }
}
