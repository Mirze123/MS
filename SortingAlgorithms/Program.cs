namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3,4,1,0,2};

            var sortedArray = QuickSort.Test();
            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }

            // 1. 3,1,0,2,4

            // big o notation
            // time complexity ==>O(n2) // gorduyun islerin sayi
            // space/memory complexity ==> O(1)
            // worst case
            // average case
            // best case

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    int min = i;
            //    for (int j = 0; j < myArray.Length ; j++)
            //    {
            //        int first = myArray[i];
            //        int next = myArray[j];
            //        if (first < next)
            //        {
            //            int temp = first;
            //            myArray[i] = myArray[j];
            //        }
            //    }
            //}


            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    int first = myArray[i];
            //    for (int j = i+1; j < myArray.Length; j++)
            //    {
            //        int next = myArray[j];
            //        if (first.CompareTo(next)>0)
            //        {
            //            (myArray[i], myArray[j]) = (myArray[j], myArray[i]);
            //        }
            //    }
            //}


            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}




        }
    }
}