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
            //Ask and store entry
            Console.WriteLine("gib mir ein wort!");
            string entry = Console.ReadLine();

            string replaced_entry = entry.Replace("U", "G").Replace("u", "g");

            Console.WriteLine("Der alte Text war " + entry);
            Console.WriteLine("Der neue text ist " + replaced_entry);
            
            //end Programm
            Console.ReadKey();

        }
    }
}
