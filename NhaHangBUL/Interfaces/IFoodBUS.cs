using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Interfaces
{
    public interface IFoodBUS
    {
        List<FoodDTO> GetAll();
        FoodDTO? GetById(int id);
        void Add(FoodDTO dto);
        void Update(FoodDTO dto);
        void Delete(int id);
        void Commit(List<FoodDTO> foods, List<int> deletedIds);
    }
}
