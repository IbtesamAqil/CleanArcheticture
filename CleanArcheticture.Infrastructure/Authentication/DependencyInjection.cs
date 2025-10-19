

using CleanArcheticture.Application;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CleanArcheticture.Infrastructure.Authentication
    {
    public static class DependencyInjection
        {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
            {
            services.Configure<JwtOptions>(configuration.GetSection("Jwt"));

            // Token creator
            services.AddScoped<ITokenService, TokenService>();

            // JWT authentication
            var jwt = configuration.GetSection("Jwt");
            var key = Encoding.UTF8.GetBytes(jwt["Key"]!);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters
                        {
                        ValidateIssuer = true,
                        ValidIssuer = jwt["Issuer"],
                        ValidateAudience = true,
                        ValidAudience = jwt["Audience"],
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                        };
                });

            return services;
            }
        public static IServiceCollection AddApplication(this IServiceCollection services)
            {
            // Register application-level services, like MediatR, validators, mappers, etc.
            // For now it can be empty if you don’t have them yet.

            // Example (if you’re using MediatR):
            // services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

            return services;
            }
        }
    }
