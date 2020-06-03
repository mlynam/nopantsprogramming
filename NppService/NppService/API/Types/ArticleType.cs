using HotChocolate;
using HotChocolate.Types;
using NppService.Data.Entities;
using System.Security.Cryptography.X509Certificates;

namespace NppService.API.Types
{
    [GraphQLName("Article")]
    public class ArticleType : ObjectType<Article>
    {
        protected override void Configure(IObjectTypeDescriptor<Article> descriptor)
        {
            descriptor.BindFields(BindingBehavior.Explicit);

            descriptor.Field(x => x.Id);
        }
    }
}
