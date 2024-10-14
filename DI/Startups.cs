using MVC_Core.Services;

namespace MVC_Core.DI
{
    public class Startups
    {
        public void ConfigConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IProductService, ProductService>();


        }

        public void configure(IApplicationBuilder app, IWebHostEnvironment env) 
        { 
        
        }
    }
}
