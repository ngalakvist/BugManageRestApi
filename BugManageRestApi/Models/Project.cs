using System.Collections.Generic;

namespace BugManageRestApi.Models
{
  public class Project
  {
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Ticket> Tickets { get; set; }
  }
}
