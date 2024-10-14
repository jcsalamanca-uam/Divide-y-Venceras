using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_y_Venceras.Algoritmos
{
    public struct Busqueda_binaria
    {
        public int Buscar(int[] arreglo, int objetivo)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arreglo[medio] == objetivo)
                    return medio;

                if (arreglo[medio] < objetivo)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }

            return -1;
        }
    }
}