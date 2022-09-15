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
            //Ask and store userName
            Console.WriteLine("Wie heißt du?");
            string userName = Console.ReadLine();
            //print username
            Console.WriteLine("Hello " + userName + "!");
            //Ask and store age
            Console.WriteLine("Wie alt bist du aktuell?");
            int age = Convert.ToInt32(Console.ReadLine());
            //Ask and store future age
            Console.WriteLine("Wie alt bist du in X Jahren?");
            int nextYear = Convert.ToInt32(Console.ReadLine());
            //Sum Years
            int sumYears = age + nextYear;
            //print age
            Console.WriteLine("Du bist in " + nextYear + " Jahren "+ sumYears + " alt");
            //end Programm
            Console.ReadKey();

        }
    }
}
