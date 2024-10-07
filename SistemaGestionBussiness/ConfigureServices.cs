using Microsoft.Extensions.DependencyInjection;
using SistemaGestionBussiness.Services;
using SistemaGestionData;
using SistemaGestionData.Context;
using SistemaGestionData.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigureBussinessLayer(this IServiceCollection services)
        {
            services.ConfigureDataLayer();
            services.AddScoped<ProductosService>();
            services.AddScoped<UsuariosService>();
            services.AddScoped<ProductosVendidosService>();
            services.AddScoped<VentasService>();

            return services;
        }
    }
}
