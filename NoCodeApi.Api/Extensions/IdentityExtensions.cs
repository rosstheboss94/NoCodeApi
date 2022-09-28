using Microsoft.AspNetCore.Identity;
using NoCodeApi.Api.Database;
using NoCodeApi.Api.Models;

namespace NoCodeApi.Api.Extensions;

public static class IdentityExtensions
{
    public static void AddIdentityExtensions(this IServiceCollection services)
    {
        services.AddIdentityCore<ApiUser>(options =>
        {
            options.User.RequireUniqueEmail = true;
            options.Password.RequireDigit = true;
            options.Password.RequiredUniqueChars = 1;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
        })
        .AddSignInManager<SignInManager<ApiUser>>()
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();
    }
}