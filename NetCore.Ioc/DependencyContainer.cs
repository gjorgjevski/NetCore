using Microsoft.Extensions.DependencyInjection;
using NetCore.Application.Interfaces;
using NetCore.Application.Services;
using NetCore.Data.Repository;
using NetCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) {
            // App Layer
            services.AddScoped<ICourseService, CourseService>();
            
            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
