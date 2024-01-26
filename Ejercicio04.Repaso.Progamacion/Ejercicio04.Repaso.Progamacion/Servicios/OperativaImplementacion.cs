using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Repaso.Progamacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public static void mostrarEnumeracion(int[,] numero01)
        {
            for (int i = 0; i < numero01.GetLength(0); i++)
            {

                for (int j = 0; j < numero01.GetLength(1); j++)
                {

                    Console.Write(numero01[i, j]);
                }
                Console.WriteLine();


            }


        }

        public static void ordenar(int[,] numero01)
        {
            for (int j = 0; j < numero01.GetLength(1); j++)
            {
                for (int i = 0; i < numero01.GetLength(0) - 1; i++)
                {
                    for (int k = i + 1; k < numero01.GetLength(1); k++)
                    {
                        if (numero01[i, j] > numero01[k, j])
                        {
                            int a = numero01[i, j];
                            numero01[i, j] = numero01[k, j];
                            numero01[k, j] = a;
                        }
                    }
                }
            }
        }

    }
}
