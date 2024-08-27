using Api.Domain.Entities;
using Api.Persistence.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Api.Persistence.Context
{
    public class AppDbContext : IdentityDbContext<User, Role, Guid>
    {
        public AppDbContext() {}
        public AppDbContext ( DbContextOptions<AppDbContext>options) : base(options)
        {

        }
       
        public DbSet<Coach> Coach { get; set; }
        public DbSet<Competition> Competition { get; set; }
        public DbSet<Difficulty> Difficulty { get; set; }
        public DbSet<Gymnast> Gymnast { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<CompetitionGymnast> CompetitionGymnast { get; set; }  
        public DbSet<CoachGymnast> CoachGymnast { get; set; }

        public DbSet<GymnastParent> GymnastParent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CoachGymnastConfiguration());
            modelBuilder.ApplyConfiguration(new CoachConfiguration());
            modelBuilder.ApplyConfiguration(new CompetitionGymnastConfiguration());
            modelBuilder.ApplyConfiguration(new CompetitionConfiguration());
            modelBuilder.ApplyConfiguration(new DifficultyConfiguration());
            modelBuilder.ApplyConfiguration(new GymnastConfiguration());
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            modelBuilder.ApplyConfiguration(new GymnastParentConfiguration());
            modelBuilder.ApplyConfiguration(new SeriesConfiguration());
            modelBuilder.ApplyConfiguration(new WorkoutsConfiguration());
            base.OnModelCreating(modelBuilder);
            


        }
    }
}
