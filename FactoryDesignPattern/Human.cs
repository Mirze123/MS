using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryDesignPattern.Program;

namespace FactoryDesignPattern
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        abstract public void Talk();
    }

    public class HumanFactory
    {

        public static Human CreateInstance(HumanTypes humanType)
        {
            switch (humanType)
            {
                case HumanTypes.Teacher:
                    return new Teacher();
                case HumanTypes.Student:
                    return new Student();
                case HumanTypes.Employee:
                    return new Employee();
                default:
                    return null;
            }
        }
    }
}
