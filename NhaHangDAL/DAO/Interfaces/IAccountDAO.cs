using NhaHangDAL.DTO;
using NhaHangDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface IAccountDAO
    {
        AccountDTO? Login(string username, string password);
    }
}
