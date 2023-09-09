using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Kata
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="integers"></param>
        /// <returns></returns>
        public static int Find(int[] integers)
        {
            var oddNumbers = integers.Where(x => x % 2 != 0).ToArray();
            var evenNumbers = integers.Where(x => x % 2 == 0).ToArray();

            if (oddNumbers.Count() > 1)
            {
                return evenNumbers[0];
            }
            else
            {
                return oddNumbers[0];
            }
        }

    }
}
