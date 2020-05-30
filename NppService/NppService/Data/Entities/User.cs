using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(48)]
        public string Nickname { get; set; }

        [StringLength(48)]
        public string Username { get; set; }

        [ProtectedPersonalData]
        public string Password { get; set; }

        [ProtectedPersonalData]
        public string Token { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
