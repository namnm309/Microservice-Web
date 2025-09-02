using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Data
{
    internal class UserDbContextFactory : IDesignTimeDbContextFactory<UserDbContext>
    {
        // Đây là phương thức có sẵn khi implement IDesignTimeDbContextFactory
        //Dùng khi chạy các lệnh EF Core CLI như migrations\
        // EF CLI sẽ dùng class này để tạo DbContext khi làm migrations,
        // không cần Startup (Program.cs) của ControllerLayer.
        public UserDbContext CreateDbContext(string[] args)
        {
            var configPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "ControllerLayer");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(configPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<UserDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connectionString);

            return new UserDbContext(optionsBuilder.Options);
        }
    }
}
