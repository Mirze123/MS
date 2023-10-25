using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public  class Example
    {

        public static List<Student> Students { get; set; }

        public Action<int> myDelegate = (int a) => { Console.WriteLine("a"); };

        public Func<int,int> myFunc = (int a) => { return 5; };

        public Predicate<int> myPredicate => (int a) => 5 == 5;

        public Example()
        {
            Students = new List<Student>();
        }

        public static List<Student> students = new List<Student>();
        public delegate bool ModelValidationDelegate(Student model);

        public static void Add(Student student)
        {
            ModelValidationDelegate ValidationDelegate = IsStringEmpty;
             ValidationDelegate += IsAgeGreaterThanZero;
             ValidationDelegate += IsNameGreaterThanThreeSymbol;


            bool result = HandleValidations(student,ValidationDelegate);

            if (!result)
            {
                return;
            }

            students.Add(student);
        }


        public static bool IsStringEmpty(Student model)
        {
            return string.IsNullOrEmpty(model.FirstName);
        }

        public static bool IsAgeGreaterThanZero(Student model)
        {
            return model.Age  > 0;
        }

        public static bool IsNameGreaterThanThreeSymbol(Student model)
        {
            return model.FirstName.Length > 2;
        }

        public static bool HandleValidations(Student student, ModelValidationDelegate deleg)
        {
            return deleg(student);
        }


    }


    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public sbyte Age { get; set; }

    }

    public class MyClass
    {

        public delegate void MyDelegate();

    }


    public class MyClass1
    {
        public void Test()
        {
            MyClass test = new MyClass();

            MyClass.MyDelegate myDeleg = () => { Console.WriteLine("A"); };
           
        }

        

    }
}
