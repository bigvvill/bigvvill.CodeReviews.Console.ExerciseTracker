using bigvvill.CodeReviews.Console.ExerciseTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Data
{
    public class ExerciseTrackerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ExerciseTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Exercise> Exercises { get; set; }
    }
}
