using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NppService.Data.Entities
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public IList<ArticleTag> Tags { get; set; }
    }
}
