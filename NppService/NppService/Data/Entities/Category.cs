using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NppService.Data.Entities
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public IList<Post> Posts { get; set; }

        public IList<Article> Articles { get; set; }
    }
}
