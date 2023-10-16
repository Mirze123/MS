namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = MathOperation.Instance.Calculate(5, 6);
        }
    }
}