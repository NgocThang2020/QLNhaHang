using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Interfaces
{
    public interface IStaffBUS
    {
        List<StaffDTO> GetAll();
        void Commit(List<StaffDTO> staffs, List<int> deletedIds);
    }
}
