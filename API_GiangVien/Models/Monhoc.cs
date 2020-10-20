using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Monhoc
    {
        public int MaMh { get; set; }
        public string TenMh { get; set; }
        public int? SoTclt { get; set; }
        public int? SoTcth { get; set; }
        public int? TrangThai { get; set; }
    }
}
