using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAED_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Escribe el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escribe el segundo numero: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Escribe el tercer numero: ");
            c = int.Parse(Console.ReadLine());

            if (a <= b && a <= c)
            {
                Console.WriteLine("El numero menor es:" + a);

            }
            else
            {
                if (b >= a && b >= a)
                {
                    Console.WriteLine("El numero menor es: " + b);

                }
                else
                {
                    Console.WriteLine("El numero menor es: " + c);
                }

            }
            Console.ReadKey();
        }
    }
}
