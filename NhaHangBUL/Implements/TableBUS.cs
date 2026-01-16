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
    public class TableBUS : ITableBUS
    {
        private readonly ITableDAO _tableDAO;

        public TableBUS(ITableDAO tableDAO)
        {
            _tableDAO = tableDAO;
        }

        public List<TableDTO> GetAll()
        {
            return _tableDAO.GetAll();
        }

        public void Commit(List<TableDTO> tables, List<int> deletedIds)
        {
            foreach (var id in deletedIds)
                _tableDAO.Delete(id);

            foreach (var t in tables)
            {
                if (string.IsNullOrWhiteSpace(t.TableName))
                    throw new Exception("Tên bàn không được trống");

                if (t.Seats <= 0)
                    throw new Exception("Số chỗ ngồi phải > 0");

                if (t.TableId == 0)
                    _tableDAO.Add(t);
                else
                    _tableDAO.Update(t);
            }

            _tableDAO.SaveChanges();
        }
    }
}
