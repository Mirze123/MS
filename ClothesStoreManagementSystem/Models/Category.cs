using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Models
{
    public class Category:BaseModel
    {
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
