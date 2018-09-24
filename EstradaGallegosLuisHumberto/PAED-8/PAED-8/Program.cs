using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAED_8
{
    class Program
    {
        private static string Polindromo(string Poli)
        {
            char[] dato = Poli.ToCharArray();
            Array.Reverse(dato);
            return new string(dato);
        }
        static void Main(string[] args)
        {
            Console.Write("Escribe un Palidrome: ");
            string Poli = Console.ReadLine();

            if (Poli.Equals(Polindromo(Poli)))
            {
                Console.WriteLine("Es un Polindromo");
            }
            else
            {
                Console.WriteLine("No es un Polindromo");
            }
            Console.ReadLine();
        }
}
