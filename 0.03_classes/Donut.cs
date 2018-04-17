using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_classes
{
    class Donut
    {
        //properties of our donut Always caps on properties
        public string Type { get; set; }
        public bool HasCream { get; set; }
        public decimal Price { get; set; }
        public string Sprinkles { get; set; }

        //method / void=no return needed / PrintDonutType = Method signature
        public void PrintDonutType()
        {
            Console.WriteLine(this.Type);
        }
    }
}
