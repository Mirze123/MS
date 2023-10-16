using ExceptionHandling.Exceptions;
using ExceptionHandling.Operations;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int num = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //MathOperation mathOperation = new MathOperation(num,num2);

            //try
            //{
            //    mathOperation.ExecuteMutliplyOperation();
            //    Console.WriteLine($"Your result is:{mathOperation.Result}");
            //}
            //catch (SecondNumberNotNullException ex)
            //{

            //    Console.WriteLine(ex.InnerException);
            //}

            StringConcatOperation stringConcatOperation = new StringConcatOperation();

            try
            {
                string result = stringConcatOperation.ConcatMultipleStrings("salam", "sagol", "codelandia", "", "test", "test1");
                Console.WriteLine($"Your result is:{result}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);

            }
            


            Console.ReadLine();
        }
    }
}