using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Hocvan
    {
        public int MaHv { get; set; }
        public int MaGv { get; set; }
        public string TenHv { get; set; }
        public DateTime? NamTotNghiep { get; set; }
        public string ChungChiSuPham { get; set; }
        public string ChuyenNganhDaoTao { get; set; }
        public string DonViCongTac { get; set; }
        public string TrinhDoTinHoc { get; set; }
        public string TrinhdoNgoaiNgu { get; set; }
        public int? TrangThai { get; set; }

        public virtual Giangvien MaGvNavigation { get; set; }
    }
}
