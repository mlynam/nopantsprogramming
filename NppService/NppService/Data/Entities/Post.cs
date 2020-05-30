using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<PostTag> Tags { get; set; }
    }
}
