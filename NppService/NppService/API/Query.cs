using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using NppService.API.Model;
using NppService.Data.Contexts;
using NppService.Data.Entities;
using System.Linq;

namespace NppService.API
{
  public class Query
  {
    private readonly MainContext _context;
    private readonly IMapper _mapper;

    public Query(MainContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [UseSelection]
    public IQueryable<Article> Articles() => _context.Articles.AsNoTracking();

    [UseSelection]
    public IQueryable<User> Users() => _context.Users.AsNoTracking();

    public IQueryable<PostDTO> Posts() => _context.Posts
      .ProjectTo<PostDTO>(_mapper.ConfigurationProvider);

    [UseSelection]
    public IQueryable<Category> Categories() => _context.Categories.AsNoTracking();

    [UseSelection]
    public IQueryable<Tag> Tags() => _context.Tags.AsNoTracking();
  }
}
