using System;
using System.Collections.Generic;
//using System.Speech.Synthesis;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //instatiation - this is an instance of the class
            Donut mattsDonut = new Donut();
            mattsDonut.Type = "Glazed";
            mattsDonut.HasCream = false;
            mattsDonut.Price = 10.99m;
            mattsDonut.Sprinkles = "None";

            //instatiation - this is an instance of the class
            Donut adamsDonut = new Donut();
            adamsDonut.Type = "chocolate frosted";
            adamsDonut.HasCream = false;
            adamsDonut.Price = 0.99m;
            adamsDonut.Sprinkles = "red";

            //instatiation - this is an instance of the class
            Donut paulsDonut = new Donut();
            paulsDonut.Type = "Bear Claw";
            paulsDonut.HasCream = false;
            paulsDonut.Price = 2.50m;
            paulsDonut.Sprinkles = "chcolate";

            //instatiaton
            SpeechSynthesizer talk = new SpeechSynthesizer();
            talk.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            talk.Speak("This is a lot of fun");

            Console.WriteLine(mattsDonut.Type);
            Console.WriteLine("Adam's Donut:" + adamsDonut.Type);
            adamsDonut.PrintDonutType();
            mattsDonut.PrintDonutType();
            paulsDonut.PrintDonutType();
            Console.ReadLine();
        }
        
    }
}
