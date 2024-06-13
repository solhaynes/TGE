using System.ComponentModel.DataAnnotations;

namespace TGE.Models.User;

public class UserRegister
{
  [Required, EmailAddress]
  public string Email { get; set; }= string.Empty;
  [Required, MinLength(4)]
  public string Password { get; set; } = string.Empty;
  [Required, MinLength(4)]
  public string FirstName { get; set; } = string.Empty;
  [Required, MinLength (4)] 
  public string LastName { get; set; } = string.Empty;
}