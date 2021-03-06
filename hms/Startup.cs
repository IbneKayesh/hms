using hms.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor;
using hms.DataAccess.Repository.IRepository;
using hms.DataAccess.Repository;
using System;

namespace hms
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<hmsDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRawSql, RawSql>();
            //services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    options.AreaViewLocationFormats.Clear();
            //    options.AreaViewLocationFormats.Add("/Setup/{2}/Views/{1}/{0}.cshtml");
            //    options.AreaViewLocationFormats.Add("/Setup/{2}/Views/Shared/{0}.cshtml");
            //    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            //});

            //services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".hmsApps.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddSessionStateTempDataProvider();
            services.AddRazorPages().AddSessionStateTempDataProvider();

            services.AddMvc(options => { options.Filters.Add(new Microsoft.AspNetCore.Mvc.AutoValidateAntiforgeryTokenAttribute()); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapAreaControllerRoute(name: "areas", "areas", pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(
                            name: "HospitalArea",
                            areaName: "Hospital",
                            pattern: "Hospital/{controller=Home}/{action=Index}");

                endpoints.MapAreaControllerRoute(
                            name: "OutdoorArea",
                            areaName: "Outdoor",
                            pattern: "Outdoor/{controller=Home}/{action=Index}");

                endpoints.MapAreaControllerRoute(
                          name: "SetupArea",
                          areaName: "Setup",
                          pattern: "Setup/{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                        name: "default",
                        //pattern: "{controller=Home}/{action=Index}/{id?}");
                        pattern: "{controller=Home}/{action=Login}/{id?}");

                endpoints.MapRazorPages();
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //      name: "areas",
            //      pattern: "{area:exists}/{controller=User}/{action=Index}/{id?}"
            //    );
            //});
        }
    }
}
