using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            //int[] myArray = { 7, 3, 6, 5, 1, 9, 2, 4, 8,0 }; 
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    var first = array[minIndex];
                    var second = array[j];

                    if (first.CompareTo(second) > 0)
                    {
                        minIndex = j;
                    }
                }

                var temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
