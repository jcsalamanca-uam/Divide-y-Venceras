using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_y_Venceras.Algoritmos
{
    public struct mergeSort
    {
        public void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                Sort(array, left, mid);
                Sort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[mid + 1 + j];

            int iIndex = 0, jIndex = 0;
            int kIndex = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    array[kIndex] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    array[kIndex] = rightArray[jIndex];
                    jIndex++;
                }
                kIndex++;
            }

            while (iIndex < n1)
            {
                array[kIndex] = leftArray[iIndex];
                iIndex++;
                kIndex++;
            }

            while (jIndex < n2)
            {
                array[kIndex] = rightArray[jIndex];
                jIndex++;
                kIndex++;
            }
        }
    }
}
