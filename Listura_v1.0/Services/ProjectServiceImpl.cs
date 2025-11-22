using Listura_v1._0.Models;
using Listura_v1._0.Models.DTOs;
using Listura_v1._0.Repositories.Interfaces;
using Listura_v1._0.Services.Interfaces;

namespace Listura_v1._0.Services
{
    public class ProjectServiceImpl : IProjectService
    {
        IProjectRepository projectRepository;
        public ProjectServiceImpl(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        public async Task<Project> CreateProjectAsync(string userId, ProjectDto dto)
        {
            var existing = projectRepository.GetProjectByNameAsync(dto.ProjectName, userId);
            if (existing != null)
            {
                throw new Exception("A project with this name already exists!");
            }
            var project = new Project
            {
                ProjectName = dto.ProjectName,
                UserId = userId,
                Theme = dto.Theme,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            return await projectRepository.CreateProjectAsync(project);
        }

        public async Task<Project> GetProjectsByIdAsync(int Id, string userId)
        {
            var project = await projectRepository.GetProjectByIdAsync(Id, userId);
            if (project == null)
            {
                throw new Exception($"No project of id {Id} exists!");
            }
            return project;
        }

        public async Task<List<Project>> GetProjects(string userId)
        {
            var project = await projectRepository.GetProjectsByUserAsync(userId);
            if (project == null)
            {
                throw new Exception("User have no projects");
            }
            return project;
        }
    }
}
