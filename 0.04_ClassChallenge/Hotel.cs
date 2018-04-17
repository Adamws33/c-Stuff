using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ClassChallenge
{
    class Hotel
    {
        //properties of our hotel Always caps on first letter of properties
        public int RoomNumber { get; set; }
        public string CheckInName { get; set; }
        public bool IsAvaliable { get; set; }
        public int NumberOfBeds { get; set; }
        public string CheckoutDate { get; set; }

        public void PrintRoomInfo()
        {
            Console.WriteLine($"Welcome {CheckInName} to the Hotel California your room number is {RoomNumber} your room has {NumberOfBeds} beds.  Your check out date is: {CheckoutDate}");
        }

        public void CheckAvalibility()
        {
            if (RoomNumber < 6000)
            {
                Console.WriteLine($"Yes {CheckInName} Room {RoomNumber} is available.");
            }
            else
            {
                Console.WriteLine($"I'm sorry {CheckInName}, {RoomNumber} is not available.");
            }
        }
        
    }
}
