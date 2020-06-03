using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NppService.Data.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public IList<ArticleTag> Articles { get; set; }

        public IList<PostTag> Posts { get; set; }
    }
}
