using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overwriting
{
    class Player : Character
    {
        //              override - this is inherited from the character but needs changed for this
        public override void HealAlly()
        {
            Console.WriteLine("Your player healed your other player");
        }
    }
}
