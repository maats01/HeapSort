using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace __HeapSort
{
    public class HeapSort
    {
        public static void maxHeapfy(int[] array, int i, int n)
        {
            int maior = i;
            int l = 2*i + 1;
            int r = 2*i + 2;

            if(l < n && array[i] < array[l]) maior = l;
            if(r < n && array[maior] < array[r]) maior = r;
            if(maior != i)
            {
                int aux = array[i];
                array[i] = array[maior];
                array[maior] = aux;

                maxHeapfy(array, maior, n);
            }
        }

        public static void minHeapfy(int[] array)
        {
            heap(array);

            for(int n = array.Length - 1; n >= 1; n--)
            {
                int aux = array[0];
                array[0] = array[n];
                array[n] = aux;

                maxHeapfy(array, 0, n);
            }
        }

        public static void heap(int[] array)
        {
            for(int R = array.Length/2 - 1; R >= 0; R--)
            {
                maxHeapfy(array, R, array.Length);
            }
        }

        public static void printArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}