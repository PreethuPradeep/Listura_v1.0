using Humanizer;
using Listura_v1._0.Models.DTOs;
using Listura_v1._0.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Security.Claims;

namespace Listura_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        IProjectService projectService;
        public ProjectsController(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public async Task<IActionResult> Create(ProjectDto dto)
        {
            try
            {
                string userId = GetUserId();
                var project = await projectService.CreateProjectAsync(userId, dto);
                return Ok(project);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IActionResult> GetProjectsById(int id)
        {
            try
            {
                string userId = GetUserId();
                var project = await projectService.GetProjectsByIdAsync(id,userId);
                return Ok(project);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IActionResult> GetProjectByUserId()
        {
            try
            {
                string userId = GetUserId();
                var projects = await projectService.GetProjects(userId);
                return Ok(projects);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
