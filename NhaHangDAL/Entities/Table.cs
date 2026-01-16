using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.Entities
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        public string TableName { get; set; }
        public int Seats { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
