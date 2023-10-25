using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Model
    {
        public int Value { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }

        public static explicit operator Model2(Model model)
        {
            return new Model2()
            {
                Value = model.Value,
                Name = model.Name
            };
        }
    }

    public class Model2
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
