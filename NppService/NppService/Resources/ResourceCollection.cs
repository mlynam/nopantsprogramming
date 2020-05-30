using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.Resources
{
    public class ResourceCollection<T> where T : class
    {
        public List<T> Data { get; set; }

        public int Count => Data.Count;

        public int Total { get; set; }

        public ResourceCollection(List<T> data, DbContext context = null)
        {
            Data = data;

            if (context == null)
                return;

            Total = context.Set<T>().Count();
        }
    }
}
