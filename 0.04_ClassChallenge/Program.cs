using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ClassChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel california = new Hotel();
            california.RoomNumber = 5326;
            california.IsAvaliable = false;
            california.NumberOfBeds = 2;
            california.CheckInName = "Adam Smith";
            california.CheckoutDate = "You can never leave";

            california.PrintRoomInfo();
            california.CheckAvalibility();

            Console.ReadLine();
        }
    }
}
