using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int DiscountID { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }
    }
}
