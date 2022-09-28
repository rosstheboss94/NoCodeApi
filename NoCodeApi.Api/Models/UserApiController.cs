namespace NoCodeApi.Api.Models;

public class UserApiController
{
    public int Id { get; set; }
    public string Name { get; set; }
    public UserApi UserApi { get; set; }
    public int UserApiId { get; set; }
    public UserApiModel UserApiModel { get; set; }
}