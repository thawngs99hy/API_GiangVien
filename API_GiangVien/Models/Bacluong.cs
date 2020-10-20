using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Bacluong
    {
        public Bacluong()
        {
            Luong = new HashSet<Luong>();
        }

        public int MaBac { get; set; }
        public string TenBac { get; set; }
        public int? HsbacLuong { get; set; }
        public string NhomBac { get; set; }

        public virtual ICollection<Luong> Luong { get; set; }
    }
}
