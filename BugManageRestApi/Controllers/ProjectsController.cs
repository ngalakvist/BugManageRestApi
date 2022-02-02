using BugManageRestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugManageRestApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProjectsController : ControllerBase
  {
    [HttpGet]
    [Route("api/projects")]
    public IActionResult Get()
    {
      return Ok("Reading all projects.");
    }

    [HttpGet]
    [Route("api/projects/{id}")]
    public IActionResult GetById(int id)
    {
      return Ok($"Reading projects ID:{id}.");
    }

    [HttpPost]
    [Route("api/projects/")]
    public IActionResult Post([FromBody] Project project)
    {
      return Ok(project);
    }

    [HttpPut]
    [Route("api/projects/{id}")]
    public IActionResult Put([FromBody] Project project)
    {
      return Ok(project);
    }


    [HttpDelete]
    [Route("api/projects/{id}")]
    public IActionResult Delete(int id)
    {
      return Ok($"Deleting a projects ID:{id}.");
    }


    /// <summary>
    /// api/projects/{pid}/tickets?tid ={tid} using quesry string
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("/api/projects/{pid}/tickets/")]
    public IActionResult GetProjectTicket([FromQuery] Ticket ticket)
    {
      if (ticket == null) return BadRequest("Missing parametera");
      return Ok($" Reading project number #{ticket.ProjectId}, ticket #{ticket.TicketId}");
    }
  }

}

