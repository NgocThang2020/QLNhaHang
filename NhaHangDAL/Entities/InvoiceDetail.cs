using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.Entities
{
    public class InvoiceDetail
    {
        [Key, Column(Order = 0)]
        public int InvoiceId { get; set; }

        [Key, Column(Order = 1)]
        public int FoodId { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Food Food { get; set; }
    }
}
