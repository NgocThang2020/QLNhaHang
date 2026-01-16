using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangDAL.Entities
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        public string FoodName { get; set; }

        public decimal Price { get; set; }
        public string Unit { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
