using _0._05_OOP_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //public is open to the namespace 
            BankPublic bankPublic = new BankPublic();
            decimal amount = bankPublic.GetAmount();
            Console.WriteLine("Your balance is ${0}.", amount);

            BankProtected bankProtected = new BankProtected();
            bankProtected.CloseAccount();

            //public class from 0.05 that can be instanciated here.  
            Creature steve = new Creature("zed", 25, 2000, false, "Zed the Great", "Troll");

            //accessors - Access modifiers 
            //public              -> open to all
            //protected           -> open to the class and all derived classes
            //private             -> open only to the class itself
            //internal            -> open to the namespace including subclasses
            //protected internal  -> limited to current assembly and derived types

            Console.ReadLine();
        }
    }
}
