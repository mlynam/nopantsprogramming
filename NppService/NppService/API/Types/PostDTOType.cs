using HotChocolate.Types;
using NppService.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.API.Types
{
  public class PostDTOType : ObjectType<PostDTO>
  {
    protected override void Configure(IObjectTypeDescriptor<PostDTO> descriptor)
    {
      descriptor.BindFieldsImplicitly();
    }
  }
}
