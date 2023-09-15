using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndClassMembers
{
    public class Lesson
    {
        int a; // ==> field

        public int MyProperty { get; set; } // ==> property
        public int MyProperty1 { get; set; } // ==> property

        public void Talk()
        {
            // ==> method
        }

        public int this[int a]
        {
            get
            {
                // => indexer
                return a;
            }
            set
            {
                a = value;
            }
        }

        public Lesson()
        {
            // constructor
            Console.WriteLine("Constructor worked");
        }

        public Lesson(int a):this()
        {
            MyProperty = a;
        }
            
        public Lesson(int x,int b):this(x)
        {
            MyProperty1 = b;
        }


        public void Deconstruct(out int a,out int b)
        {
            a = MyProperty;
            b = MyProperty1;
        }



        ~Lesson()
        {
            // destructor

            Console.WriteLine("Destructor worked");
        }


    }
}
