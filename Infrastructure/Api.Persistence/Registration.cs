﻿using Api.Application.Interfaces;
using Api.Application.Interfaces.Repositories;
using Api.Persistence.Context;
using Api.Persistence.Repositories;
using Api.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
