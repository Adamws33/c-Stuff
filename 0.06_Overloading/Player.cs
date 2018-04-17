using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Overloading
{
    class Player
    {
        public void Attack()
        {
            Console.WriteLine("The player attacks for some points");
        }

        public void Attack(int points)
        {
            Console.WriteLine("The player attacked for {0} points", points);
        }
        public void Attack(int points, string weaponType)
        {
            Console.WriteLine("You have attached for {0} points using your {1}", points, weaponType);
        }

    }
}
