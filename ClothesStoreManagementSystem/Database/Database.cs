using ClothesStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem
{
    public static class Database
    {
        public static List<User> Users { get; set; }
        public static List<Employee> Employees { get; set; }
        public static List<Product> Products { get; set; }

        static Database()
        {
            Users = new List<User>()
            {
                new User(){ID = 1,Username = "Admin", Password= "123456"},
                new User(){ID = 2,Username = "Admin1", Password= "123456"},
                new User(){ID = 3,Username = "Admin2", Password= "123456"},
            };
        }

    }
}
