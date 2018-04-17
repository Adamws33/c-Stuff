using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game
{
     public class Creature : Person
    {
        public Creature(string firstName, int creatureLevel, int creaturePower, bool isPowerLow, string title, string type)
        {
            this.CreatureName = firstName;
            this.Level = creatureLevel;
            this.CurrentPower = creaturePower;
            this.IsLowOnPower = isPowerLow;
            this.Name = title;
            this.Type = type;

        }
        public string CreatureName { get; set; }
    }
}
