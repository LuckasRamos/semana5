using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los segundos: ");
            int s = int.Parse(Console.ReadLine());

            int horas = s / 3600;
            int min = (s % 3600) / 60;
            int seconds = s % 60;

            Console.Write($"\n {horas}:{min}:{seconds}");

            Console.ReadKey();
        }
    }
}
