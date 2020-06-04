using Microsoft.EntityFrameworkCore;
using NppService.Data.Entities;

namespace NppService.Data.Contexts
{
    public class MainContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options
          .UseLazyLoadingProxies()
          .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=nopantsprogramming;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}
