using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class QuickSort
    {

        static int[] ints = { 5, 7, 3, 4, 2, 1, 0 };
        public static int[] Test()
        {
            LomutoQuickSort(ints, 0, ints.Length - 1);
            return ints;
        }
        public static void LomutoQuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int partitionIdex = LomutoIndex(array, start, end);
                LomutoQuickSort(array, start, partitionIdex - 1);
                LomutoQuickSort(array, partitionIdex, end);
                
            }
        }

        public static int LomutoIndex(int[] array, int start, int end)
        {

            int pivod = array[end];
            int i = start - 1;
            int j = start;
            for (; j < end; j++)
            {
                if (array[j].CompareTo(pivod) < 0)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
            i++;
            (array[i], array[j]) = (array[j], array[i]);
            return i;

        }


        //public static string[] Test()
        //{
        //    int[] ints = { 5, 7, 3, 9, 4,4, 2, 1, 0 };
        //    string[] strArray = { "B", "A", "E", "C", "F" };
        //    HoareQuickSort(strArray, 0, strArray.Length - 1);
        //    return strArray;
        //}

        //public static void HoareQuickSort(string[] array, int start, int end)
        //{
        //    if (start < end)
        //    {
        //        int partitionIndex = HoarePartition(array, start, end);
        //        HoareQuickSort(array, start, partitionIndex);
        //        HoareQuickSort(array, partitionIndex + 1, end);
        //    }
        //}

        //private static int HoarePartition(string[] array, int start, int end)
        //{
        //    int i = start - 1;
        //    int j = end + 1;
        //    string pivot = array[start];
        //    while (true)
        //    {
        //        do
        //        {
        //            i++;
        //        } while (array[i].CompareTo(pivot) < 0);

        //        do
        //        {
        //            j--;
        //        } while (array[j].CompareTo(pivot) > 0);


        //        if (i>= j)
        //        {
        //            break;
        //        }
        //        (array[i], array[j]) = (array[j], array[i]);
        //    }

        //    return j;
        //}
    }
}
