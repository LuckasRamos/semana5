using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer4
    {   static void Main(string[] args)
        {
            int n;
            int ceros = 0, pares = 0, impares = 0;
            Console.WriteLine("Ingrese la cantidad de numeros :");
            int cant = int.Parse(Console.ReadLine());


            for (int i = 0; i < cant; i++)
            {
                Console.Write($"Ingresar numero {i+1} : ");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    ceros++;
                }
                else if (n % 2 == 0)
                {
                    pares++;
                }

                else
                {
                    impares++;
                }

            }
            Console.WriteLine("\n\nRESULTADOS");
            Console.WriteLine($"Cantidad de pares : {pares}");
            Console.WriteLine($"Cantidad de impares : {impares}");
            Console.WriteLine($"Cantidad de ceros : {ceros}");

        }
    }
}
