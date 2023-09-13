using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.TestApp.A
{
    internal class Test
    {
        public static readonly string MyString = "Codelandia";
        public string MyProperty { get; set; }

        public Test()
        {
           
        }

        public void Test1()
        {
            Calculate(5, 83, 3);
        }



        /// <summary>
        ///  Bu metod 3 dene gelen deyerin toplanaraq geri qaytarilmasi
        ///  isini gorur
        /// </summary>
        /// <param name="x">First Parameter</param>
        /// <param name="y">Second Parameter</param>
        /// <param name="z">Third Parameter</param>
        /// <returns>
        /// Bu metod geriye int deyer qaytarir
        /// </returns>
        public int Calculate(int x,int y,int z)
        {
            return x + y + z;
        }
        
    }
}
