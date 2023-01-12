using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generic.Model;

namespace Generic.Service
{
    public class NhanVienService : BaseService<NhanVien>
    {
        public override List<NhanVien> Filter<K>(K keyword)
        {
            var result = new List<NhanVien>();
            if (typeof(K) == typeof(string))
            {
                result = _data.Where(r => r.Ten.Contains(keyword as string)).ToList();
            }
            else if (typeof(K) == typeof(DateTime))
            {
                result = _data.Where(r => r.NgaySinh >= (keyword as DateTime?).Value).ToList();
            }
            else if (typeof(K) == typeof(double))
            {
                result = _data.Where(r => r.Luong >= (keyword as double?).Value).ToList();
            }
            return result;
        }


        public IEnumerable<NhanVien> FilterWithInterator(string keyword)
        {
            foreach (var item in _data)
            {
                if (item.Ten.Contains(keyword) || item.ChucVu.Contains(keyword))
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<NhanVien> FilterNameWithCharactor(string keyword)
        {
            var result = new List<NhanVien>();
            foreach (var item in _data)
            {
                if (item.Ten.Contains(keyword))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public IEnumerable<NhanVien> FilterNameWithCharactorInterator(string keyword)
        {
            foreach (var item in _data)
            {
                if (item.Ten.Contains(keyword))
                {
                    yield return item;
                }
            }
        }

        public override void MockingData()
        {
            Console.WriteLine("ABCDEF");
        }
    }
}