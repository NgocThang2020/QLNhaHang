using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaHangDAL.Entities;

namespace NhaHangDAL.DAO.Implements
{
    public class TableDAO : ITableDAO
    {
        private readonly NhaHangDBContext _db;

        public TableDAO(NhaHangDBContext db)
        {
            _db = db;
        }

        public List<TableDTO> GetAll()
        {
            return _db.Tables
                .Select(t => new TableDTO
                {
                    TableId = t.TableId,
                    TableName = t.TableName,
                    Seats = t.Seats,
                    Status = t.Status
                }).ToList();
        }

        public void Add(TableDTO dto)
        {
            _db.Tables.Add(new Table
            {
                TableName = dto.TableName,
                Seats = dto.Seats,
                Status = dto.Status
            });
        }

        public void Update(TableDTO dto)
        {
            var table = _db.Tables.Find(dto.TableId)
                ?? throw new Exception("Bàn không tồn tại");

            table.TableName = dto.TableName;
            table.Seats = dto.Seats;
            table.Status = dto.Status;
        }

        public void Delete(int id)
        {
            var table = _db.Tables.Find(id)
                ?? throw new Exception("Bàn không tồn tại");

            _db.Tables.Remove(table);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
