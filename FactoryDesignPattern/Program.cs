namespace FactoryDesignPattern
{
    public class Program
    {
        public enum HumanTypes
        {
            Employee,
            Teacher,
            Student
        }
        static void Main(string[] args)
        {
            Human human = HumanFactory.CreateInstance(HumanTypes.Employee);
            human.Talk();

        }
    }
}