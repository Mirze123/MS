namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Teacher teacher = new Teacher();
            //teacher.Talk();

            //Student student = new(); // => c# 9.0 target typed new expression
            //student.Talk();

            //string x = "salam";
            //string y = "salam";

            //string z = y;
            //y = "1";

            //Human human = new Human();
            //Human human1 = human;

            //bool result = human == human1;

            //Console.WriteLine(result);
        }
    }


    class Student : Teacher
    {
        public void Talk()
        {

        }
    }

    class Teacher : Human
    {
        public void Talk()
        {
            ///
            Console.WriteLine("Teacher talks");

        }
    }


    class Human
    {
        public int Age { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }

        public void Talk()
        {
            Console.WriteLine("Human talks");
        }
    }


    //public class A
    //{
    //    public  int a = 5;
    //    public int MyProperty { get; set; }

    //    public A()
    //    {
    //        // defensive coding
    //        Console.WriteLine(nameof(A));
    //    }
    //}

    //public class B : A
    //{
    //    public B()
    //    {
    //        Console.WriteLine(nameof(B));
    //    }
    //}

    //public class C
    //{
    //    public C()
    //    {
    //        Console.WriteLine(nameof(C));
    //    }

    //    public C(int a)
    //    {

    //    }
    //}


    public class D
    {

        virtual public void Test()
        {
            // algoritm
            int x = 5;
            int y = x * 20;
            Console.WriteLine(y);
        }

    }

    public class E : D
    {
        public int MyProperty { get; set; }
        // name hiding

        //public override void Test()
        //{
        //    int z = 20;

        //    Console.WriteLine(z);

        //}

        override public void Test()
        {
            base.Test();
        }
    }
}