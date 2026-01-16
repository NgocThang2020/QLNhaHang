using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaHangDAL.DAO;
using Microsoft.EntityFrameworkCore;

namespace QLNhaHang
{
    public static class DBContextFactory
    {
        public static NhaHangDBContext Create()
        {
            var cs = ConfigurationManager
                .ConnectionStrings["NhaHangDBContext"]?
                .ConnectionString;

            if (string.IsNullOrWhiteSpace(cs))
                throw new Exception("Không tìm thấy connection string 'NhaHangDBContext' trong App.config.");

            var options = new DbContextOptionsBuilder<NhaHangDBContext>()
                .UseMySQL(cs)
                .Options;

            return new NhaHangDBContext(options);
        }
    }
}

