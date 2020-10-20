using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Sukien
    {
        public int MaSk { get; set; }
        public string TenSk { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
    }
}
