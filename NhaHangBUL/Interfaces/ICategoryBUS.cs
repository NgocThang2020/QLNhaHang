using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Interfaces
{
    public interface ICategoryBUS
    {
        List<CategoryDTO> GetAll();
        CategoryDTO? GetById(int id);
        void Add(CategoryDTO dto);
        void Update(CategoryDTO dto);
        void Delete(int id);
    }
}
