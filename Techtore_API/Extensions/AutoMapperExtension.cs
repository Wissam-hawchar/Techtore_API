using _TechTore_BLL.Mapping;

namespace Techtore_API.Extensions
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection CSTMAddAutoMappperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));
            return services;
        }
    }
}
