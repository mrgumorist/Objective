using Microsoft.EntityFrameworkCore;
using Objective.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Objective
{
    public class ObjectiveContext: DbContext
    {
        public ObjectiveContext(DbContextOptions<ObjectiveContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=.;Initial Catalog=Objective;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskTag>()
                .HasKey(t => new { t.TaskID, t.TagID });

            modelBuilder.Entity<TaskTag>()
                .HasOne(sc => sc.Task)
                .WithMany(s => s.TaskTags)
                .HasForeignKey(sc => sc.TaskID);

            modelBuilder.Entity<TaskTag>()
                .HasOne(sc => sc.Tag)
                .WithMany(c => c.TaskTags)
                .HasForeignKey(sc => sc.TagID);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
      
    }
}
