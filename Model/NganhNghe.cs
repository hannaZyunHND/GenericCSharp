using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic.Model
{
    public class NganhNghe : Base<int>
    {
        public int Ten { get; set; }
        public string Code { get; set; }
        public decimal PhanTramVAT { get; set; }
    }
}