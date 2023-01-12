using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Generic.Model;

namespace Generic.Service
{
    public interface IBaseService<T> where T : class
    {
        List<T> GetAll();
        T Add();
        T Update();
        void Delete();
        List<T> Filter(string keyword);
        T GetById(int id);
    }


    public abstract class BaseService<T> where T : class
    {
        public List<T> _data = new List<T>(); //Khai bao list data voi kieu du lieu la T
        public List<T> GetAll()
        {
            return _data;
        }
        public T Add(T entity)
        {
            if (entity != null)
            {
                //Day la ID tu tang
                var _maxId = 0;
                if (_data.Count > 0)
                {
                    _maxId = _data.Max(r => (r as Base<int>).Id);
                }
                //ID la so ngau nhien tu 1 -> 100
                var random = new Random();
                random.Next(1, 100);
                // (entity as Base<int>).Id = _maxId + 1;
                (entity as Base<int>).Id = random.Next(1, 100);

                _data.Add(entity);
            }
            return entity;
        }
        public T Update(int id, T entity)
        {
            if (entity != null)
            {
                var _obj = _data.FirstOrDefault(r => (r as Base<int>).Id == id);
                if (_obj != null)
                {
                    _obj = entity;
                }
            }
            return entity;
        }

        public void Delete(int id)
        {
            var _obj = _data.FirstOrDefault(r => (r as Base<int>).Id == id);
            if (_obj != null)
            {
                _data.Remove(_obj);
            }
        }

        public abstract List<T> Filter<K>(K keyword);


        // public List<T> FilterByExpression(Expression<Func<T, bool>> filter){
        //     return _data.Where(filter).ToList();
        // }

        public abstract void MockingData();
    }
}