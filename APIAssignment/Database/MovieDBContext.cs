using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIAssignment.Entities;

namespace APIAssignment.Database
{
    public class MovieDBContext:DbContext
    {
        //Entity set
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Data Source=MUSKAN\SQLEXPRESS;Initial Catalog=MovieDB;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=MUSKAN\ABC;Password=muskanpandey") ;
            
        }
    }
}
