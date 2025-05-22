using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.
            double a, b, c;
            Console.Write("Podaj pierwszą liczbę a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę c = ");
            c = Convert.ToDouble(Console.ReadLine());
            //szukamy liczby największej
            if ((a >= b) && (a >= c))
                    Console.WriteLine("Liczba a={0} jest największa", a);
            else if ((b>=a) && (b>=c))
                    Console.WriteLine("Liczba b={0} jest największa", b);
            else
                Console.WriteLine("Liczba c={0} jest największa", c);
            //szukamy liczby najmniejszej
            if ((a <= b) && (a <= c))
                Console.WriteLine("Liczba a={0} jest najmniejsza", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("Liczba b={0} jest najmniejsza", b);
            else
                Console.WriteLine("Liczba c={0} jest najmniejsza", c);
            Console.ReadKey(true);
        }
    }
}
