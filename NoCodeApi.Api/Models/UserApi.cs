namespace NoCodeApi.Api.Models;

public class UserApi
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ApiUser ApiUser { get; set; }
    public string ApiUserId { get; set; }
    public IEnumerable<UserApiController> UserApiControllers { get; set; }
}