using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generic.Model;

namespace Generic.Service
{
    public class PhongBanService : BaseService<PhongBan>
    {
        public override List<PhongBan> Filter<K>(K keyword)
        {
            throw new NotImplementedException();
        }

        public override void MockingData()
        {
            throw new NotImplementedException();
        }
    }
}