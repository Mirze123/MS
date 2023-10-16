namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Product product = new Product();
            //ProductCart productCart = new Product();

            IHuman employee = new Student();
            employee.Eat();
            Console.ReadLine();

            // abstract class
            // interface

            IProductCardOperation productCardOperation = new Product();
            IMainProductOperation mainProductOperation = new Product();
            Product product = new Product();

            ITest2 myTest = new Test();
            myTest.Foo
            //mainProductOperation.

            // hide unneccessary operations with 


        }
    }

    #region ExampleOne

    public class ProductCart : Product1
    {
        public override void AddProductToCart()
        {
            throw new NotImplementedException();
        }

        public override void GetProductFromCart()
        {
            throw new NotImplementedException();
        }

        public override void RemoveProductFromCart()
        {
            throw new NotImplementedException();
        }
    }

    abstract public class Product1
    {

        public Product1()
        {
            Console.WriteLine("Test");
        }

        abstract public void AddProductToCart();
        public void AddProductToCart(int x) { }
        abstract public void RemoveProductFromCart();
        abstract public void GetProductFromCart();

        public void AddProduct()
        {

        }


    }


    //abstract public class Human
    //{
    //    abstract public void Talk();


    //}


    public interface IHuman
    {
        void Talk();
        void Run();
        void Eat();
        void Sleep();
    }




    public class Employee : IHuman
    {
        public void Eat()
        {
            Console.WriteLine("Employee eats Hamburger");
        }

        public void Run()
        {

        }
        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }

    public class Student : IHuman
    {
        public void Eat()
        {
            Console.WriteLine("Student eats Hamburger");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }

    public class Teacher : IHuman
    {
        public void Eat()
        {
            Console.WriteLine("Teacher eats Hamburger");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ExampleTwo
    public abstract class BaseProduct
    {
        

        public int Amount { get; set; }
    }

    interface IMainProductOperation
    {
        void Add();
        void Remove();
        void Update();
        void Get();
    }

    interface IProductCardOperation
    {
        void AddToCart();
        void RemoveToCart();
        void UpdateToCart();
        void GetToCart();
    }

    public class Product : BaseProduct, IMainProductOperation, IProductCardOperation
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void AddToCart()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetToCart()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void RemoveToCart()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void UpdateToCart()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    interface ITest1
    {
        void Foo();
    }

    interface ITest2
    {
        void Foo();
    }

    public class Test : ITest1, ITest2
    {
        void ITest1.Foo()
        {
            throw new NotImplementedException();
        }

        void ITest2.Foo()
        {
            throw new NotImplementedException();
        }
    }





}