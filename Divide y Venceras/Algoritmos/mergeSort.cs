using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_y_Venceras.Algoritmos
{
    public struct MezclaOrdenada
    {
        public void Ordenar(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                Ordenar(arreglo, izquierda, medio);
                Ordenar(arreglo, medio + 1, derecha);
                Mezclar(arreglo, izquierda, medio, derecha);
            }
        }

        private void Mezclar(int[] arreglo, int izquierda, int medio, int derecha)
        {
            int n1 = medio - izquierda + 1;
            int n2 = derecha - medio;

            int[] arregloIzquierda = new int[n1];
            int[] arregloDerecha = new int[n2];

            for (int i = 0; i < n1; i++)
                arregloIzquierda[i] = arreglo[izquierda + i];
            for (int j = 0; j < n2; j++)
                arregloDerecha[j] = arreglo[medio + 1 + j];

            int indiceIzquierda = 0, indiceDerecha = 0;
            int indiceMezcla = izquierda;

            while (indiceIzquierda < n1 && indiceDerecha < n2)
            {
                if (arregloIzquierda[indiceIzquierda] <= arregloDerecha[indiceDerecha])
                {
                    arreglo[indiceMezcla] = arregloIzquierda[indiceIzquierda];
                    indiceIzquierda++;
                }
                else
                {
                    arreglo[indiceMezcla] = arregloDerecha[indiceDerecha];
                    indiceDerecha++;
                }
                indiceMezcla++;
            }

            while (indiceIzquierda < n1)
            {
                arreglo[indiceMezcla] = arregloIzquierda[indiceIzquierda];
                indiceIzquierda++;
                indiceMezcla++;
            }

            while (indiceDerecha < n2)
            {
                arreglo[indiceMezcla] = arregloDerecha[indiceDerecha];
                indiceDerecha++;
                indiceMezcla++;
            }
        }
    }
}
