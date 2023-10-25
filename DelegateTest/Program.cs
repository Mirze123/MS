namespace DelegateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> numbers = new List<int> { 2, 4, 7, 10, 13, 17, 20, 23 };

            var odds = numbers.WhereOdd(IsOdd);


        }

        public static bool IsOdd(int number)
        {
            return (number % 2 != 0);
        }
    }


    public static class LinqExtension
    {
        public delegate bool IsOddDelegate(int i);
        public static IEnumerable<int> WhereOdd(this IEnumerable<int> x, IsOddDelegate predicate)
        {
            foreach (var item in x)
            {
                if (!predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}