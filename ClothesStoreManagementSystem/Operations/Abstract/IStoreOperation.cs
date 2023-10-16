using ClothesStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Operations.Abstract
{
    public interface IStoreOperation:IBaseOperation<Store>
    {
        void CheckStoreExistence();
    }
}
