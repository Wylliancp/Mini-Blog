using Microsoft.Extensions.DependencyInjection;
using MiniBlog.Aplication.Service;
using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Repository;
using MiniBlog.Domain.Repository.Base;
using MiniBlog.Domain.Service;
using MiniBlog.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBlog.Dependency.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Infra - Data
            services.AddSingleton<DbContext>();
            services.AddScoped<IPostRepository, PostRepository>();

            //Aplication Service
            services.AddScoped<IPostService, PostService>();

        }
    }
}
