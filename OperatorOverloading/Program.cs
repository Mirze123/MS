namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z = x + y;

            //ClassOne class1 = new(5);
            //ClassTwo class2 = new(10);

            //var result = class1 + class2;

            //Team team = new()
            //{
            //    Name = "TeamOne"
            //};

            //Player player = new()
            //{
            //    Name = "Mirferid"
            //};
            //Player player1 = new()
            //{
            //    Name = "Hesen"
            //};
            //Player player2 = new()
            //{
            //    Name = "Bahar"
            //};

            //team = team + player;
            //team = team + player1;
            //team = team + player2;

            //foreach (var oyuncu in team.Players)
            //{
            //    Console.WriteLine(oyuncu.Name);
            //}

            //Example example = new()
            //{
            //    Value = 20,
            //    Name = "hello",
            //    Year = 2023
            //};
            //ExampleTwo exampleTwo = new()
            //{
            //    Value = 50
            //};

            ////ExampleForUser exampleForUser = new();
            ////exampleForUser.Name = example.Name;
            ////exampleForUser.Value = example.Value + exampleTwo.Value;
            //var exampleForUser = example + exampleTwo;

            //Console.WriteLine($"Name is:{exampleForUser.Name} and Value is:{exampleForUser.Value}");

            //FileOperation fileOperation = new();

            //if (fileOperation >> 5)
            //{

            //}

            //if (fileOperation << 3)
            //{

            //}

            Model model = new()
            {
                Name = "Test",
                Value = 20,
                Year = 2023
            };

            Model2 model2 = (Model2)model;

            

            Console.WriteLine(model2.Name);
            Console.WriteLine(model2.Value);

            Console.ReadLine();
        }
    }


    //public class ClassOne
    //{
    //    public int Value { get; set; }

    //    public ClassOne(int a)
    //    {
    //        Value = a;
    //    }

    //    //public static int  operator + (ClassOne classOne,ClassTwo classTwo)
    //    //{
    //    //    return classOne.Value + classTwo.Value;
    //    //}
    //}

    //public class ClassTwo
    //{
    //    public int Value { get; set; }

    //    public ClassTwo(int a)
    //    {
    //        Value = a;
    //    }
    //}

    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public Team()
        {
            Players = new();
        }

        public static Team operator+(Team team, Player player)
        {
            team.Players.Add(player);
            return team;
        }
    }

    public class Player
    {
        public string Name { get; set; }
    }
}