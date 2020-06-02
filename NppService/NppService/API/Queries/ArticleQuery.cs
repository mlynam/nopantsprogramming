using HotChocolate;
using Microsoft.EntityFrameworkCore;
using NppService.Data.Contexts;
using NppService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.API.Queries
{
    public class ArticleQuery
    {
        public async Task<List<Article>> GetArticles([Service] MainContext context)
            => await context
                .Articles
                .ToListAsync();

        public async Task<Article> GetArticle([Service] MainContext context, int id)
            => await context
                .Articles
                .FindAsync(id);
    }
}
