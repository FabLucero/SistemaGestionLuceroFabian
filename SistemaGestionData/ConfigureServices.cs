using Microsoft.Extensions.DependencyInjection;
using SistemaGestionData;
using SistemaGestionData.Context;
using SistemaGestionData.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureDataLayer(this IServiceCollection services)
    {
        services.AddDbContext<CoderhouseContext>();
        services.AddScoped<ProductosDataAccess>();
        services.AddScoped<UsuariosDataAccess>();
        services.AddScoped<ProductoVendidoDataAccess>();
        services.AddScoped<VentasDataAccess>();
        return services;
    }
}


