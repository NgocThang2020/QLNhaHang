using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Security
{
    public static class AppSession
    {
        public static AccountDTO? CurrentUser { get; private set; }

        public static bool IsAuthenticated
            => CurrentUser != null;

        public static void SetUser(AccountDTO account)
        {
            CurrentUser = account;
        }

        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}
