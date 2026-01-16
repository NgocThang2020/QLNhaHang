using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Interfaces
{
    public interface IWorkShiftBUS
    {
        List<WorkShiftDTO> GetAll();
        void Commit(List<WorkShiftDTO> shifts, List<int> deletedIds);
    }
}
