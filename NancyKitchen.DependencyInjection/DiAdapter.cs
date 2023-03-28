using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NencyKitchen.BusinessLogic;
using NencyKitchen.BusinessLogic.Interfaces;
using NencyKitchen.Services;
using NencyKitchen.Services.DbContexts;
using NencyKitchen.Services.Interfaces;
using System.Reflection;

namespace NancyKitchen.DependencyInjection
{
    public static class DiAdapter
    {
        public static void AddMyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IRecipeIngredientService, RecipeIngredientService>();
            services.AddScoped<IRecipeIngredientRepository, RecipeIngredientRepository>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

            services.AddDbContext<NencyKitchenDbContext>(options =>
            options.UseSqlServer("name=ConnectionStrings:NencyKitchenDbConn"));

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<NencyKitchenDbContext>();
        }
        
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();
            return services;
        }
    }
}
