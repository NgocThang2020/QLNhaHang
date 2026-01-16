using NhaHangBUL.Interfaces;
using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Implements
{
    public class WorkShiftBUS : IWorkShiftBUS
    {
        private readonly IWorkShiftDAO _dao;

        public WorkShiftBUS(IWorkShiftDAO dao)
        {
            _dao = dao;
        }

        public List<WorkShiftDTO> GetAll()
        {
            return _dao.GetAll();
        }

        public void Commit(List<WorkShiftDTO> shifts, List<int> deletedIds)
        {
            foreach (var id in deletedIds)
            {
                _dao.Delete(id);
            }

            foreach (var s in shifts)
            {
                if (s.WorkShiftId == 0)
                    _dao.Add(s);
                else
                    _dao.Update(s);
            }
            _dao.SaveChanges();
        }
    }
}
