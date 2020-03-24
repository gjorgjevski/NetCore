using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NetCore.Application.Interfaces;
using NetCore.Application.Services;
using NetCore.Data.Context;
using NetCore.Data.Repository;
using NetCore.Domain.CommandHandlers;
using NetCore.Domain.Commands;
using NetCore.Domain.Core.Bus;
using NetCore.Domain.Interfaces;
using NetCore.Ibus;
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

            // Domain inMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            services.AddScoped<UniversityDbContext>();



        }
    }
}
