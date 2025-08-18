using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    //Các entity khác sẽ kế thừa từ BaseEntity này cho những thuộc tính giống nhau dưới đây 
    //Sau khi kế thừa, các entity sẽ có các thuộc tính này và không cần phải định nghĩa lại
    public class BaseEntity
    {
        [Key] //Khóa chính 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Tự động sinh giá trị khi thêm bản ghi mới
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now; //Ngày tạo bản ghi

        public DateTime UpdatedAt { get; set; } = DateTime.Now; //Ngày cập nhật bản ghi
    }
}
