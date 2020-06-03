using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using NppService.Data.Contexts;
using NppService.Data.Entities;
using System.Linq;

namespace NppService.API
{
    public class Query
    {
        private readonly MainContext _context;

        public Query(MainContext context)
        {
            _context = context;
        }

        [UseSelection]
        public IQueryable<Article> Articles() => _context.Articles.AsNoTracking();

        [UseSelection]
        public IQueryable<User> Users() => _context.Users.AsNoTracking();

        [UseSelection]
        public IQueryable<Post> Posts() => _context.Posts.AsNoTracking();

        [UseSelection]
        public IQueryable<Category> Categories() => _context.Categories.AsNoTracking();

        [UseSelection]
        public IQueryable<Tag> Tags() => _context.Tags.AsNoTracking();
    }
}
