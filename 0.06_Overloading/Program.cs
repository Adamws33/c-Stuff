using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Adam = new Player();
            Adam.Attack();
            Adam.Attack(5);
            Console.WriteLine("What kind of weapon do you have?");
            Adam.Attack(5, Console.ReadLine());

            Console.ReadLine();
        }
    }
}
