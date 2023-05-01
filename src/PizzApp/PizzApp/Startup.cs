using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Microsoft.Extensions.Hosting;
using PizzApp.Areas.Admin.Servicos;
using PizzApp.Context;
using PizzApp.Models;
using PizzApp.Repositories;
using PizzApp.Repositories.Interfaces;
using PizzApp.Services;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzApp
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
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/Home/AcessDenied");
            services.Configure<ConfigurationImagens>(Configuration.GetSection("ConfigurationPastaImagens"));

            services.Configure<IdentityOptions>(options =>
            {
                //Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });

            services.AddTransient<IPizzaRepository, PizzaRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();

            services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();
            services.AddScoped<RelatorioVendasService>();
            services.AddScoped<GraficoVendasService>();
            
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin",
                    politica =>
                    {
                        politica.RequireRole("Admin");
                    });
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

            services.AddControllersWithViews();

            services.AddPaging(optins =>
            {
                optins.ViewName = "Bootstrap4";
                optins.PageParameterName = "pageindex";
            });

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ISeedUserRoleInitial seedUserRoleInitial)
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

            //cria os perfis
            seedUserRoleInitial.SeedRoles();
            //cria os usuários e atribui ao perfil
            seedUserRoleInitial.SeedUsers();

            app.UseSession();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                       name: "areas",
                       pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
                     );

                endpoints.MapControllerRoute(
                    name: "categoriaFiltro",
                    pattern: "Pizza/{action}/{categoria?}",
                    defaults: new { controller = "Pizza", Action = "List" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}