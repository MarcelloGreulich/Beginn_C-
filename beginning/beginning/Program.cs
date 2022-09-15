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
            //Ask and store age
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());
            //test if user is 18+ 
            if(age < 18)
            {
                Console.WriteLine("Du kommst hier net rein!");
            }
            else
            {
                Console.WriteLine("Viel Spaß");
            }

            //end Programm
            Console.ReadKey();

        }
    }
}
