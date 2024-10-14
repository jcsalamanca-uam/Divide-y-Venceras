using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_y_Venceras.Algoritmos
{
    public struct OrdenamientoRapido
    {
        public void Ordenar(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indicePivote = Particion(arreglo, izquierda, derecha);
                Ordenar(arreglo, izquierda, indicePivote - 1);
                Ordenar(arreglo, indicePivote + 1, derecha);
            }
        }

        private int Particion(int[] arreglo, int izquierda, int derecha)
        {
            int pivote = arreglo[derecha];
            int i = izquierda - 1;

            for (int j = izquierda; j < derecha; j++)
            {
                if (arreglo[j] < pivote)
                {
                    i++;
                    Intercambiar(ref arreglo[i], ref arreglo[j]);
                }
            }

            Intercambiar(ref arreglo[i + 1], ref arreglo[derecha]);
            return i + 1;
        }

        private void Intercambiar(ref int a, ref int b)
        {
            int temporal = a;
            a = b;
            b = temporal;
        }
    }
}
