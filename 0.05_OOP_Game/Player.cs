using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game
{
    class Player : Person
    {
        //contructor
        public Player(string firstName, int playerLevel, int playerPower, bool isPowerLow, string title, string type)
        {
            this.PlayerName = firstName;
            this.Level = playerLevel;
            this.CurrentPower = playerPower;
            this.IsLowOnPower = isPowerLow;
            this.Name = title;
            this.Type = type;
        }


        
            public void playerPowerLevel()
            {
                if(this.CurrentPower <= 20)
                {
                this.IsLowOnPower = true;
                }else{
                this.IsLowOnPower = false;
                }
            }
        //properties
        public string PlayerName { get; set; }
    }
}
