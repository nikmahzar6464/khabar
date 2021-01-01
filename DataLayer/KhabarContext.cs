using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer
{
    public class KhabarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=KhabarDB;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<News>(new newsConfiguration());

            modelBuilder.Ignore<BaseEntity>();

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments{get;set;}
        public DbSet<UserType> UserTypes { get; set; }
        

    }



    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.CatTitle).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(2000).IsRequired();

        }
    }

    public class newsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();

        }
    }

}
