using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Luong
    {
        public int MaLuong { get; set; }
        public int MaBac { get; set; }
        public int? MucLuong { get; set; }
        public decimal? LuongCb { get; set; }
        public decimal? LuongPc { get; set; }
        public DateTime? NgayHuongLuong { get; set; }
        public DateTime? NgayTangLuong { get; set; }
        public int? TrangThai { get; set; }

        public virtual Bacluong MaBacNavigation { get; set; }
    }
}
