using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DTO
{
    public class TableDTO
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int Seats { get; set; }
        public bool Status { get; set; } // true = còn trống
    }
}
