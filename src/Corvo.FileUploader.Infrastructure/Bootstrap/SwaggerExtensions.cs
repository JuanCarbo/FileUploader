using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Corvo.FileUploader.Infrastructure.Bootstrap
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            return services;
        }

        public static IApplicationBuilder AddSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/Swagger/v1/swagger.json", "FileUploader Api V1");
                c.RoutePrefix = string.Empty;
            });
            return app;
        }
    }
}
