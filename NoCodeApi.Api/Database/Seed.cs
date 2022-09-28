using Microsoft.AspNetCore.Identity;
using NoCodeApi.Api.Models;

namespace NoCodeApi.Api.Database;

public static class Seed 
{
    public static async void SeedData(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;

        try
        {
            var context = services.GetRequiredService<AppDbContext>();
            var userManger = services.GetRequiredService<UserManager<ApiUser>>();

            await context.Database.EnsureCreatedAsync();

            if(!userManger.Users.Any())
            {
                var user = new ApiUser
                {
                    UserName = "test",
                    Email = "test@email.com"
                };

                await userManger.CreateAsync(user, "Pa$$w0rd");
            }
        }
        catch(Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occured during migration");
        }
    }
}