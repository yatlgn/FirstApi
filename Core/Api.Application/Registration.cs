using Api.Application.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentValidation;
using MediatR;
using Api.Application.Beheviors;

namespace Api.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection servises)
        {
            var assembly = Assembly.GetExecutingAssembly();
            servises.AddTransient<ExceptionMiddleware>();

            servises.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            servises.AddValidatorsFromAssembly(assembly);

            servises.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));
          

        }
    }
}
