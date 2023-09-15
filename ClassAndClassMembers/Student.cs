using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndClassMembers
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public static string MyName { get; set; } = "Mirza";


        private Student()
        {
            Console.WriteLine("Constructor worked");
        }

        static Student()
        {
            Console.WriteLine("Static constructor worked");
        }

        private Student(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Deconstruct(out int age,out string name)
        {
            age = Age;
            name = Name;
        }

        private void Test()
        {

        }
    }
}
