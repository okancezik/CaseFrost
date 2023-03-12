using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.DTOs
{
    public class ProductDetailsDTO
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string DiscountName { get; set; }
        public bool DiscountState { get; set; }
        public DateTime DiscountStartDate { get; set; }
        public DateTime DiscountEndDate { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }
    }
}
