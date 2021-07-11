using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace AngularCEF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles (configuration => {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddControllersWithViews ();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            // app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            if (!env.IsDevelopment ()) {
                app.UseSpaStaticFiles ();
            }
            app.UseRouting ();
            app.UseEndpoints (endpoints => {
                endpoints.MapControllerRoute (
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
            app.UseSpa (spa => {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment ()) {
                    // spa.UseAngularCliServer (npmScript: "start"); // IE 11
                    // spa.UseAngularCliServer (npmScript: "start-es6");
                    // spa.Options.StartupTimeout = TimeSpan.FromSeconds (120); // Increase the timeout if angular app is taking longer to startup

                    spa.UseProxyToSpaDevelopmentServer ("http://localhost:4200"); // Use this instead to use the angular cli server
                }
                else
                {
                    Console.WriteLine("");
                }
                if (env.IsEnvironment ("docker")) {
                    spa.UseProxyToSpaDevelopmentServer ("http://ultra_hd_ui:4200"); // Use this instead to use the angular cli server
                }
            });
        }
    }
}