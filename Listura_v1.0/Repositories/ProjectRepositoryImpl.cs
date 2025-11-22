using Listura_v1._0.Database;
using Listura_v1._0.Models;
using Listura_v1._0.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Listura_v1._0.Repositories
{
    public class ProjectRepositoryImpl : IProjectRepository
    {
        ListuraDbContext Context;
        public ProjectRepositoryImpl(ListuraDbContext Context)
        {
            this.Context = Context;
        }
        public async Task<Project> CreateProjectAsync(Project project)
        {
            Context.TblProject.Add(project);
            await Context.SaveChangesAsync();
            return project;
        }

        public async Task<Project?> GetProjectByIdAsync(int id, string userId)
        {
            return await Context.TblProject.FirstOrDefaultAsync(p => p.Id == id && p.UserId == userId);
        }

        public async Task<Project?> GetProjectByNameAsync(string ProjectName, string userId)
        {
            return await Context.TblProject.FirstOrDefaultAsync(p => p.ProjectName == ProjectName && p.UserId == userId);
        }

        public async Task<List<Project>> GetProjectsByUserAsync(string userId)
        {
            return await Context.TblProject.Where(p => p.UserId == userId).ToListAsync();
        }
    }
}
