using Microsoft.EntityFrameworkCore;
using NoCodeApi.Api.Database;

namespace NoCodeApi.Api.Extensions;

public static class AppExtensions
{
    public static void AddDbExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(options => 
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        //builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); 
    }
}
