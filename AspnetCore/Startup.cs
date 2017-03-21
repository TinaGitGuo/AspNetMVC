using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AspnetCore.Data;
using AspnetCore.Models;
using AspnetCore.Services;

namespace AspnetCore
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public static IConfigurationRoot Configuration { get; set; }
        //public IConfigurationRoot Configuration { get; }
        public static string connectionString = "US";
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {     // Add framework services.
           

            services.AddTransient(provider =>
            {
                
                connectionString = Configuration["ConnectionStrings:MyEntities" + connectionString];
                return GetStr.getss (Configuration["ConnectionStrings:MyEntities" + connectionString]);
            });

            services.AddIdentity<ApplicationUser, IdentityRole>( config =>
            {
                config.User.RequireUniqueEmail = true;
                config.Password.RequiredLength = 8;
                config.Cookies.ApplicationCookie.LoginPath = "/Account/Login";

            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
               ;
 services.AddDbContext<ApplicationDbContext>(options =>

                options.UseSqlServer(Configuration["DefaultConnection"]));

         

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            // Configure Identity
            //services.Configure<IdentityOptions>(options =>
            //{
            //    // Password settings
            //    options.Password.RequireDigit = true;
            //    options.Password.RequiredLength = 8;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = true;
            //    options.Password.RequireLowercase = false;

            //    // Lockout settings
            //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
            //    options.Lockout.MaxFailedAccessAttempts = 10;
            //    options.Lockout.AllowedForNewUsers = true;

            //    // Cookie settings
            //    options.Cookies.ApplicationCookie.CookieName = "YouAppCookieName";
            //    options.Cookies.ApplicationCookie.ExpireTimeSpan = TimeSpan.FromDays(150);
            //    options.Cookies.ApplicationCookie.LoginPath = "/Account/LogIn";
            //    options.Cookies.ApplicationCookie.LogoutPath = "/Account/LogOff";
            //    options.Cookies.ApplicationCookie.AccessDeniedPath = "/Account/AccessDenied";
            //    options.Cookies.ApplicationCookie.AutomaticAuthenticate = true;
            //    options.Cookies.ApplicationCookie.AuthenticationScheme = Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme;
            //});
            //    services.AddMvc();



            //// Add application services.
            //services.AddTransient<IEmailSender, AuthMessageSender>();
            //services.AddTransient<ISmsSender, AuthMessageSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,ApplicationDbContext context)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseIdentity();

            // Add external authentication middleware below. To configure them please see http://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Core0321}/{action=Index}/{id?}");
            });
            DbInitializer.Initialize(context);
        }
    }
}
