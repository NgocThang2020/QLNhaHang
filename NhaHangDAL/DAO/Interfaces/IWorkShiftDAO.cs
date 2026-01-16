using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface IWorkShiftDAO
    {
        List<WorkShiftDTO> GetAll();
        void Add(WorkShiftDTO shift);
        void Update(WorkShiftDTO shift);
        void Delete(int id);
        void SaveChanges();
    }
}
