using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> bronze = new Dictionary<int, string>();
            bronze.Add(2000, "American Beauty");
            bronze.Add(2001, "Gladiator");
            bronze.Add(2002, "Beautiful Mind");
            bronze.Add(2003, "Chicago");
            bronze.Add(2004, "Lord Of The Rings");
            bronze.Add(2005, "Million Dollar Baby");

            foreach (KeyValuePair<int, string> pair in bronze)
            {
                Console.WriteLine(pair.Key + ", " + pair.Value);
            }

            Dictionary<int, string> silver = new Dictionary<int, string>();
            silver.Add(2006, "Napolean Dynomite, Another bad movie, Bad movie 3");
            silver.Add(2007, "Troy, Gladiator was awesome, Bad movie 4");
            silver.Add(2008, "Star Wars, Troy was good too, Bad movie 5");
            silver.Add(2009, "Grease, Don't Be A Menace to Society While Drinking Your Juice In The Hood, Bad movie 6");
            silver.Add(2010, "Step Brothers, Juice, Bad movie7");
            silver.Add(2011, "Avitar, I dont know much about movies, Bad movie 8");

            Console.WriteLine("\n And The Nominees are! ");
            foreach (KeyValuePair<int, string> pair in silver)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            Console.WriteLine("\n Select the year to see the winning picture 2000-2005 ");
            int bestPicture = int.Parse(Console.ReadLine());
            Console.WriteLine("The winning movie was {0} for the year {1}", bronze[bestPicture], bestPicture );

            Console.WriteLine("\n Select the year to see the nominees for best picture 2006-2011 ");
            int nomPicture = int.Parse(Console.ReadLine());
            Console.WriteLine("The Nominees were {0} for the year {1}", silver[nomPicture], nomPicture);

            Console.ReadLine();
        }


}
}
