using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DTO
{
    public class FoodDTO
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
    }
}
