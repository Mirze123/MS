namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            KIA car1 = new();
            KIA car2 = new();
            KIA car3 = new();
            KIA car4 = new();


            //CarSellOperation<Hyundai> carSellOperation = new CarSellOperation<Hyundai>();
            //carSellOperation.Add(car1);
            //carSellOperation.AddMultipleCars(car2, car3, car4);
            //byte x = 10;
            //CalculateOperation<Hyundai> calculateOperation = new CalculateOperation<int>();
            //calculateOperation.Calculate(5, 10, x, 30);

            //List<int> myList = new();
           

        }
    }

    #region Example1
    public class CarSellOperation<T> where T:class, ICar,new()// reference type constraint
    {
        private T[] _cars = new T[100];
        private int _count = -1;
        public void Add(T car)
        {
            _cars[++_count] = car;
        }

        public void AddMultipleCars(params T[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                _cars[++_count] = cars[i];
            }
        }


    }

   public interface ICar
    {
     
        //abstract public void Drive();
    }


    public class Hyundai : ICar
    {
        //public override void Drive()
        //{
        //    Console.WriteLine("I drive Hyundai");
        //}

        public Hyundai(int a, int b)
        {

        }

        //public Hyundai()
        //{

        //}
    }

    public class Mercedes : ICar
    {
        //public override void Drive()
        //{
        //    Console.WriteLine("I drive Mercedes");
        //}
    }

    public class BMW : ICar
    {
        //public override void Drive()
        //{
        //    Console.WriteLine("I drive BMW");
        //}
    }

    public class KIA : ICar
    {
        //public override void Drive()
        //{
        //    Console.WriteLine("I drive KIA");
        //}
    }

    
    #endregion

    #region Example2


    public class MyClass<T>
    {

    }

    public class MyClass1<T> : MyClass<T>
    {

    }

    public interface IMyInterface<T> { }



    #endregion

    #region Example3 Generic Methods


    public class CalculateOperation<T1,T2,T3> 
        where T1:struct 
        where T2:class 
        where T3:Hyundai
    {
        public void  Calculate<T>(T a, T b, T c, T d)
        {
            Console.WriteLine(typeof(T).FullName);
        }


    }

    #endregion


}