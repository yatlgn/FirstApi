using Api.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Api.Mapper
{
    public static class Registration
    {
        public static void AddUserMapper(this IServiceCollection servises)
        {

            servises.AddSingleton<IMapper, AutoMapper.Mapper>();

        }
    }
}
