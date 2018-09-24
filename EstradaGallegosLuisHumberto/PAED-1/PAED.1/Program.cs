using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAED_2
{
    class Program
    {
        static string MaxMin(string cadena)
        {
            string[] arrayString;
            arrayString = cadena.Split(' ');
            string invertido = "";
            int[] arrayInt = new int [arrayString.Count()];
            for (int i = 0; i <= arrayString.Count() - 1; i++)
            {
                arrayInt[i] = Convert.ToInt32(arrayString[i]);
            }
            invertido = "El número mayor es: " + arrayInt.Max().ToString() + " el número menor es: " + arrayInt.Min().ToString();
            return invertido;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cadena de números: ");
            string cadena = Console.ReadLine();

            string invertido = MaxMin(cadena);

            Console.Write(invertido);
            Console.ReadKey();
        }
    }
}
