using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TGE.Data.Entities;
public class LikeEntity
{
    public int LikeId { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }
}