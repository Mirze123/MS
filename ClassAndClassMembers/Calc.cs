using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndClassMembers
{
    public class Calc
    {

        private static Calc _instance;
        public static Calc Instance => _instance;
       

        private Calc()
        {
            
        }

        static Calc()
        {
            _instance = new Calc();
        }

        public int Calculate(int x, int y)
        {
            return x + y;
        }
    }
}
