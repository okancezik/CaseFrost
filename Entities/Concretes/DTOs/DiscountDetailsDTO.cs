using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.DTOs
{
    public class DiscountDetailsDTO
    {
        public string DiscountName { get; set; }
        public string DiscountCategoryName { get; set; }
        public bool DiscountState { get; set; }
        public DateTime DiscountStartDate { get; set; }
        public DateTime DiscountEndDate { get; set; }
    }
}
