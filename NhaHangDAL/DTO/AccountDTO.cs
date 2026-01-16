using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DTO
{
    public class AccountDTO
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public int StaffId { get; set; }
        public string StaffName { get; set; }
    }
}
