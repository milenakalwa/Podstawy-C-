using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
            int a, b, P, Obw;
            Console.Write("Podaj długość boku a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość boku b: ");
            b = Convert.ToInt32(Console.ReadLine());
            P = a * b;
            Obw = a + a + b + b;
            Console.WriteLine("Pole prostokąta wynosi: {0}", P);
            Console.WriteLine("Obwód prostokąta wynosi: {0}", Obw);
            Console.ReadKey(true);

        }
    }
}
