using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    //sealed wont allow this class to be inhearited to another class - its encapsulation 
    //public sealed class Character

    //prevents instantiation of new objects based on this class.  prevents constructor.   
    //public abstract class Character

    public class Character
    {
        //implied constructor  allows you to create an implied character in our program.cs
        public Character(string username)
        {
            Username = username;
        }

        public Character(string username, int age)
        {
            Username = username;
            Age = age;
        }

        public Character(string username, int age, int health)
        {
            Username = username;
            Age = age;
            Health = health;
        }

        //properties
        public string Username { get; set; }
        public int Age { get; set; }
        public int Health { get; set; }
    }
}
