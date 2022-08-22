using Shopping.API.Middleware;
using Shopping.Application.Abstract;
using Shopping.Application.Concrete;
using Shopping.EntityFrameworkCore.Repositories.Abstract;
using Shopping.EntityFrameworkCore.Repositories.Concrete;
using Shopping.EntityFrameworkCore.UnitOfWork.Abstract;
using Shopping.EntityFrameworkCore.UnitOfWork.Concrete;

namespace Shopping.API.Configuration;

public static class NativeDependencyConfiguration
{
    public static void AddNativeDependencies(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICartRepository, CartRepository>();
        services.AddScoped<ICartService, CartService>();
        services.AddTransient<CurrentUserMiddleware>();
    }
}