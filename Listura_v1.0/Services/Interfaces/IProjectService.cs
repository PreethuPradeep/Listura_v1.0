using Listura_v1._0.Models;
using Listura_v1._0.Models.DTOs;

namespace Listura_v1._0.Services.Interfaces
{
    public interface IProjectService
    {
        Task<Project> CreateProjectAsync(string id,ProjectDto dto);
        Task<List<Project>> GetProjects(string userId);
        Task<Project> GetProjectsByIdAsync(int Id, string userId);
    }
}
