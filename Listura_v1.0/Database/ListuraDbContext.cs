using Listura_v1._0.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Listura_v1._0.Database
{
    public class ListuraDbContext : IdentityDbContext<IdentityUser>
    {
        public ListuraDbContext(DbContextOptions<ListuraDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<Models.Label> Labels { get; set; }
        public DbSet<TaskLabel> TaskLabels { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

    }

}
