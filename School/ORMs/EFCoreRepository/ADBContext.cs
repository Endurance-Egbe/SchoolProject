using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMs.EFCoreRepository
{
    public abstract class ADBContext : DbContext
    {
        public ADBContext()
        {
            Database.EnsureCreated();

        }
        public DbSet<SchoolModel> Schools { get; set; }
        public DbSet<Principal> Principal { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected abstract void InitialiseDatabase(DbContextOptionsBuilder optionsBuilder);
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            SQLitePCL.Batteries.Init();
            InitialiseDatabase(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolModel>(x => x.HasKey(y => y.Id))
                .Entity<Principal>(x => x.HasKey(y => y.Id))
                .Entity<SchoolClass>(x => x.HasKey(y => y.Id))
                .Entity<Subject>(x => x.HasKey(y => y.Id))
                .Entity<Student>(x => x.HasKey(y => y.Id))
                .Entity<Teacher>(x => x.HasKey(y => y.Id));
            base.OnModelCreating(modelBuilder);
        }

    }
}
