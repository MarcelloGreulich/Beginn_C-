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
            string entry = "Das ist ein Text mit wörtern";

            string[] entries = entry.Split(' ');

            foreach (string wort in entries)
            {
                Console.WriteLine(wort);
            }

            for (int i = 0;i< entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }

            //end Programm
            Console.ReadKey();

        }
    }
}
