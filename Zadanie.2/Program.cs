using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
            //dodatnia, ujemna, czy też równa zero.
            int a;
            Console.Write("Podaj liczbę całkowitą a = ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Podana liczba jest liczbą dodatnią.");
            else if (a < 0)
                Console.WriteLine("Podana liczba jest liczbą ujemną");
            else
                Console.WriteLine("Podana liczba jest równa 0)");
            Console.ReadKey(true);
        }
    }
}
