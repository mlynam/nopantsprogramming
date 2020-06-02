using HotChocolate;
using Microsoft.EntityFrameworkCore;
using NppService.Data.Contexts;
using NppService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NppService.API.Queries
{
    public class Query
    {
        public async Task<List<User>> GetUsers([Service] MainContext context)
             => await context
                .Users
                .ToListAsync();

        public async Task<User> GetUser([Service] MainContext context, int id)
            => await context
                .Users
                .FindAsync(id);
    }
}
