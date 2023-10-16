using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Operations
{
    public class StringConcatOperation
    {
        StringBuilder builder = new StringBuilder();

        public string ConcatMultipleStrings(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                ArgumentNullException.ThrowIfNull(strings[i]);
                builder.Append(strings[i]);
            }

            return builder.ToString();
        }
    }
}
