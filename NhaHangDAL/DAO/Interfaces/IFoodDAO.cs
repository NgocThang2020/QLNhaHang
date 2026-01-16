using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface IFoodDAO
    {
        List<FoodDTO> GetAll();
        FoodDTO? GetById(int id);
        void Add(FoodDTO food);
        void Update(FoodDTO food);
        void Delete(int id);
        void SaveChanges();
    }
}
