using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public enum XMLStates
    {
        Initialize = 1,
        Open,
        Success,
        Close
    }

    public enum PORTS
    {
        SQLPORT = 3369,
        MYSQLPORT = 3757,
        REDISPORT = 5678
    }
    public class Example
    {
        //enumeration 

        [Flags]
        public enum Roles
        {
            [Description("This is admin")]
            Admin = 1,
            [Description("this is user")]
            User = 2,
            [Description("this is moderator")]
            Moderator = 4,



        }

        public void Test()
        {
            Console.WriteLine(Roles.User | Roles.Moderator | Roles.Admin);

            var descriptions = Roles.User
                .GetType()
                .GetField(Roles.User.ToString())
                .GetCustomAttribute<DescriptionAttribute>()
                .Description;
            Console.WriteLine(descriptions);

            MyClass1 myClass = new MyClass1(5);
            myClass.
        }



        #region ExampleOne
        //public void Test1()
        //{
        //    Test(XMLStates.Success);
        //    int openState = (int)XMLStates.Open;
        //    int sqlPOrt = (int)PORTS.SQLPORT;

        //    string redisPort = PORTS.REDISPORT.ToString();
        //    int sqlPortValue = 3369;
        //    PORTS sqlPort = (PORTS)sqlPortValue;
        //}

        //public void Test(int state)
        //{
        //    XMLStates currentState = (XMLStates)state;

        //    if (currentState == XMLStates.Open)
        //    {
        //        // do open operation
        //    }
        //    else if (currentState == XMLStates.Initialize)
        //    {
        //        // do initialize
        //    }
        //    else if (currentState == XMLStates.Success)
        //    {
        //        // do success
        //    }
        //    else if (currentState == XMLStates.Close)
        //    {
        //        // do close
        //    }
        //}
        #endregion

    }

    public class MyClass
    {

        public int Amount { get; set; }

    }

    public class MyClass1 : MyClass
    {

        public MyClass1(int x)
        {
            Amount = x;
        }

    }

    public sealed class Test
    {
        private static Test _instance;
        public static Test Instance => _instance;
        private Test() { }
        static Test()
        {
            _instance = new Test();
        }
    }

    
    

}
