using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAED_5
{
    class Program
    {


        static string Sucesion(string cadena)
        {
            string[] arrayString;
            arrayString = cadena.Split(' ');
            string Posicion = "";
            int[] arrayInt = new int[arrayString.Count()];
            for (int i = 0; i <= arrayString.Count() - 1; i++)
            {

                arrayInt[i] = Convert.ToInt32(arrayString[i]);
            }
            Posicion = "El número mayor Esta en la posicion: " + (arrayInt.ToList().IndexOf(arrayInt.Max()) + 1);
            return Posicion;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cadena de números: ");
            string cadena = Console.ReadLine();

            string Posicion = Sucesion(cadena);

            Console.Write(Posicion);
            Console.ReadKey();
        }
    }
}
