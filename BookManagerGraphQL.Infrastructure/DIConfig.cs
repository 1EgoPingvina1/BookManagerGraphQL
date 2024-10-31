using BookManagerGraphQL.Domain.Interfaces;
using BookManagerGraphQL.Infrastructure.Data;
using BookManagerGraphQL.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookManagerGraphQL.Infrastructure;

public static class DIConfig
{
    //DI container for implementing containers of repositories
    public static IServiceCollection InfrastructureConfigure(this IServiceCollection services)
    {
        services.AddDbContext<BookContext>(options =>
        {
            options.UseNpgsql("Host=localhost;Port=5432;Username=Adminchik;Password=g7Tq1Xz;Database=BookBase;");
        }, ServiceLifetime.Transient);
        services.AddTransient<IBookRepository, BookRepository>();
        services.AddScoped<IUoW,UoW>();
        return services;
    }
}