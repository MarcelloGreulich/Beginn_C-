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

            //delete spaces
            string trim_entry = entry.Trim(' ','a');

            //print strings
            Console.WriteLine("Old String " + entry + ":");
            Console.WriteLine("New String " + trim_entry + ":");

            //end Programm
            Console.ReadKey();

        }
    }
}
