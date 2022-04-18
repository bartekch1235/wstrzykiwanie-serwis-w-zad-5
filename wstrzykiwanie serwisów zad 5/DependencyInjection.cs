using wstrzykiwanie_serwisów_zad_5.Interfaces;
using wstrzykiwanie_serwisów_zad_5.Repositories;
using wstrzykiwanie_serwisów_zad_5.Services;

namespace wstrzykiwanie_serwisów_zad_5
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this
        IServiceCollection services)
        {
            services.AddTransient<IPersonService,PersonService>();
            services.AddTransient<IPersonRepository,PersonRepository>();
            return services;
        }
    }

}
