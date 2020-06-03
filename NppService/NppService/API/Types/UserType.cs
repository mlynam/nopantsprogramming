using HotChocolate.Types;
using NppService.Data.Entities;

namespace NppService.API.Types
{
    public class UserType : ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Name("User");
            descriptor.BindFields(BindingBehavior.Explicit);

            descriptor.Field(x => x.Id);
            descriptor.Field(x => x.Nickname);
            descriptor.Field(x => x.RegisteredOn);
            descriptor.Field(x => x.Articles);
            descriptor.Field(x => x.Posts);
        }
    }
}
