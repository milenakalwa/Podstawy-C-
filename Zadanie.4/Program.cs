using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.
            double a, b, c, d, e, min, max;
            Console.Write("Podaj pierwszą liczbę: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj czwartą liczbę: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj piątą liczbę: ");
            e = Convert.ToDouble(Console.ReadLine());

        }
    }
}
