using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO
{
    public class NhaHangDBContextFactory
        : IDesignTimeDbContextFactory<NhaHangDBContext>
    {
        public NhaHangDBContext CreateDbContext(string[] args)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;

            var configPath = Path.Combine(baseDir, "QLNhaHang.dll.config");
            if (!File.Exists(configPath))
                throw new Exception(
                    $"Không thấy QLNhaHang.dll.config trong: {baseDir}. Hãy Build project QLNhaHang trước."
                );

            var map = new ExeConfigurationFileMap
            {
                ExeConfigFilename = configPath
            };

            var cfg = ConfigurationManager.OpenMappedExeConfiguration(
                map, ConfigurationUserLevel.None
            );

            var cs = cfg.ConnectionStrings
                        .ConnectionStrings["NhaHangDBContext"]?
                        .ConnectionString;

            if (string.IsNullOrWhiteSpace(cs))
                throw new Exception(
                    "Không tìm thấy connection string 'NhaHangDBContext' trong QLNhaHang.dll.config"
                );

            var options = new DbContextOptionsBuilder<NhaHangDBContext>()
                .UseMySQL(cs)
                .Options;

            return new NhaHangDBContext(options);
        }
    }
}
