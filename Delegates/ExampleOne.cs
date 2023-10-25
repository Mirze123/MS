using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ExampleOne
    {
        //public delegate bool ExtensionHandler(int a);
        public List<int> Test()
        {
            

            List<int> ints = new List<int>();

            
            ints.Add(5);
            ints.Add(6);
            ints.Add(4);
            ints.Add(3);
            ints.Add(2);
            ints.Add(7);
            ints.Add(5);
            ints.Add(8);

            return ints.WhereGreaterThanFive(IsGreaterThanFive).ToList();


        }

        public bool IsGreaterThanFive(int a)
        {
            return a > 5;
        }
    }


    public static class DefaultExtension
    {
       
        public static IEnumerable<int> WhereGreaterThanFive(this IEnumerable<int> ints,Predicate<int> handler)
        {
            foreach (var item in ints)
            {
                if (handler(item))
                {
                    yield return item;
                }
            }

            
        }
    }
}
