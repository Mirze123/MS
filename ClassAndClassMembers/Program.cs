
class MyClass1
{

}

class MyClass
{

}
namespace ClassAndClassMembers
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //new Test().b = 25; // obyekt ve ya instance

            //Test test = new Test();
            ////  stack           heap

            //test.

            //Human human = new Human();
            //human.Age = 30;
            //Console.WriteLine(human.Age);

            Car car = new Car()
            {
                ProductionYear = 1,
                WheelCount = 4
            };

            Console.WriteLine(decimal.Parse(car.Color));

            //car.ProductionYear = 1;
            //car.WheelCount = 4;
            //car.Color = "Black";
        }
    }


    class Test
    {
        // class daxilinde data saxlayan mexanizmalara deyilir fieldlar
        private int a;
        private string str;
        private bool isRight;

        // property bir anlayisimiz
        // encapsulation
        // full prop
        // shorthand prop
        // auto property initializer C# 6.0
        // expression body yeni lambda expression property
        // ref readonly returns property
        // readonly property
        // init keywordy ==> init only propertyler == > C# 9.0
        // required keywordu ==> C# 11.0

        //private int age; // ==> camel casing

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}



    }
    class Human
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

    }

    class Pocket
    {
        private decimal money;

        public decimal Money
        {
            get
            {
                return money / 2;
            }
            set
            {
                money = value * 2;
            }
        }


        public decimal _get_Money()
        {
            return money;
        }

        public void _set_Money(decimal value)
        {
            money = value;
        }


        //public decimal GetMoney()
        //{
        //    return money;
        //}

        //public void SetMoney(decimal value)
        //{
        //    money = value;
        //}



    }

    class Car
    {
        //private int vehicle;
        //public string Color { get; set; } = "Green"; // auto property initializer C# 6.0

        //public int Vehicle { get => vehicle; set => vehicle = value; }

        //public ref readonly int Vehicle1 => ref vehicle;

        //public int WheelCount { get; set; }
        //public int ProductionYear { get; set; }
        //public required string Color { get; init; }

        //public bool IsBoolean { get; init; }2

        public int X { get; set; }
        public int Y { get; set; }

        private string str;

        public  int this[int a]
        {

        }

        public void Test(string str)
        {
            int x = 25;
            this.str = str;
        }

        public Car()
        {
            
        }

        public Car(int x):this()
        {
            X = x;
        }

        public Car(int x,int y)
        {

            Y = y;
        }

    }


}