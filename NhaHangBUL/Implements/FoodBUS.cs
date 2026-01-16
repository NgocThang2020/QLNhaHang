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
    public class FoodBUS : IFoodBUS
    {
        private readonly IFoodDAO _foodDAO;
        private readonly ICategoryDAO _categoryDAO;
        public FoodBUS(IFoodDAO foodDAO, ICategoryDAO categoryDAO)
        {
            _foodDAO = foodDAO;
            _categoryDAO = categoryDAO;
        }
        public List<FoodDTO> GetAll()
        {
            return _foodDAO.GetAll();
        }
        public void Commit(List<FoodDTO> foods, List<int> deletedIds)
        {
            if (deletedIds != null && deletedIds.Any())
            {
                foreach (var id in deletedIds)
                {
                    _foodDAO.Delete(id);
                }
            }
            foreach (var food in foods)
            {
                if (food.FoodId == 0)
                {
                    _foodDAO.Add(food);
                }
                else
                {
                    _foodDAO.Update(food);
                }
            }
            _foodDAO.SaveChanges();
        }
        public List<CategoryDTO> LoadAll()
        {
            return _categoryDAO.GetAll();
        }
        public FoodDTO? GetById(int id)
        {
            if (id <= 0)
                throw new Exception("Id không hợp lệ");

            return _foodDAO.GetById(id);
        }

        public void Add(FoodDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.FoodName))
                throw new Exception("Tên món ăn không được để trống");

            if (dto.Price <= 0)
                throw new Exception("Giá món ăn phải lớn hơn 0");

            if (dto.CategoryId <= 0)
                throw new Exception("Chưa chọn loại món");

            _foodDAO.Add(dto);
        }

        public void Update(FoodDTO dto)
        {
            if (dto.FoodId <= 0)
                throw new Exception("Id không hợp lệ");

            if (string.IsNullOrWhiteSpace(dto.FoodName))
                throw new Exception("Tên món ăn không được để trống");

            if (dto.Price <= 0)
                throw new Exception("Giá món ăn phải lớn hơn 0");

            _foodDAO.Update(dto);
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new Exception("Id không hợp lệ");

            _foodDAO.Delete(id);
        }
    }
}
