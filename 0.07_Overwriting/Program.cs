using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overwriting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Character 
            Character quincy = new Character();
            quincy.HealAlly();

            //Player
            Player jenn = new Player();
            jenn.HealAlly();

            //Enemy
            Enemy Ork = new Enemy();
            Ork.HealAlly();

            Console.ReadLine();
        }
    }
}
