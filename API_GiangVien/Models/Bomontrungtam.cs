using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Bomontrungtam
    {
        public Bomontrungtam()
        {
            Giangvien = new HashSet<Giangvien>();
        }

        public int Mabm { get; set; }
        public string TenBm { get; set; }
        public string DiaChi { get; set; }
        public string Fax { get; set; }
        public string ThongTin { get; set; }
        public string NhiemVuChuyenMon { get; set; }
        public string HuongNghienCuu { get; set; }
        public string DoiNguGiangVien { get; set; }

        public virtual ICollection<Giangvien> Giangvien { get; set; }
    }
}
