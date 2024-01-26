using Ejercicio04.Repaso.Progamacion.Servicios;

namespace Ejercicio04.Repaso.Progamacion.Controladores;


class Program
{
    /// <summary>
    /// Clase principal por la cual la aplicacion se lanzara
    /// <author>DMN - 26/0/2024</author>
    /// </summary>
    /// <param name="args"></param>

    public static void Main(string[] args)
    {   
         /// <summary>
         /// Metodo principal por la cual la aplicacion se inicializara.
         /// <author>DMN - 26/0/2024</author>
         /// </summary>
         /// <param name="args"></param>


        OperativaInterfaz op = new OperativaImplementacion();

        int[,] numero01 = new int[3, 2];

        Random num = new Random();

        for (int i = 0; i < 3; i++)
        {

            for (int j = 0; j < 2; j++)
            {
                numero01[i, j] = num.Next(1, 100);
            }

        }

        // Realizacion de los metodos encagados de mostrar la ordenanza de los numeros

        Console.WriteLine("####################");
        op.mostrarEnumeracion(numero01);
        Console.WriteLine("####################");

        op.ordenar(numero01);
        Console.WriteLine("####################");
      
        op.mostrarEnumeracion(numero01);
        Console.WriteLine("####################");

    }

   
}
