using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        //int[] myArray = { 7, 3, 6, 5, 1, 9, 2, 4, 8,0 }; 
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j>=0 && array[j].CompareTo(key)>0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j+1] = key;
            }
        }
    }
}
