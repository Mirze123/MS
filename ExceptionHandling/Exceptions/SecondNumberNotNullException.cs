using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Exceptions
{
    public class SecondNumberNotNullException:Exception
    {
        public string InnerException { get;}


        public SecondNumberNotNullException(string message):base(message)
        {
            InnerException = "Your stack Trace exception is" 
                + Environment.NewLine + message 
                + Environment.NewLine + "Exception Current Datetime is"
                + Environment.NewLine + DateTime.Now;

            // logggin
            // other operations
        }
    }
}
