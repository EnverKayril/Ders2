using _16_MVC_DependencyInjection.Services.Abstract;
using _16_MVC_DependencyInjection.Services.Concrete;

namespace _16_MVC_DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddTransient<IProductService, IProductService>();
            //AddTransient: Her istek (request) için yeni bir nesne oluþturur.

            builder.Services.AddScoped<IProductService, ProductService>();
            //AddScoped HTTP isteði boyunca.

            //builder.Services.AddSingleton<IProductService, ProductService>();
            //Uygulama boyunca

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}