using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overwriting
{
    class Character
    {
        //Properties go above methods


        //Methods
               // allows for this method to be changed in other classes
        public virtual void HealAlly()
        {
            Console.WriteLine("Your player healed your ally");
        }

    }
}
