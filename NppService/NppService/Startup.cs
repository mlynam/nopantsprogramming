using AutoMapper;
using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NppService.API;
using NppService.API.Types;
using NppService.Data.Contexts;
using System.Reflection;

namespace NppService
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();

      services.AddDbContext<MainContext>();

      services.AddAutoMapper(Assembly.GetExecutingAssembly());

      services.AddGraphQL(
          SchemaBuilder.New()
          .AddType<ArticleType>()
          .AddType<UserType>()
          .AddType<PostType>()
          .AddType<PostDTOType>()
          .AddType<CategoryType>()
          .AddType<TagType>()
          .AddQueryType<Query>()
          .Create());
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

      app.UseGraphQL("/api");
      app.UsePlayground("/api", "/playground");
    }
  }
}
