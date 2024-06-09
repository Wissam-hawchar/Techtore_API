using _TechTore_BLL.Services.AccountingServices;
using _TechTore_BLL.Services.CartWithItemsServices;
using _TechTore_BLL.Services.ProductServices;
using _TechTore_BLL.Services.UserServices;
using _TechTore_DAL.Repositries.AccountingRepo;
using _TechTore_DAL.Repositries.CartItemRepo;
using _TechTore_DAL.Repositries.CartRepo;
using _TechTore_DAL.Repositries.ProductRepo;
using _TechTore_DAL.Repositries.UserRepo;

namespace Techtore_API.Extensions
{ 
    public static class RepositoryExtensions
    {
        public static IServiceCollection CSTMAddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAccountingRepository, AccountingRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartItemRepository, CartItemRepository>();
            return services;
        }
        public static IServiceCollection CSTMAddServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountingService, AccountingService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartWithItemsService, CartWithItemsService>();
            return services;
        }
    }
}
