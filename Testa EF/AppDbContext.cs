using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Testa_EF.Models;

namespace Testa_EF
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=ExamplesEF;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(AppDbContext)));
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasMany(x => x.Groups)
                .WithMany(x => x.Users)
                .UsingEntity(x => x.ToTable("UsersGroups"));

            builder.Entity<User>()
                .HasMany(x => x.Availabilities)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.Entity<Hobby>()
                .HasMany(x => x.AditionalInfos)
                .WithMany(x => x.Hobbies)
                .UsingEntity(x => x.ToTable("HobbiesAditionalInfos"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<AditionalInfo> AditionalInfos { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
    }
}
