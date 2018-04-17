using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overwriting
{
    class Enemy : Character
    {
        //              override - this is inherited from the character but needs changed for this
        public override void HealAlly()
        {
            Console.WriteLine("The Enemy healed! QUICK GET THEM BEFORE THEY CAN DO IT AGAIN!");
        }
    }
}
