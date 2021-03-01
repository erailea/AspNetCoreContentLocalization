


using System.Collections.Generic;
using System.Globalization;
using AspNetCoreContentLocalization.Data;
using AspNetCoreContentLocalization.Data.Repositories.Abstractions;
using AspNetCoreContentLocalization.Data.Repositories.Defaults;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreContentLocalization
{
    public class Startup
    {
        private IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<Storage>(
                options => options.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"))
            );


            services.AddScoped<ICultureRepository, CultureRepository>();
            services.AddScoped<ILocalizationSetRepository, LocalizationSetRepository>();
            services.AddScoped<ILocalizationRepository, LocalizationRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ILocalizedBookRepository, LocalizedBookRepository>();


            services.AddScoped<ILibraryRepository, LibraryRepository>();
            services.AddScoped<ILocalizedLibraryRepository, LocalizedLibraryRepository>();

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc(x => x.EnableEndpointRouting = false).AddViewLocalization().AddDataAnnotationsLocalization();

        }

        public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment)
        {
            if (hostingEnvironment.IsDevelopment())
            {
                applicationBuilder.UseDeveloperExceptionPage();
            }

            CultureInfo[] supportedCultures = new[] { new CultureInfo("tr"), new CultureInfo("de"), new CultureInfo("en") };

            applicationBuilder.UseRequestLocalization(
              new RequestLocalizationOptions()
              {
                  DefaultRequestCulture = new RequestCulture("tr"),
                  SupportedCultures = supportedCultures,
                  SupportedUICultures = supportedCultures
              }
            );

            applicationBuilder.UseStaticFiles();
            applicationBuilder.UseMvc(routeBuilder =>
              {
                  routeBuilder.MapRoute("Create", "{controller=Books}/add", new { action = "AddOrEdit" });
                  routeBuilder.MapRoute("Update", "{controller=Books}/edit/{id?}", new { action = "AddOrEdit" });
                  routeBuilder.MapRoute("Default", "{controller=Books}/{action=Index}/{id?}");

                  routeBuilder.MapRoute("CreateL", "{controller=Librarys}/add", new { action = "AddOrEdit" });
                  routeBuilder.MapRoute("UpdateL", "{controller=Librarys}/edit/{id?}", new { action = "AddOrEdit" });
                  routeBuilder.MapRoute("DefaultL", "{controller=Librarys}/{action=Index}/{id?}");
              }
            );
        }
    }
}
