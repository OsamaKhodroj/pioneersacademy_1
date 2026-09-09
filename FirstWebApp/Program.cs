using FirstWebApp.Middlewares;

namespace FirstWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.Environment.IsDevelopment();
            app.Environment.IsStaging();
            app.Environment.IsProduction(); 


            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();


            app.Use(async (context, next) =>
            {
                // Logic before the request hits the endpoint
                Console.WriteLine($"Before endpoint: {context.Request.Path}");

                await next(context); // Pass control forward

                // Logic after the endpoint executes
                Console.WriteLine($"After endpoint execution");
            });



            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
