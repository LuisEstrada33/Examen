using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAED._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] random = new int[10,10];

            Random rmd = new Random();
            Console.WriteLine("Numeros Aleatorios");
             for(int fila =0; fila< 10;fila++)
            {
                for (int columna = 0; columna < 10; columna++)
                {
                    
                    random[fila, columna] = Convert.ToInt16(rmd.Next(1, 100));
                    Console.Write(random[fila, columna] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n************************************************");
            Console.WriteLine("Numeros no decrecientes");
            int aux;
            for (int f = 0; f<10; f++)
            {
                for(int c=0;c<10;c++)
                {
                    for (int f1 = 0; f1 < 10; f1++)
                    {
                        int caux = 0;
                        if (f ==f1)
                        {
                            caux = c + 1;
                        }
                        for (int c1 = caux; c1 < 10; c1++)
                        {
                            if (random[f, c] <random[f1, c1])
                            {
                                aux = random[f1, c1];
                                random[f1, c1] = random[f,c];
                                random[f, c] = aux;
                            }
                        }
                    }
                }
            }
            for (int fila = 0; fila < 10; fila++)
            {
                for (int columna = 0; columna < 10; columna++)
                {
                    
                    Console.Write(random[fila, columna] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
