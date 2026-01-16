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
    public class WorkShiftDAO : IWorkShiftDAO
    {
        private readonly NhaHangDBContext _db;

        public WorkShiftDAO(NhaHangDBContext db)
        {
            _db = db;
        }

        public List<WorkShiftDTO> GetAll()
        {
            return _db.WorkShifts
                .Select(w => new WorkShiftDTO
                {
                    WorkShiftId = w.ShiftId,
                    StartTime = w.StartTime,
                    EndTime = w.EndTime,
                    StaffId = w.StaffId,
                    StaffName = w.Staff.FullName
                }).ToList();
        }

        public void Add(WorkShiftDTO dto)
        {
            _db.WorkShifts.Add(new WorkShift
            {
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
                StaffId = dto.StaffId
            });
        }

        public void Update(WorkShiftDTO dto)
        {
            var shift = _db.WorkShifts.Find(dto.WorkShiftId)
                ?? throw new Exception("Ca làm không tồn tại");

            shift.StartTime = dto.StartTime;
            shift.EndTime = dto.EndTime;
            shift.StaffId = dto.StaffId;
        }

        public void Delete(int id)
        {
            var shift = _db.WorkShifts.Find(id)
                ?? throw new Exception("Ca làm không tồn tại");

            _db.WorkShifts.Remove(shift);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
