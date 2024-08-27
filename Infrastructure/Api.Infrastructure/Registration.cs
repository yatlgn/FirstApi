using Api.Infrastructure.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Infrastructure
{
   public static class Registration
    {
        public static void AddInfrastructureMapper(this IServiceCollection servises, IConfiguration configuration)
        {
            servises.Configure<TokenSettings>(configuration.GetSection("JWT"));
        }
    }
}

