using ExceptionHandling.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Operations
{
    public class MathOperation
    {
        private int _number1;
        private int _number2;
        public int Result { get;private set; }

        public MathOperation(int a,int b)
        {
            _number1 = a;
            _number2 = b;
        }

        public void ExecuteMutliplyOperation()
        {
            if(_number2 == 0)
            {
                // burda sonlanmalaidi
                // ve geriye xeta qaytarmalidi ki biz onu cagirdigimiz yerde try catch yaxalaya bilek
                throw new SecondNumberNotNullException("Second number cannot be null");
            }

            Result = _number1 * _number2;
            
        }
    }
}
