using HotChocolate.Types;
using NppService.Data.Entities;

namespace NppService.API.Types
{
    public class CategoryType : ObjectType<Category>
    {
        protected override void Configure(IObjectTypeDescriptor<Category> descriptor)
        {
            descriptor.Name("Category");
            descriptor.BindFields(BindingBehavior.Explicit);

            descriptor.Field(x => x.Id);
            descriptor.Field(x => x.Name);
            descriptor.Field(x => x.CreatedOn);
            descriptor.Field(x => x.UpdatedOn);
            descriptor.Field(x => x.Articles);
            descriptor.Field(x => x.Posts);
        }
    }
}
