using Microsoft.Extensions.Configuration;

using Npgsql;

namespace Engine.Infrastructure.Extensions;
public static class ConfigurationExtension
{
    public static string GetPostgresConnectionString(this IConfiguration config)
    {
       var builder = new NpgsqlConnectionStringBuilder(config.GetConnectionString("Postgres"))
       {
           Password = config["Database:Password"]
       };
       return builder.ConnectionString;
    }
}