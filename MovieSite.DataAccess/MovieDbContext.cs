using Microsoft.EntityFrameworkCore;
using MovieSite.Entities;
using System;
using System.Collections.Generic;
using System.Text;



namespace MovieSite.DataAccess
{
    public class MovieDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-4C3LNDD;Database=MovieDb;uid=sasasa;pwd=12;");
        }

        public DbSet <Movie> Movies { get; set; }
    }
}