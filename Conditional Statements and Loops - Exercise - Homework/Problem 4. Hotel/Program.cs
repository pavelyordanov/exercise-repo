using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            if (month == "May")
            {
                int studio = 50;
                int doubleRoom = 65;
                int suite = 75;

                if (nightsCount > 7)
                {
                    double studioDiscount = studio * ( 5.00 / 100.00 );
                    double studioAfterDiscount = studio - studioDiscount;
                    double studioCost = studioAfterDiscount * nightsCount;
                    double suiteCost = suite * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
                else
                {
                    double studioCost = studio * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;
                    double suiteCost = suite * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
            }


            if (month == "October")
            {
                int studio = 50;
                int doubleRoom = 65;
                int suite = 75;

                if(nightsCount > 7)
                {
                    double studioDiscount = studio * (5.00 / 100.00);
                    double studioAfterDiscount = studio - studioDiscount;
                    double studioCost = studioAfterDiscount * (nightsCount - 1);
                    double suiteCost = suite * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
                else
                {
                    double studioCost = studio * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;
                    double suiteCost = suite * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
            }
            if (month == "June")
            {
                int studio = 60;
                int doubleRoom = 72;
                int suite = 82;

                if (nightsCount > 14)
                {                    
                    double studioCost = studio * nightsCount;
                    double suiteCost = suite * nightsCount;
                    double doubleRoomDiscount = doubleRoom * (10.00 / 100.00);
                    double doubleRoomAfterDiscount = doubleRoom - doubleRoomDiscount;
                    double doubleRoomCost = doubleRoomAfterDiscount * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
                else
                {
                    double studioCost = studio * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;
                    double suiteCost = suite * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
            }
            if (month == "September")
            {
                int studio = 60;
                int doubleRoom = 72;
                int suite = 82;

                if (nightsCount >= 15)
                {
                    double studioCost = studio * (nightsCount - 1);
                    double suiteCost = suite * nightsCount;
                    double doubleRoomDiscount = doubleRoom * (10.00 / 100.00);
                    double doubleRoomAfterDiscount = doubleRoom - doubleRoomDiscount;
                    double doubleRoomCost = doubleRoomAfterDiscount * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
                else if (nightsCount > 7)
                {
                    double studioCost = studio * (nightsCount - 1);
                    double suiteCost = suite * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
                else
                {
                    double studioCost = studio * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;
                    double suiteCost = suite * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
            }
            if (month == "July" || month == "August" || month == "December")
            {
                int studio = 68;
                int doubleRoom = 77;
                int suite = 89;

                if (nightsCount > 14)
                {
                    double studioCost = studio * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;
                    double suiteDiscount = suite * (15.00 / 100.00);
                    double suiteAfterDiscount = suite - suiteDiscount;
                    double suiteCost = suiteAfterDiscount * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
                else
                {
                    double studioCost = studio * nightsCount;
                    double doubleRoomCost = doubleRoom * nightsCount;
                    double suiteCost = suite * nightsCount;

                    Console.WriteLine("Studio: {0:F2} lv.", studioCost);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoomCost);
                    Console.WriteLine("Suite: {0:F2} lv.", suiteCost);
                }
            }
        }

     }
    }

