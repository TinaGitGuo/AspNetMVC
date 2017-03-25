using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AspnetCorea.Controllers;
using Microsoft.AspNetCore.Http;

namespace AspnetCorea
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        //public class Controller1
        //{
        //    public readonly MySubOptions  _options;

        //    public Controller(IOptionsSnapshot<MySubOptions> options)
        //    {
        //        _options = options.Value;
        //    }

        //    public Task DisplayTimeAsync(HttpContext context)
        //    {
        //        return context.Response.WriteAsync(_options.Message + _options.CreationTime);
        //    }
        //}
        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            //services.AddScoped<MySubOptions>();
            // Register the IConfiguration instance which MyOptions binds against.
            services.Configure<MyOptions>(Configuration);
            services.Configure<MySubOptions>(Configuration.GetSection("subsection"));
            // Add framework services.
            services.AddMvc();
        }
        //public Task DisplayTimeAsync(HttpContext context)
        //{
        //    context.Response.ContentType = "text/plain";
        //    return context.RequestServices.GetRequiredService<Controller>().DisplayTimeAsync(context);
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
