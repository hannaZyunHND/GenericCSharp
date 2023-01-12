using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generic.Model;

namespace Generic.Service
{
    public class NganhNgheService : BaseService<NganhNghe>
    {
        public override List<NganhNghe> Filter<K>(K keyword)
        {
            var result = new List<NganhNghe>();
           
            return result;
        }

        public override void MockingData()
        {
            throw new NotImplementedException();
        }
    }
}