using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny
            //czy też nie.
            int rok;
            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if ((rok % 400 == 0) && (rok % 4 == 0) && (rok % 100 != 0))
                Console.WriteLine("POdany rok jest przestępny.");
            else
                Console.WriteLine("Podany rok nie jest przestępny");
            Console.ReadKey(true);
        }
    }
}
