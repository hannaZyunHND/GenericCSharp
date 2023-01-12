using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic.Model
{
    public class NhanVien : Base<int>
    {
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ChucVu { get; set; }
        public double Luong { get; set; }

        
    }
}