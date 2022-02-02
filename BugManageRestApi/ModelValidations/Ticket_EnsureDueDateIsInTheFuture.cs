using BugManageRestApi.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace BugManageRestApi.ModelValidations
{
  public class Ticket_EnsureDueDateIsInTheFuture : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      var ticket = validationContext.ObjectInstance as Ticket;
      if (ticket != null && !string.IsNullOrWhiteSpace(ticket.Owner))
      {
        if (ticket.DueDate.Value < DateTime.Now && ticket.DueDate.HasValue)
          return new ValidationResult("Due date is has to be in the future");
      }
      return ValidationResult.Success;
    }
  }
}
