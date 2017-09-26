using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();



            if (groupSize <= 50)
            {
                if (package == "Normal")
                {
                    double price = 2500;
                    double sumBeforeDiscount = price + 500.00;
                    double discount = sumBeforeDiscount * (5.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount -discount) / groupSize;

                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
                else if (package == "Gold")
                {
                    double price = 2500;
                    double sumBeforeDiscount = price + 750.00;
                    double discount = sumBeforeDiscount * (10.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
                else if (package == "Platinum")
                {
                    double price = 2500;
                    double sumBeforeDiscount = price + 1000.00;
                    double discount = sumBeforeDiscount * (15.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
            }
           else if (groupSize >= 51 && groupSize <= 100)
            {
                if (package == "Normal")
                {
                    double price = 5000;
                    double sumBeforeDiscount = price + 500.00;
                    double discount = sumBeforeDiscount * (5.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
                else if (package == "Gold")
                {
                    double price = 5000;
                    double sumBeforeDiscount = price + 750.00;
                    double discount = sumBeforeDiscount * (10.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
                else if (package == "Platinum")
                {
                    double price = 5000;
                    double sumBeforeDiscount = price + 1000.00;
                    double discount = sumBeforeDiscount * (15.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
            }
         else if (groupSize >= 101 && groupSize <= 120)
            {
                if (package == "Normal")
                {
                    double price = 7500;
                    double sumBeforeDiscount = price + 500.00;
                    double discount = sumBeforeDiscount * (5.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
                else if (package == "Gold")
                {
                    double price = 7500;
                    double sumBeforeDiscount = price + 750.00;
                    double discount = sumBeforeDiscount * (10.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
                else if (package == "Platinum")
                {
                    double price = 7500;
                    double sumBeforeDiscount = price + 1000.00;
                    double discount = sumBeforeDiscount * (15.00 / 100.00);
                    double sumAfterDiscount = (sumBeforeDiscount - discount) / groupSize;

                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", sumAfterDiscount);
                }
            }
         else if (groupSize >= 121)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
            



