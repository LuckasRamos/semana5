using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;

            Console.WriteLine("Ingrese lado 1: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 2: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 3: ");
            lado3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("EQUILATERO");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                    Console.WriteLine("ISOSCELES");
            }
            else
            {
                    Console.WriteLine("ESCALENO");
            }
            

        }
    }
}
