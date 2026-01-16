using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.Entities
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<WorkShift> WorkShifts { get; set; }
    }
}
