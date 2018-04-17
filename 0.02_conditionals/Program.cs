using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = "Allison";
            switch (student)
            {
                case "Isaac":
                    Console.WriteLine("Young mind ready to learn");
                    break;
                case "Aaron":
                    Console.WriteLine("Young mind at work");
                    break;
                case "Adam":
                    Console.WriteLine("Old dog learning new tricks");
                    break;
                default:
                    Console.WriteLine("A steady student");
                    break;
            }
            Console.ReadLine();

        }
    }
}
