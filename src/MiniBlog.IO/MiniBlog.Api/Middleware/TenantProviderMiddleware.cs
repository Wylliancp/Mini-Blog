using Microsoft.AspNetCore.Http;
using MiniBlog.Domain.Entities;
using MiniBlog.Infrastructure.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBlog.Api.Middleware
{
    public class TenantProviderMiddleware
    {
        private readonly RequestDelegate next;

        public TenantProviderMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext httpContext, DbContext dbContext)
        {
            string urlHost = httpContext.Request.Host.ToString();

            if (string.IsNullOrEmpty(urlHost))
            {
                throw new ApplicationException("urlHost must be specified");
            }

            urlHost = urlHost.Remove(urlHost.IndexOf(":"), urlHost.Length - urlHost.IndexOf(":")).ToLower().Trim();

            Tenant tenant = dbContext.Tenant(urlHost);

            //Todo criar  tenant
            //if (tenant == null)
            //{
            //    throw new ApplicationException("tenant not found based on URL, no default found");
            //}

            httpContext.Items.Add("TENANT", tenant);

            return next(httpContext);
        }
    }
}
