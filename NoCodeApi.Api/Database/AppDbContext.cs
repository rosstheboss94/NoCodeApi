using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoCodeApi.Api.Models;

namespace NoCodeApi.Api.Database;

public class AppDbContext : IdentityDbContext<ApiUser>
{
    public AppDbContext(DbContextOptions options) : base(options){}
   
   public DbSet<UserApi> Apis { get; set; }
   public DbSet<UserApiController> Controllers { get; set; }
   public DbSet<UserApiModel> Models { get; set; }

}
