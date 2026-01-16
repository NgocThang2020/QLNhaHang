using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
    public class AccountDAO : IAccountDAO
    {
        private readonly NhaHangDBContext _context; 
        public AccountDAO(NhaHangDBContext context)
        {
            _context = context;
        }
        public AccountDTO? Login(string username, string password)
        {
            var account = _context.Accounts
                .Include(a => a.Staff)
                .FirstOrDefault(a => a.Username == username && a.Password == password);
            if (account == null)
            {
                return null; 
            }
            return new AccountDTO
            {
                Username = account.Username,
                Role = account.Role,
                StaffId = account.StaffId,
                StaffName = account.Staff?.FullName ?? string.Empty
            };
        }
    }
}
