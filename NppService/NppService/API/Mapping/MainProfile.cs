using AutoMapper;
using NppService.API.Model;
using NppService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.API.Mapping
{
  public class MainProfile : Profile
  {
    public MainProfile()
    {
      CreateMap<PostTag, TagDTO>()
        .ForMember(dest => dest.Name, action => action.MapFrom(src => src.Tag.Name))
        .ForMember(dest => dest.UpdatedOn, action => action.MapFrom(src => src.Tag.UpdatedOn))
        .ForMember(dest => dest.CreatedOn, action => action.MapFrom(src => src.Tag.CreatedOn));

      CreateMap<Post, PostDTO>();
    }
  }
}
