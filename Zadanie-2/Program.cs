using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 do
            //potęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^ 10 = 1024.Do obliczenia
            //wartości wyrażenia użyj pętli for

            int n, i, wynik=1;
            Console.Write("Podaj liczbę naturalną: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik *= 2;
            Console.WriteLine("Wynik wynosi:{0}", wynik);
            Console.ReadKey(true);

        }
    }
}
