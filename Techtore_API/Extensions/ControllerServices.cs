using Techtore_API.Filters;

namespace Techtore_API.Extensions
{
    public static class ControllerServices
    {
        public static IServiceCollection CSTMAddControllerServices(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return services;
        }
    }
}
