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
            //Ask and store alter
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());
            //print age
            Console.WriteLine("Du bist " + age + " alt");
            //end Programm
            Console.ReadKey();

        }
    }
}
