using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection servises)
        {
            var assembly = Assembly.GetExecutingAssembly();

            servises.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

        }
    }
}
