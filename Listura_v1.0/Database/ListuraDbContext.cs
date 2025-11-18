using Listura_v1._0.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Listura_v1._0.Database
{
    public class ListuraDbContext : IdentityDbContext<AppUser, IdentityRole,string>
    {
        public ListuraDbContext(DbContextOptions<ListuraDbContext> options):base(options)
        { 
        }
        public DbSet<AppUser> TblUser { get; set; }
        public DbSet<Project> TblProject { get; set; }
        public DbSet<Section> TblSection { get; set; }
        public DbSet<TaskItem> TblTask { get; set; }
        public DbSet<Label> TblLabel { get; set; }
        public DbSet<Reminder> TblReminder { get; set; }
        public DbSet<SubTask> TblSubTask { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskLabel>()
                .HasKey(t1 => new { t1.TaskItemId, t1.LabelId });
        }
    }
}
