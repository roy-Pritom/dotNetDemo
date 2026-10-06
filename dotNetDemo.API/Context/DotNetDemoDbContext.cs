using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotNetDemo.API.Context
{
    public class DotNetDemoDbContext : DbContext
    {

        public DotNetDemoDbContext(DbContextOptions<DotNetDemoDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Post> Posts { get; set; }

    }
}