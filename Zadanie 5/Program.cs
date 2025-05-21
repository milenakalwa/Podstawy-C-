using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na
            //ekranie objętość i pole całkowite tego stożka.
            double r, H, l, V, Pc;
            Console.Write("Podaj promień podstawy stożka: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość stożka: ");
            H = Convert.ToDouble(Console.ReadLine());
            V = (r * r * Math.PI) / 3;
            Console.WriteLine("Objętość stożka wynosi: {0}", V);
            l = Math.Sqrt((H * H) + (r * r));
            Pc = Math.PI * (r * r) + Math.PI * r * l;
            Console.Write("Pole całkowite stożka wynosi: {0}", Pc);
            Console.ReadKey(true);
        }
    }
}
