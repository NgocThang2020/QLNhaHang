using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using NhaHangDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Implements
{
    public class StaffDAO : IStaffDAO
    {
        private readonly NhaHangDBContext _db;

        public StaffDAO(NhaHangDBContext db)
        {
            _db = db;
        }

        public List<StaffDTO> GetAll()
        {
            return _db.Staffs
                .Select(s => new StaffDTO
                {
                    StaffId = s.StaffId,
                    FullName = s.FullName,
                    Role = s.Role,
                    Phone = s.Phone,
                    Email = s.Email
                })
                .OrderBy(s => s.StaffId)
                .ToList();
        }

        public void Add(StaffDTO dto)
        {
            _db.Staffs.Add(new Staff
            {
                FullName = dto.FullName,
                Role = dto.Role,
                Phone = dto.Phone,
                Email = dto.Email
            });
        }

        public void Update(StaffDTO dto)
        {
            var staff = _db.Staffs.Find(dto.StaffId)
                ?? throw new Exception("Nhân viên không tồn tại");

            staff.FullName = dto.FullName;
            staff.Role = dto.Role;
            staff.Phone = dto.Phone;
            staff.Email = dto.Email;
        }

        public void Delete(int id)
        {
            var staff = _db.Staffs.Find(id)
                ?? throw new Exception("Nhân viên không tồn tại");

            _db.Staffs.Remove(staff);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
