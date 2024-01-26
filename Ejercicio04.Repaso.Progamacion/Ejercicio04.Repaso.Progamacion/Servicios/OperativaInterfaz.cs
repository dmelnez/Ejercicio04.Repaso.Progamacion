using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Repaso.Progamacion.Servicios
{
    internal interface OperativaInterfaz
    {

        /// <summary>
        /// Metodo encargado de mostrar la ordenanza de los numeros
        /// <author>DMN - 26/01/2024</author>
        /// </summary>
        /// <param name="numero01"></param>
         public  void mostrarEnumeracion(int[,] numero01);


        /// <summary>
        /// Metodo encargado de la ordenanza de los numeros
        /// <author>DMN - 26/01/2024</author>
        /// </summary>
        /// <param name="numero01"></param>
          public void ordenar(int[,] numero01);
    }
}
