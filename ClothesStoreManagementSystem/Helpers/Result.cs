using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Helpers
{
    public class Result
    {
        public Result(string message,bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public string Message { get;  }
        public bool IsSuccess { get;  }
    }
}
