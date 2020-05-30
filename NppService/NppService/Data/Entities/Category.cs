using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.Data.Entities
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
