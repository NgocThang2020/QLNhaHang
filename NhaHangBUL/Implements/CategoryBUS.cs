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
    public class CategoryBUS : ICategoryBUS
    {
        private readonly ICategoryDAO _categoryDAO;

        public CategoryBUS(ICategoryDAO categoryDAO)
        {
            _categoryDAO = categoryDAO;
        }

        public List<CategoryDTO> GetAll()
        {
            return _categoryDAO.GetAll();
        }

        public CategoryDTO? GetById(int id)
        {
            if (id <= 0)
                throw new Exception("Id không hợp lệ");

            return _categoryDAO.GetById(id);
        }

        public void Add(CategoryDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.CategoryName))
                throw new Exception("Tên loại món không được để trống");

            _categoryDAO.Add(dto);
        }

        public void Update(CategoryDTO dto)
        {
            if (dto.CategoryId <= 0)
                throw new Exception("Id không hợp lệ");

            if (string.IsNullOrWhiteSpace(dto.CategoryName))
                throw new Exception("Tên loại món không được để trống");

            _categoryDAO.Update(dto);
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new Exception("Id không hợp lệ");

            _categoryDAO.Delete(id);
        }
    }
}
