using BugManageRestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugManageRestApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TicketsController : ControllerBase
  {
    [HttpGet]
    [Route("api/tickets")]
    public IActionResult Get()
    //---- Filter pipeling----------
    //Authentication and Authorization

    // Generic validation

    // Retrieve and Input data

    //Data validation

    //Application logc and Data

    //Fortmat output data

    // Exception handling
    {
      return Ok("Reading all tickets.");
    }

    [HttpGet]
    [Route("api/tickets/{id}")]
    public IActionResult Get(int id)
    {
      return Ok($"Reading tickets ID:{id}.");
    }

    [HttpPost]
    [Route("api/tickets/")]
    public IActionResult Post([FromBody] Ticket ticket)
    {
      return Ok(ticket);
    }

    [HttpPut]
    [Route("api/tickets/{id}")]
    public IActionResult Put([FromBody] Ticket ticket)
    {
      return Ok(ticket);
    }


    [HttpDelete]
    [Route("api/tickets/{id}")]
    public IActionResult Delete(int id)
    {
      return Ok($"Deleting a tickets ID:{id}.");
    }
  }
}
