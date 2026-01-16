using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DTO
{
    public class InvoiceDTO
    {
        public int InvoiceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalMoney { get; set; }
        public bool Status { get; set; }

        public int TableId { get; set; }
        public int StaffId { get; set; }
        public int ShiftId { get; set; }
    }
}
