using System;
using System.Linq;

namespace PAED_6
{
    class Program
    {
        static string SucesionFrase(string cadena)
        {
            string[] arrayString;
            arrayString = cadena.Split(' ');
            string Posicion = "";
            string[] arrays = new string[arrayString.Count()];
            for (int i = 0; i <= arrayString.Count() - 1; i++)
            {

                arrays[i] = Convert.ToString(arrayString[i]);
            }
            Posicion = "El número mayor esta en la posicion: " + (arrays.ToList().LastIndexOf(arrays.Max()) + 1);
            return Posicion;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cadena de números: ");
            string cadena = Console.ReadLine();

            string Posicion = SucesionFrase(cadena);

            Console.Write(Posicion);
            Console.ReadKey();
        }
    }
}
