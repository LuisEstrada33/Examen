using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAED_2
{
    class Program
    {
        static string Invertir(string cadena)
        {
            string[] array;
            array = cadena.Split(' ');
            string invertido = "";
            for (int i = array.Count() - 1; i >= 0; i--)
            {
                invertido = invertido + array[i] + " ";
            }
            return invertido;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Cadena a invertir: ");
            string cadena = Console.ReadLine();

            string invertido = Invertir(cadena);

            Console.Write("La cadena invertida es: " + invertido);
            Console.ReadKey();
        }
    }
}
