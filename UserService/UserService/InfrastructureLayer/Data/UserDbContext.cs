using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Data
{
    //1: implement DbContext kế thừa từ EntityFramework
    public class UserDbContext: DbContext
    {
        //2. Cấu hình kết nối với database thông qua DbContextOptions
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        //3. Định nghĩa các DbSet tương ứng với các bảng trong database
        public DbSet<Users> Users { get; set; }

        //4. Cấu hình mô hình dữ liệu (nếu cần) bằng cách override phương thức OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình thêm nếu cần, ví dụ:
            // modelBuilder.Entity<Users>().Property(u => u.Username).IsRequired().HasMaxLength(100);
        }
    }
}
