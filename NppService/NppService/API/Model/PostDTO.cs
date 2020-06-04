using AutoMapper;
using NppService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NppService.API.Model
{
  public class PostDTO
  {
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }

    public int? CategoryId { get; set; }

    public Category Category { get; set; }

    public IList<TagDTO> Tags { get; set; }
  }
}
