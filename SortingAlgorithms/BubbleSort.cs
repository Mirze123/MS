using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            // int[] myArray = { 7, 3, 6, 5, 1, 9, 2, 4, 8,0 }; 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    int first = array[j];
                    int next = array[j + 1];
                    if (first.CompareTo(next) > 0)
                    {
                        //var temp = array[j];
                        //array[j] = array[j + 1];
                        //array[j + 1] = temp;
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }

        public static Result MyMethod()
        {
            return new Result()
            {
                Mybool = true,
                MyInt = 0,
            };
        }
    }

    public class Result
    {
        public int MyInt { get; set; }
        public bool Mybool { get; set; }
    }
}



/*
 
 1 150
2 200
3 300
4 500
5 600
6 150
7100
8 50
9 25
10 500
11 670
12 700
 
 
 
 */