namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3,4,1,0,2};
            int[] myArray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            myArray1 = myArray;


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





            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            (int a, int b) = (5, 3);

            SelectionSort.Sort(myArray);

            var result = BubbleSort.MyMethod();
            result.
        }
    }
}