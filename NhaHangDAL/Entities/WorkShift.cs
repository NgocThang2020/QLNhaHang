using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.Entities
{
    public class WorkShift
    {
        [Key]
        public int ShiftId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
