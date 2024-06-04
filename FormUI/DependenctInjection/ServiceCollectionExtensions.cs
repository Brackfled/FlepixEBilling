using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.DependenctInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection servicesCollections, ICoreModule[] coreModules)
        {
            foreach (var module in coreModules)
            {
                module.Load(servicesCollections);
            }

            return ServiceTool.Create(servicesCollections);
        }
    }
}
