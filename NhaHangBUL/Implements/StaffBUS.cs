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
    public class StaffBUS : IStaffBUS
    {
        private readonly IStaffDAO _staffDAO;

        public StaffBUS(IStaffDAO staffDAO)
        {
            _staffDAO = staffDAO;
        }

        public List<StaffDTO> GetAll()
        {
            return _staffDAO.GetAll();
        }

        public void Commit(List<StaffDTO> staffs, List<int> deletedIds)
        {
            foreach (var id in deletedIds)
            {
                _staffDAO.Delete(id);
            }

            foreach (var s in staffs)
            {
                if (s.StaffId == 0)
                    _staffDAO.Add(s);
                else
                    _staffDAO.Update(s);
            }

            _staffDAO.SaveChanges();
        }
    }
}
