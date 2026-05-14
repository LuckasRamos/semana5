using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            int n;
            int pares = 0;
            Console.Write("Ingrese numero :");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+ " ");

                if (i % 2 == 0)
                {
                    pares += i;
                    //pares = pares + i;
                
                }
            }
            Console.Write("\n\nSuma pares : " + pares);

            Console.ReadKey();


        }
    }
}
