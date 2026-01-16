using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface IStaffDAO
    {
        List<StaffDTO> GetAll();

        void Add(StaffDTO dto);
        void Update(StaffDTO dto);
        void Delete(int id);

        void SaveChanges();
    }
}
