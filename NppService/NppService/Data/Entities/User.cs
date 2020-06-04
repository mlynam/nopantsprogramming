using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NppService.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(48)]
        public string Nickname { get; set; }

        [Required]
        [StringLength(48)]
        public string Username { get; set; }

        [Required]
        [ProtectedPersonalData]
        public string Password { get; set; }

        [ProtectedPersonalData]
        public string Token { get; set; }

        public DateTime RegisteredOn { get; set; }

        public virtual IList<Post> Posts { get; set; }

        public virtual IList<Article> Articles { get; set; }
    }
}
