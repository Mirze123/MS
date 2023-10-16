using ClothesStoreManagementSystem.Helpers;
using ClothesStoreManagementSystem.Models;
using ClothesStoreManagementSystem.Operations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Operations.Concrete
{
    public class ProductManager : IProductOperation
    {
        public Result Add(Product model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Product model)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetNextId()
        {
            throw new NotImplementedException();
        }

        public Result Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
