using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //largest number is 32767 in short
            short sh = 32767;
            //largest number is 255
            byte by = 255;
            string st = "Hello World";
            char c = 'c';
            //declared and innitialized 
            char num = '5';
            

            //declared 
            bool isTired;
            //innitialized 
            isTired = true;


            double doub = 7.80;
            float f = 8.75f;
            long l = 7000;

            //make something nullable with ?
            int? n = null;

            int x = 7;
            //cannot set an int variable to a string
            //x = "seven";


            if(isTired)
            {
                Console.WriteLine("GOSH IM SOO TIRED!!!!");

            }
            else
            {
                Console.WriteLine("isnt it a beautiful day!");
            }

            // cw tab tab
            Console.WriteLine(num);
            Console.ReadLine();


        }
    }
}
