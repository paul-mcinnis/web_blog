using System;
using DotNetApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Data.Repository
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=document.db");
    }
}
