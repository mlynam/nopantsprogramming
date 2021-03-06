﻿using HotChocolate.Types;
using NppService.Data.Entities;

namespace NppService.API.Types
{
    public class ArticleType : ObjectType<Article>
    {
        protected override void Configure(IObjectTypeDescriptor<Article> descriptor)
        {
            descriptor.Name("Article");
            descriptor.BindFields(BindingBehavior.Explicit);

            descriptor.Field(x => x.Id);
            descriptor.Field(x => x.User);
            descriptor.Field(x => x.UserId);
            descriptor.Field(x => x.Category);
            descriptor.Field(x => x.CategoryId);
            descriptor.Field(x => x.Title);
            descriptor.Field(x => x.Content);
            descriptor.Field(x => x.CreatedOn);
            descriptor.Field(x => x.UpdatedOn);
            descriptor.Field(x => x.Tags);
        }
    }
}
