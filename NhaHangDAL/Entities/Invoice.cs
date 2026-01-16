using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        public DateTime CreatedDate { get; set; }
        public decimal TotalMoney { get; set; }
        public bool Status { get; set; }

        [ForeignKey("Table")]
        public int TableId { get; set; }
        public virtual Table Table { get; set; }

        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }

        [ForeignKey("WorkShift")]
        public int ShiftId { get; set; }
        public virtual WorkShift WorkShift { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
