using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme2_AspNetCore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //mvc mimarisini kullanabilmek için uygulamaya controller ve view eklendi.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //pipelinedaki routing kýsmý. gelen isteðin rotasý bu middleware sayesinde belirlenir.

            app.UseEndpoints(endpoints => //yapýlan isteðin varýþ noktasý yani url/istek adresi.
                                         //  bu uygulamaya gelen isteklerin hangi rotalar eþliðinde gelebileceði buradan belirlenir.
            {
              //  endpoints.MapGet("/", async context =>
               // {
               //      await context.Response.WriteAsync("Hello World!");
               // });
                    endpoints.MapDefaultControllerRoute(); // {controller=Home}/{action=Index}/{id?} --> default olan endpoint þemasý, bu þemaya uyalacak.
            });
        }
    }
}
