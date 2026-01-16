using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface ICategoryDAO
    {
        List<CategoryDTO> GetAll();
        CategoryDTO? GetById(int id);
        void Add(CategoryDTO category);
        void Update(CategoryDTO category);
        void Delete(int id);
    }
}
