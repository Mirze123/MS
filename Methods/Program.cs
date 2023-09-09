namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int x = 5;
            ////int y = x;

            //ref int y = ref x;
            //x = x * 5;
            //Console.WriteLine(y);

            //int x = 5;
            //Sum(ref x);
            //Console.WriteLine(x);

            //int[] myArray = new int[3];

            //int b;

            Sum1(5, out int b);

            
            MyClass1 my = new MyClass1();
            my.MyProperty = 1;
            Test(ref my);
            Console.WriteLine(my.MyProperty);



        }

       
        static void Test(ref MyClass1 my)
        {
            my = new MyClass1();
            my.MyProperty = 20;

        }



        /*
         
         accessModifier returnValue MethodName()
        {

            

        }
         
         
         
         
         */


        static void Sum(ref int a)
        {
            a = 50;
        }

        static void Sum1(int x, out int y, int z = 30)
        {
            // y in qiymetini teyin etmeye mecburuq eks halda compile time error alaciyiq
            y = x * 5;







        }

    }

    class MyClass1
    {
        public int MyProperty { get; set; }
    }
}