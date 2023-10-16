using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Models
{
    public class Product:BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
    }
}
