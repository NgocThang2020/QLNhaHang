using NhaHangBUL.Interfaces;
using NhaHangBUL.Security;
using NhaHangDAL.DAO.Implements;
using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Implements
{
    public class AccountBUS : IAccountBUS
    {
        private readonly IAccountDAO _accountDAO;

        public AccountBUS(IAccountDAO accountDao)
        {
            _accountDAO = accountDao;
        }

        public AccountDTO Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username không được để trống");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password không được để trống");

            var account = _accountDAO.Login(username, password);

            if (account == null)
                throw new Exception("Sai tài khoản hoặc mật khẩu");

            AppSession.SetUser(account);

            return account;
        }

        public void Logout()
        {
            AppSession.Clear();
        }

        public bool IsLoggedIn()
        {
            return AppSession.IsAuthenticated;
        }
    }
}
