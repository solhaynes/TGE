using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TGE.Data.Entities;

namespace TGE.Data;

public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole<int>, int>
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) { }
  
  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);

    builder.Entity<UserEntity>().ToTable("Users");
  }
}