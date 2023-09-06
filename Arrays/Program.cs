using System.Text;
using System.Collections;


namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ////type[] variable_name  = new type[capacity];

            //int[] studentAges = new int[11];
            //int[] myArr = new int[] { 1, 3, 4, 5, 6, 7, 8, };
            //int[] numbers = { 1, 2, 3 };
            //int[] numbers1 = new[] { 1, 2, 3, 4, };

            //studentAges[1] = 25;
            //int thirdStudentAge = studentAges[2];

            //// Array classi

            //Array numbers156 = new int[] { 1, 2, 3, 4, 5, 6, 7, };
            //int[] numbers16 = new int[56];
            ////numbers156 = numbers16;
            //Console.WriteLine(numbers156[15]);

            // Array numbers = new int[] { 8,5,9,3,6,7,4,2,1,0 };
            //Array numbers1 = new int[20];

            ////Array.Clear(numbers);
            ////Array.Reverse(numbers);
            //Array.Copy(numbers, numbers1,numbers1.Length);
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    Console.WriteLine(numbers1.GetValue(i));
            //}

            //Array.Sort(;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers.GetValue(i));
            //}

            //Range ve Indices ==> C# 8.0 // .. ^

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////Range range = 5..9;

            ////int[] newArray = myArray[range];

            ////for (int i = 0; i < newArray.Length; i++)
            ////{
            ////    Console.WriteLine(newArray[i]);
            ////}

            //Index myIndex = ^6;
            //var elem = myArray[myIndex];
            //Console.WriteLine(elem);

            //Range myRange = 1..^7;
            //Range myRange1 = ^7..^1;

            //var myArr1 = myArray[myRange];
            //var myArr2 = myArray[myRange1];

            //for (int i = 0; i < myArr2.Length; i++)
            //{
            //    Console.WriteLine(myArr2.GetValue(i));
            //}
            //Console.WriteLine(  myArr2);

            //Console.WriteLine(myArray[myArray.Length-1]);
            //Console.WriteLine(myArray[^1]);

            //Array myArray = new int[13];

            //var arr1 = Array.CreateInstance(typeof(int), 14);

            //int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] num2 = numbers;
            //ar nums2 = numbers[5..7];

            //ArraySegment<int> myArrSegment = new ArraySegment<int>(numbers);
            //for (int i = 0; i < myArrSegment.Count; i++)
            //{
            //    Console.WriteLine(myArrSegment[i]);
            //}

            //numbers[0] = 199;

            ////Console.WriteLine(myArrSegment[0]);
            //myArrSegment[0] = 999;
            //Console.WriteLine(numbers[0]);

            //ArraySegment<int> ints = new ArraySegment<int>(numbers,5,2);
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}





            //Console.ReadLine();

            //string myStr = "Codelandia";
            //for (int i = 0; i < myStr.Length; i++)
            //{
            //    Console.WriteLine(myStr[i]);
            //}

            //verbatim



            //string result = "My name" +
            //    ""

            //string result = str1 + str2 + ;
            //string result = string.Format("My name is:{0} and my age is:{1}", str1, str2);
            //Console.WriteLine(result);
            //string result = @"My name is
            //                Mirza and my age is
            //                25";

            // string interpolation == > c# 6.0

            //            string result = @$"My name is:{str1} 
            //and my age is:{str2}";
            //            Console.WriteLine(result);

            //bool result = str1.Equals(str2);
            //Console.WriteLine(result);

            //int result = string.Compare(str1, str2);
            //Console.WriteLine(result);

            //byte result = (byte)str1.CompareTo(str2);


            //StringBuilder sb  = new StringBuilder();
            //sb.Append("Hello");
            //sb.Append("World");
            //Console.WriteLine(sb.ToString());

            //sb.Append(str1).Append(;

            //string str = default; //==> ramda yer tutmur
            //string str1 = " "; // ==> ramda yer tutur

            //if(string.IsNullOrWhiteSpace(str))
            //{
            //    Console.WriteLine("String is null or empty");
            //}
            //else
            //{
            //    Console.WriteLine("Do your operation");
            //}

            //string test = "Codelandia";
            //foreach (int i in 10)
            //{

            //}

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);

           
            MyClass myClass = new MyClass();
            myClass.MyMethod();
            
    


        }
    }
}