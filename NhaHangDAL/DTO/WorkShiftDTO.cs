using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DTO
{
    public class WorkShiftDTO
    {
        public int WorkShiftId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int StaffId { get; set; }
        public string StaffName { get; set; }
    }
}
