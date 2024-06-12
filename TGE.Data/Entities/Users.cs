using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TGE.Data.Entities;

public class Users : IdentityUser<int>
{
  [Required]
  [MaxLength(100)]
  public string Email { get; set; }

  [Required]
  [MaxLength(100)]
  public string Password { get; set; }
  [MaxLength(100)]
  public string? FirstName { get; set; }
  [MaxLength(100)]
  public string? LastName { get; set; }
}