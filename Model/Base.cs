using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic.Model
{
    public class Base<T>
    {
        public T Id { get; set; }
    }
}