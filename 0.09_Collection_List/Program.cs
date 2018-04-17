using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collection_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var classList = new List<string>();
            classList.Add("Quincy");
            classList.Add("Spencer");
            classList.Add("Aaron M");
            classList.Add("Adam");
            classList.Add("DQ");

            foreach (var member in classList)
            {
                Console.WriteLine("Student: "+ member);
            }

            List<string> fruits = new List<string>()
            {
                "Banana", "Mango", "Pineapple", "Jackfruit", "Breadfruit"
            };

            Console.WriteLine(classList.Capacity);
            Console.WriteLine(fruits.Capacity);


            Console.ReadLine();

        }
    }
}
