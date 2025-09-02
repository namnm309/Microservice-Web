using DomainLayer.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    [Table("tbl_users")]
    public class Users : BaseEntity
    {
        //Đã có Id, CreatedAt, UpdatedAt kế thừa từ BaseEntity

        public string Username { get; set; } 

        public string Password { get; set; }

        public string FullName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Address { get; set; }

        public string? IdentityCard {  get; set;} //cccd 

        public UserRole Role { get; set; } = UserRole.User; 

        public bool IsActive { get; set; } = true; //Mặc định tài khoản luôn hoạt động

        public string? AvatarUrl { get; set; } //Ảnh đại diện

        public double Point { get; set; } = 0; //Điểm tích lũy của user

        public DateTime? LastLogin { get; set; } //Lần đăng nhập cuối cùng

        public string? FacebookUrl { get; set; } 

    }
}
