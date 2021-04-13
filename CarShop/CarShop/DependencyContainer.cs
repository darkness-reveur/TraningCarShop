using CarShop.Infrastructure.SomeLogic.Implemented;
using CarShop.Infrastructure.SomeLogic.Interfacies;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop
{
    public static class DependencyContainer
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();

            services.AddTransient<IOrderService, OrderService>();
        }
    }
}
