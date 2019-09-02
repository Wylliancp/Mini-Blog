using Microsoft.Extensions.DependencyInjection;
using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Repository.Base;
using MiniBlog.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBlog.Dependency.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra - Data
            services.AddSingleton<DbContext>();
            services.AddScoped<IBaseRepository<Post>, PostRepository>();

        }
    }
}
