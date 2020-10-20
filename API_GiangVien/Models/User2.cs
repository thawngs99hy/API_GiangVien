using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class User2
    {
        public string UserId { get; set; }
        public string Hoten { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Gioitinh { get; set; }
        public string Email { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Role { get; set; }
        public string ImageUrl { get; set; }
    }
}
