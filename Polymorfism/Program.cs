namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Student student = new Student();
            //Human studenyt = new Student();
            //Student student1 = new Human();

            //Student human = new Student();


            //Teacher student = new Student();


            //Human human1 = new Student();

            //Student studentNew = (Student)human1;

            //Human studentNew1 = human1 as Director;

            //object obj = new Student();

            //Human human = new Teacher();
            //Teacher teacher = (Student)human;

            //if (teacher is null)
            //{
            //    Console.WriteLine("Test");
            //}

            //Console.ReadLine();

            //C c = new C();
            //c.Talk();
            //Console.ReadLine();

            MyClass1 myClass1 = new MyClass1();
            myClass1

        }
    }
    #region Examples
    public class Human
    {
        public void HumanTalks()
        {

        }
    }

    public class Student : Teacher
    {
        public void StudentTalks()
        {

        }
    }

    public class Teacher : Human
    {
        public void TeacherTalks()
        {

        }
    }

    public class Employee : Human
    {
        public Director director;
    }

    public class Director : IMyInterface
    {
        public int Calc(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }

    interface IMyInterface
    {
        void Talk();
        int Calc(int x, int y);
    }

    public class A
    {
        public virtual void Talk()
        {
            Console.WriteLine("Talk");
        }
    }

    public class B : A
    {
        public sealed override void Talk()
        {
            Console.WriteLine("B Talks");
        }
    }

    public class C : B
    {
        public override void Talk()
        {
            base.Talk();
        }
    }


    public sealed class MySingleton
    {
        private static MySingleton _instance;
        public static MySingleton Instance => _instance;

        private MySingleton() { }

        static MySingleton()
        {
            _instance = new MySingleton();
        }
    }
    #endregion

    public class MyClass1
    {
        protected int MyProperty { get; set; }

    }


    public class MyClass2:MyClass1
    {
        public void Test()
        {
            
        }
    }

    

    ///  is-a
    ///  has-a
    ///  can-do
    ///  

    /// Assosiation
    /// Aggregation
    /// Composition
    /// sealed
    /// protected
}