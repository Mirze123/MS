using MS.TestApp.B;
using System.Runtime.CompilerServices;

namespace MS.TestApp
{
    internal class Program
    {

        //readonly int y;

        //public Program()
        //{
        //    y = 10;
        //}


        static void Main(string[] args)
        {

            /// const və readonly 
            /// const keywordu static bir inşadır
            /// const keywordu ile yaradilan variablelar yaradildiqlari andan etibaren deyer elde etmelidirler
            /// 

            //const int x = 5;

            ////x = 10;


            //// deep copy
            //// shallow copy

            //int z = 6;
            //int a = z;


            ////
            //Test test = new Test();
            //Test test1 = test;

            //object ==> boxing ve unboxing

            //object obj = 25;
            //int a = obj * 5;

            // c#-da object keywordu ile qeyd olunan yeni object keywordune burunen her bir variable boxing davranisi gosterir

            //object obj = 5; /// ==>boxing emeliyyati

            //int x = (int)obj; /// ==> unboxing

            // var keywordu ve dynamic keywordu

            //var x = 25;
            //var y = true;


            //dynamic x = 15;
            //Console.WriteLine(x.GetType());

            // type convertions

            // parse metodlari
            // convert classindan


            //string a = "Salam";

            //int x = int.Parse(a);

            //short x = 25;

            //int y = Convert.ToInt32(x);

            // implicit ve explicit type conversion







            //int x = 2500;
            //long a = x; // ==> implicit type conversion

            //byte z = (byte)x; /// explicit type conversion



            //int x = 10;
            //int y = 20;

            //int z = x + y;


            //decimal y = 10;
            //int x = 20;

            //var z = x + y;

            //byte x = 10;
            //byte y = 20;

            //byte z = (byte)(x + y);

            //int x = int.MaxValue;
            //int y = 20;

            //int z = x + y;

            //Console.WriteLine(z);


            // &&
            // ||
            // ^


            //x= false   y= true
            //
            // 

            //bool result = (true && (false || true || false) && ((false || true) && (false ^ false)));

            //int x = 5;

            //Console.WriteLine(x++); // outputda ==>5 stackda ==>6
            //Console.WriteLine(++x); // stackda ==>7  outputda ==> 7
            //bool x = false;
            //int y = 20;


            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(sizeof(long));

            //object x = 25;
            //int? a = null;

            //string myString = default;

            //Console.WriteLine(a is not null);

            //string str = null;

            //string message = str ??= "This is null";




            //string message = y == 20 ? "Not Found" : (x ? "Test" : "Test1");

            //if (y == 20)
            //    return;
            //return x ? "Test" : "Test1";

            // = assign operator
            // . operator member access 

            //int dayOfWeek = 50;
            ////string weekDayWithText = string.Empty;
            //int z = 5;
            //string weekDayWithText = dayOfWeek switch
            //{
            //    var x when x > 10 && x < 20 => "Monday",
            //    2 => "Tuesday",
            //    3 => "Wednesday",
            //    4 => "Thursday",
            //    5 => "Friday",
            //    6 => "Saturday",
            //    7 => "Sunday",
            //    _ => "This is default"
            //};



            //if(5 ==5)
            //    Console.WriteLine("Test");

            //for(int i = 0; i < 10; i++)
            //    Console.WriteLine(i);


            //switch (dayOfWeek)
            //{
            //    case 1:
            //        weekDayWithText = "Monday";
            //        break;
            //    case 2:
            //        weekDayWithText = "Tuesday";
            //        break;
            //    case 3:
            //        weekDayWithText = "Wednesday";
            //        break;
            //    default:
            //        weekDayWithText = "Undefined";
            //        break;

            //}

            //int type = 1;
            //string result = string.Empty;

            //switch (type)
            //{
            //    case 1:
            //        result = "Codelandia";
            //        break;
            //    case 2:
            //        result = "Technest";
            //        break;
            //    case 3:
            //    case 4:
            //        goto case 1;

            //    default:
            //        break;
            //}


            object obj = 12;
            int x = 55;
            //if(obj is string str)
            //{
            //    Console.WriteLine(str);
            //}

            // type pattern ==> c# 7.0

            //if(obj is "Codelandia")
            //{
            //    Console.WriteLine("true");
            //}


            //if (x is 55)
            //{
            //    Console.WriteLine("True1");
            //}

            if(obj is var str)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(str.GetType());


            /*
             operatorlar
             operatorlar kritik
             comparison operators
             logic operators
             postfix increment prefix increment
             ! Not operator
             ternary operator
             assign
             member access
             cast
             sizeof,typeof,default,is,isnull,is not null,as,?,??,??=
             switch
             go to
             when
             switch expression
             switch expression when
             if,else,else if
             type pattern
             constant pattern
             var pattern
             relation pattern 9.0 c#
             logical,not pattern
             */




















        }
    }
}