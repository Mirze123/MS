using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Example
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public short Year { get; set; }

        public static ExampleForUser operator +(Example left, ExampleTwo right)
        {
            return new ExampleForUser()
            {
                Name = left.Name,
                Value = left.Value + right.Value,
            };
        }
    }

    public class ExampleTwo
    {
        public int Value { get; set; }

    }

    public class ExampleForUser
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
