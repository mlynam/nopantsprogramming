using HotChocolate.Types;
using NppService.Data.Entities;

namespace NppService.API.Types
{
  public class PostTagType : ObjectType<PostTag>
  {
    protected override void Configure(IObjectTypeDescriptor<PostTag> descriptor)
    {
      descriptor.BindFieldsExplicitly();
    }
  }
}