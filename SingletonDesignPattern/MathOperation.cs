using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class MathOperation
    {
        private static MathOperation _instance;
        public static MathOperation Instance => _instance;

        static MathOperation()
        {
            _instance = new MathOperation();
        }


        private MathOperation() { }

        public int Calculate(int a,int b)
        {
            return a * b;
        }
    }
}
