using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Adamlvl1 = new Character("LilRipstas");
            Character Adamlvl2 = new Character("LilRipstas", 34);
            Character Adamlvl3 = new Character("LilRipstas", 34, 100);

            GreetUserByUsername(Adamlvl3.Username);
            GreetUserByUsername("John");
            Console.ReadLine();
        }
        //static allows for info to be passed in that has not yet been instanciated
        public static void GreetUserByUsername(string name)
        {
            Console.WriteLine("hello, {0}", name);
        }
    }
}
