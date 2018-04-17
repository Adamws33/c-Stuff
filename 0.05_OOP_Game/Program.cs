using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            //Start Game 
            Console.WriteLine("Welcome soldier.  What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("What would you like your gamer name to be?");
            string gamerName = Console.ReadLine();
            Console.WriteLine("What is your type \n" +
                "1: Barbarian\n"+
                "2: Wizard\n"+
                "3: Monk\n"                           
                );
            string playerType = Console.ReadLine();
            int startingLevel = 1;
            int startingPower;
            while (true)
            {
                Console.Write("Enter a number 1-100 : ");
                if (int.TryParse(Console.ReadLine(), out startingPower))
                {
                    break;
                }
                Console.WriteLine("Please enter an integer value!");
            }
            bool lowPower = false;
            

            Creature Zed = new Creature("zed", 25, 2000, false, "Zed the Great", "Troll" );
    

            Player Adam = new Player(playerName, startingLevel, startingPower, lowPower, gamerName, playerType);
            Adam.playerPowerLevel();


            Console.WriteLine($"Welcome {Adam.PlayerName} to the realm of Oslandious! Your information is below.");
            Console.WriteLine($"From here on out you will be refered to as {Adam.Name} the namesake of your land");
            Console.WriteLine($"I see you are a {Adam.Type} interesting mwhahahaha");
            Console.WriteLine($"As always you will be starting out at the bottom level: {Adam.Level} good luck getting any higher");
            Console.WriteLine($"Starting power: {Adam.CurrentPower}");
            Console.WriteLine($"Low Power {Adam.IsLowOnPower}");
            Console.ReadLine();
        }
    }
}
