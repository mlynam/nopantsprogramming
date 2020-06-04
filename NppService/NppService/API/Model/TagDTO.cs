using AutoMapper;
using AutoMapper.Configuration.Annotations;
using NppService.Data.Entities;
using System;

namespace NppService.API.Model
{
  public class TagDTO
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }
  }
}
