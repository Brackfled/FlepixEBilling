using Application.Services.CurrentService;
using Application.Services.TaxDepartmentService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {

            services.AddScoped<ITaxDepartmentService, TaxDepartmentManager>();
            services.AddScoped<ICurrentService, CurrentManager>();

            return services;
        }
    }
}
