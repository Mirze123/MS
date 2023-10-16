using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Example1
    {
        #region MyRegion
        public abstract class BaseClass
        {
            public abstract string Name { get; set; }
        }

        public interface IBase
        {
            string Name { get; set; }
        }

        public class Derived : BaseClass
        {
            public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        public class Derived1 : IBase
        {
            public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        #endregion

        public class A
        {
            public A()
            {
                Console.WriteLine("a");
            }
        }

        public class B:A
        {
            public B()
            {
                Console.WriteLine("b");
            }
        }

        public class C:B
        {
            public C()
            {
                Console.WriteLine("c");
            }
        }

        public void Test()
        {
            C c = new C();
        }



    }
}
