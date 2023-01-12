using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic.Model
{
    public class PhongBan : Base<int> // Ke thua lai class cha co generic theo type = int
    {
        public string Ten { get; set; }
        public int SoNhanVien { get; set; }
        public string CoSo { get; set; }
        
        // public PhongBan() // Khi ke thua: Generic T dai dien
        // {
        //     // this.Id = "jsadjkas";
        //     this.Id = 1;

        // }

    }
}