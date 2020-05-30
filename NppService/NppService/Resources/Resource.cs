using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.Resources
{
    public class Resource<T> where T : class
    {
        public T Data { get; set; }

        public Resource(T data)
        {
            Data = data;
        }
    }
}
