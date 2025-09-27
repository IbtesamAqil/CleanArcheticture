using CleanArcheticture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
    public AppDbContext CreateDbContext(string[] args)
        {
        // Locate appsettings.json (adjust path for your solution)
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true)        // if running in API project
            .AddJsonFile("..\\CleanArchitecture.API\\appsettings.json", optional: true) // if Infra project doesn’t have one
            .AddEnvironmentVariables()
            .Build();

        var conn = config.GetConnectionString("DefaultConnection")
                   ?? "Server=.\\SQLEXPRESS;Database=MovieDB;Trusted_Connection=True;TrustServerCertificate=True";

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(conn)
            .Options;

        return new AppDbContext(options);
        }
    }