using Microsoft.EntityFrameworkCore.Internal;
using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using NhaHangDAL.Entities;
using NhaHangDAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Implements
{
    public class CategoryDAO : ICategoryDAO
    {
        private readonly NhaHangDBContext _db;
        public CategoryDAO(NhaHangDBContext db) 
        {
            _db = db;
        }
        public List<CategoryDTO> GetAll()
        {
            return _db.Categories
                .Select(c => new CategoryDTO
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                }).ToList();
        }

        public CategoryDTO? GetById(int id)
        {
            return _db.Categories
                .Where(c => c.CategoryId == id)
                .Select(c => new CategoryDTO
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                }).FirstOrDefault();
        }

        public void Add(CategoryDTO dto)
        {
            _db.Categories.Add(new Category
            {
                CategoryName = dto.CategoryName,
                Description = dto.Description
            });

            _db.SaveChanges();
        }

        public void Update(CategoryDTO dto)
        {
            var category = _db.Categories.Find(dto.CategoryId)
                ?? throw new Exception("Category không tồn tại");

            category.CategoryName = dto.CategoryName;
            category.Description = dto.Description;

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _db.Categories.Find(id)
                ?? throw new Exception("Category không tồn tại");

            _db.Categories.Remove(category);
            _db.SaveChanges();
        }
    }
}
