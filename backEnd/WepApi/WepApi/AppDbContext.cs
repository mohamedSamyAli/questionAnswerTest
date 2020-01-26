using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WepApi
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
           .HasMany(c => c.answers).WithOne(e=>e.question);
        }
    



    public DbSet<Question> questions { get; set; }
        public DbSet<Answer> answers { get; set; }
    }
}
