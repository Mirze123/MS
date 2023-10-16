using ClothesStoreManagementSystem.Helpers;
using ClothesStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Operations.Abstract
{
    public interface IBaseOperation<T> where T:BaseModel,new()
    {
        Result Add(T model);
        Result Delete(T model);
        Result Update(T model);
        T Get(int id);
        List<T> GetAll();
        int GetNextId();
    }
}
