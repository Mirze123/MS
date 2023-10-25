namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //XDelegate myDelegate = new XDelegate(WriteToConsole);
            //XDelegate myDelegate = WriteToConsole;

            //XDelegate xDelegate = () =>
            //{
            //    Console.WriteLine("Test1");
            //};

            //xDelegate += () =>
            //{
            //    Console.WriteLine("Test2");
            //};

            //xDelegate += WriteToConsole;

            //xDelegate += () => Console.WriteLine("Test3");
            //xDelegate += () => Console.WriteLine("Test4");
            //xDelegate += () => Console.WriteLine("Test5");

            //xDelegate();

            //xDelegate -= WriteToConsole;

            //xDelegate();

            //Example.Add(new Student
            //{
            //    Age = 1,
            //    FirstName = "Tt",
            //    LastName = "Test1",
            //    Patronymic = "Test2"
            //});

            //Example example = new Example();
            //Example.Students.Add(new Student { Age = 1, FirstName = "a", LastName = "b", Patronymic = "c" });
            //Example.Students.Add(new Student { Age = 1, FirstName = "a", LastName = "b", Patronymic = "c" });
            //Example.Students.Add(new Student { Age = 1, FirstName = "a", LastName = "b", Patronymic = "c" });
            //Example.Students.Add(new Student { Age = 1, FirstName = "a", LastName = "b", Patronymic = "c" });
            //Example.Students.Add(new Student { Age = 1, FirstName = "a", LastName = "b", Patronymic = "c" });
            //Example.Students.Add(new Student { Age = 1, FirstName = "a", LastName = "b", Patronymic = "c" });
            //Example.Students.Add(new Student { Age = 1, FirstName = "a", LastName = "b", Patronymic = "c" });
            //Console.WriteLine(Example.Students.Count);
            //Example example1 = new Example();
            //Console.WriteLine(Example.Students.Count);

            ExampleOne exampleOne = new ExampleOne();
            var ints =  exampleOne.Test();

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }





            //myDelegate.Invoke();
            //myDelegate();

            //List<int> ints = new List<int>();
            //ints.FirstOrDefault(x => x == 5);

            Console.ReadLine();

        }

        public static void WriteToConsole()
        {
            Console.WriteLine("This is my first delegate");
        }

        public int GetIntData(XDelegate callback)
        {
            if (5 == 5)
            {
                callback();
                return 0;
            }
        }



        public delegate void XDelegate();
    }
}