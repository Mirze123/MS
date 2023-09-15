using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndClassMembers.Examples
{
    internal class A
    {
        public void Main()
        {
            int x = 5;
            int y = 20;


            
            var result = Calc.Instance.Calculate(x, y);
        }
    }
}
