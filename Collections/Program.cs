namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() 
            { 
                "Baki","Gence","Sumqayit","Qazax","Quba","Qusar",
                "Agdash","Xachmaz",
                "Tovuz"
            
            };

            //string[] countries = new string[3]
            //{
            //    "Azerbaycan","Turkiye","Rusiya"
            //};

            //for (int i = 0; i < countries.Length; i++)
            //{
            //    countries[i] = countries[i].ToLower();
            //}

            //foreach (var item in countries)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = countries.Select(x => x.ToLower()).ToArray();
            //foreach (var country in countries) { Console.WriteLine(country); }
            //foreach (var item in result) { Console.WriteLine(item); }

            //first
            //firstordefault
            //single
            //singleordefault
            //last
            //lastordefault
            //orderby
            //orderbydescending
            //where
            //select
            //any
            // skip
            // take

            //string result = cities.FirstOrDefault(x => x.StartsWith("Ag"));
            //Console.WriteLine(result is null);

            //string result = cities.SingleOrDefault(x => x.StartsWith("Qu"));
            //Console.WriteLine(result is null);

            //string result = cities.LastOrDefault(x => x.StartsWith("Qu"));
            //Console.WriteLine(result);  

            //var result = cities.Where(x => x.StartsWith("Qu")).ToList();
            //result.ForEach(x => Console.WriteLine(x));

            //var result = cities.Select(x => x.ToLower()).ToList();
            //result.ForEach(x => Console.WriteLine(x));
            //cities.ForEach(x =>x.ToUpper());
            //cities.ForEach(x=>Console.WriteLine(x));

            //var result = cities.Select(x => new City()
            //{
            //    Name = x
            //}).ToList();

            //var result = cities.Any();

            //if (cities.Any())
            //{
            //    //do something
            //}

            //var result = cities.OrderBy(x => x).ToList();
            //result.ForEach(x=>Console.WriteLine(x));

            //var result = cities.OrderByDescending(x => x).ToList();
            //result.ForEach(x => Console.WriteLine(x));


            //string str = "123";



            //if (int.TryParse(str,out int x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine(x);
            //}

            //Random random = new Random();

            // int randomValue = random.Next();
            //Console.WriteLine(randomValue);

            //int randomValue1 = random.Next(1000);
            //Console.WriteLine(randomValue1);

            //int randomValue2 = random.Next(100,200);
            //Console.WriteLine(randomValue2);

            //double randomValue3 = random.NextDouble();
            //Console.WriteLine(randomValue3);


            //DateTime dateTime = new DateTime();
            //Console.WriteLine(dateTime);

            //var x = DateTime.Now;
            //var y = DateTime.Now.

            //var x = DateTime.UtcNow;
            //Console.WriteLine(x);
            //var y = DateTime.Now;
            //Console.WriteLine(y);


            //Console.WriteLine(intList.Capacity);

           var result =  cities.Skip(3).Take(3).ToList();




        }

        
    }

    class City
    {
        //shorthand property
        //backingfields

      

        public string Name { get; set; }

        public bool CustomTryParse(string str,out int x)
        {
            try
            {
                x = int.Parse(str);
                return true;
            }
            catch
            {
                x = default;
                return false;
                
            }
        }

        public List<int> Paginate(int pageNumber,int pageSize,List<int> list)
        {
            return list.Skip((pageNumber-1) * pageSize).Take(pageSize).ToList();
        }
    }
}