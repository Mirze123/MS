using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class MyClass
    {
        // method overloading --> static polimorfizm

        //public string SayHello()
        //{
        //    return "Say Hello";
        //}

        //public string SayHello(string message)
        //{
        //    // do operation

        //    return message;
        //}

        public int Sum(int x,int y)
        {
            return x+ y;
        }

        public int Sum(int x,int y ,int z)
        {
            return x+ y+ z;
        }

        public int Sum(int x, int y, int z,int a)
        {
            return x + y + z+a;
        }

        public decimal Sum(decimal x,decimal y)
        {
            return x*y;
        }

       

        public void Main()
        {
            //int x = 0;
            //int y = 0;
            //int z = 0;
            decimal x = 0;
            decimal y = 0;
            Sum(x, y);
        }

        




    }
}
