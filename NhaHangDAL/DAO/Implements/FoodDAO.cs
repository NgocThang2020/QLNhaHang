using Microsoft.EntityFrameworkCore;
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
    public class FoodDAO : IFoodDAO
    {
        private readonly NhaHangDBContext _db;
        public FoodDAO(NhaHangDBContext db)
        {
            _db = db;
        }

        public List<FoodDTO> GetAll()
        {
            return _db.Foods
                .Include(f => f.Category)
                .Select(f => new FoodDTO
                {
                    FoodId = f.FoodId,
                    FoodName = f.FoodName,
                    Price = f.Price,
                    Unit = f.Unit,
                    Status = f.Status,
                    Description = f.Description,
                    CategoryId = f.CategoryId,
                }).ToList();
        }

        public FoodDTO? GetById(int id)
        {
            return _db.Foods
                .Include(f => f.Category)
                .Where(f => f.FoodId == id)
                .Select(f => new FoodDTO
                {
                    FoodId = f.FoodId,
                    FoodName = f.FoodName,
                    Price = f.Price,
                    Unit = f.Unit,
                    Status = f.Status,
                    Description = f.Description,
                    CategoryId = f.CategoryId,
                }).FirstOrDefault();
        }

        public void Add(FoodDTO dto)
        {
            _db.Foods.Add(new Food
            {
                FoodName = dto.FoodName,
                Price = dto.Price,
                Unit = dto.Unit,
                Status = dto.Status,
                Description = dto.Description,
                CategoryId = dto.CategoryId
            });

            SaveChanges();
        }

        public void Update(FoodDTO dto)
        {
            var food = _db.Foods.Find(dto.FoodId)
                ?? throw new Exception("Món ăn không tồn tại");

            food.FoodName = dto.FoodName;
            food.Price = dto.Price;
            food.Unit = dto.Unit;
            food.Status = dto.Status;
            food.CategoryId = dto.CategoryId;

            SaveChanges();
        }

        public void Delete(int id)
        {
            var food = _db.Foods.Find(id)
                ?? throw new Exception("Món ăn không tồn tại");

            _db.Foods.Remove(food);
            SaveChanges();
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
