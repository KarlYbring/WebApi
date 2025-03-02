using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/projects")]
[ApiController]
public class ProjectsController(ProjectService projectService) : ControllerBase
{
    private readonly ProjectService _projectService = projectService;
    
    [HttpPost]
    public async Task<IActionResult> Create(ProjectRegistration form)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        var project = await _projectService.CreateProjectAsync(form);
        return CreatedAtAction(nameof(GetProjects), new { id = project.Id }, project);
    }

    [HttpGet]
    public async Task<IActionResult> GetProjects()
    {
        return Ok(await _projectService.GetProjectsAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProject(int id)
    {
        var project = await _projectService.GetProjectAsync(id);
        return project == null ? NotFound() : Ok(project);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(ProjectUpdate form)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var project = await _projectService.UpdateProjectAsync(form);
        return Ok(project);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
       await _projectService.DeleteProjectAsync(id);
       return NoContent();
    }
}
