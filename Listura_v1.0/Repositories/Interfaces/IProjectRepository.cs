using Listura_v1._0.Models;

namespace Listura_v1._0.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<Project> CreateProjectAsync(Project project);
        Task<List<Project>> GetProjectsByUserAsync(string userId);
        Task<Project?> GetProjectByIdAsync(int id, string userId);
        Task<Project?> GetProjectByNameAsync(string ProjectName, string userId);
    }
}
