using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        [StringLength(1024)]
        public string Content { get; set; }

        public int? PostId { get; set; }

        public virtual Post Post { get; set; }

        public int? ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
