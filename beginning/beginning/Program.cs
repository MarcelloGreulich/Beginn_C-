using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask and store height
            Console.WriteLine("Wie groß bist du (in Meter)?");
            double height = Convert.ToDouble(Console.ReadLine());
            //Ask and store multiplicator
            Console.WriteLine("Welchen Multiplikator willst du verwenden?");
            double multiplicator = Convert.ToDouble(Console.ReadLine());
            //print and calculate größe
            Console.WriteLine("Du bist " + height * multiplicator + " groß!");
            //end Programm
            Console.ReadKey();

        }
    }
}
