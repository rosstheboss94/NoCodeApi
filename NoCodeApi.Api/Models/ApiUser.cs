using Microsoft.AspNetCore.Identity;

namespace NoCodeApi.Api.Models;

public class ApiUser : IdentityUser
{
    public IEnumerable<UserApi> UserApis { get; set; }
}