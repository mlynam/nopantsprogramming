using NppService.API.Types;
using NppService.Data.Contexts;
using NppService.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.API
{
    public class Query
    {
        private readonly MainContext _context;

        public Query(MainContext context)
        {
            _context = context;
        }

        public IQueryable<Article> Articles() => _context.Articles;
    }
}
