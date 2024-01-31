using Livraria.Domain.Abstractions;
using Livraria.Infrastructure.Context;
using Livraria.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.CrossCutting.DependenciesApp;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
        IConfiguration configuration)
    {
        var connectionString = configuration
                              .GetConnectionString("Sqlite");

        services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite(connectionString));

        services.AddScoped<ILivroRepository, LivroRepository>();
        //services.AddScoped<ILivroService, LivroService>();

        return services;
    }
}
