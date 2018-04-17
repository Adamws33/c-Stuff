using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Weekday day = Weekday.Friday;

            switch (day)
            {
                case Weekday.Monday:
                    Console.WriteLine("Somone's got a case of the Mondays!");
                    break;
                case Weekday.Tuesday:
                    Console.WriteLine("TACO TUSEDAY... again");
                    break;
                case Weekday.Wednesday:
                    Console.WriteLine("Its Hump Day!");
                    break;
                case Weekday.Thursday:
                    Console.WriteLine("Almost the end of the week!");
                    break;
                case Weekday.Friday:
                    Console.WriteLine("Happy Friday all! ");
                    break;
                case Weekday.Saturday:
                    Console.WriteLine("Cook outs and cold beer!");
                    break;
                case Weekday.Sunday:
                    Console.WriteLine("TIME FOR CHU....FOOTBALL!");
                    break;
                default:
                    break;
            }


        }
    }
    //Enums are done outside of program usually at the top enum- tab tab enumeration often used with switch statements
    enum Weekday
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }
}
