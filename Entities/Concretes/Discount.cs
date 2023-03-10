using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Discount : IEntity
    {
        public int DiscountID { get; set; }
        public int CategoryID { get; set; }
        public string DiscountName { get; set; }
        public bool DiscountState { get; set; }
        public DateTime DiscountStartDate { get; set; }
        public DateTime DiscountEndDate { get; set; }
    }
}
