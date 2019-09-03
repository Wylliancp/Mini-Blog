using Microsoft.Extensions.DependencyInjection;
using MiniBlog.Aplication.Service;
using MiniBlog.Domain.Repository;
using MiniBlog.Domain.Service;
using MiniBlog.Infrastructure.Repository;

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
