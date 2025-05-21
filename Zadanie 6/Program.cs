using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.
            double a, b, suma, różnica, iloczyn, iloraz;
            Console.Write("Podaj liczbę a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            różnica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("Suma liczb jest równa = {0}, różnica = {1}", suma, różnica);
            Console.WriteLine("Iloczyn liczb jest równy {0}, a iloraz {1}", iloczyn, iloraz);
            Console.ReadKey();
        }
    }
}
