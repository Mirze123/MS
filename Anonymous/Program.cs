namespace Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var data = GetAllData();
            //List<DataForUser> ListOfDataForUsers = new List<DataForUser>();
            //DataForUser dataForUser;

            //foreach (var item in data)
            //{
            //    dataForUser = new DataForUser();
            //    dataForUser.MyProperty = item.MyProperty;
            //    dataForUser.MyProperty1 = item.MyProperty1;
            //    dataForUser.MyProperty2 = item.MyProperty2;
            //    ListOfDataForUsers.Add(dataForUser);
            //}


            //var myObject = new
            //{
            //    MyProperty = 1,
            //    MyInt = 2,
            //    MyString = "this is anonymous type",
            //    MyString1 = "str"
            //};

            //Test(myObject);



            //Console.WriteLine(myObject.GetType().Name);

            //Employee employee = new()
            //{
            //    Age = 1,
            //    FirstName = "Mirza",
            //    LastName = "Khalilov"
            //};

            //var employeeFOrMethod = new
            //{
            //    FullName = employee.FullName,
            //    Age = employee.Age,
            //};

            //WriteFullNameAndAgeToConsole(employeeFOrMethod);

            //List<Data> datas = new()
            //{
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //    new Data{MyProperty = 1,MyProperty1 = 2,MyProperty2 = 3},
            //};

            //var filteredData = datas.Select(x => new { x.MyProperty, x.MyProperty1}).ToList();

            //foreach (var item in filteredData)
            //{
            //    Console.WriteLine(item.MyProperty1);
            //}

            string str = "25jbh";
            if (int.TryParse(str, out int a))
            {
                Console.WriteLine(a);
                Func<>
            }
            else
            {
                Console.WriteLine("Cevrilmedi");
            }

            Console.ReadLine();
        }



        public static void WriteFullNameAndAgeToConsole(dynamic employee)
        {
            Console.WriteLine($"Fullname is:{employee.FullName} and Age is:{employee.Age}");
        }

        public static void Test(dynamic obj)
        {
            Console.WriteLine(obj.MyStringsdsd);
        }

        public static List<Data> GetAllData()
        {

            // for example return 500 rows
            return null;
        }
    }

    public class Data
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
        public int MyProperty5 { get; set; }


    }

    public class DataForUser
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }

        }

        public int Age { get; set; }

    }


}