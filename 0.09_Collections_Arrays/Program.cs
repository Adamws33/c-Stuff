using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 105, 200, 185, 143, 175 };

            //arrays cannot grow in size after created
            //arrays are stronly typed cannot have a string with an integer


            foreach(int score in scores)
            {
                Console.WriteLine("Your Score is: " + score + " ");
            }
            Console.ReadLine();
        }
    }
}
