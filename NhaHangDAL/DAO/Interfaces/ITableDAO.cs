using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface ITableDAO
    {
        List<TableDTO> GetAll();
        void Add(TableDTO dto);
        void Update(TableDTO dto);
        void Delete(int id);
        void SaveChanges();
    }
}
