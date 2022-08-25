using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using UrbanZoo.Models;
using UrbanZoo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;

namespace UrbanZoo
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

            services.AddDbContext<UrbanZooContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            
            services.AddHttpContextAccessor();
            
            services.AddSingleton<IUriService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(uri);
            });
            
            services.AddControllers();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "UrbanZoo", 
                    Version = "v1",
                    Description = "An ASP.NET Core Web API for UrbanZoo",
                    Contact = new OpenApiContact
                    {
                        Name = "Zhibin Liang",
                        Email = "ifthereisoneday@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/zhibin-liang"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "No license requied"
                    }
                });
                c.SwaggerDoc("v2", new OpenApiInfo
                {
                    Title = "UrbanZoo", 
                    Version = "v2",
                    Description = "An ASP.NET Core Web API for UrbanZoo",
                    Contact = new OpenApiContact
                    {
                        Name = "Zhibin Liang",
                        Email = "ifthereisoneday@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/zhibin-liang"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "No license requied"
                    }
                });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());            
            });

            services.AddApiVersioning(opt =>
            {
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ReportApiVersions = true;
                opt.ApiVersionReader = ApiVersionReader.Combine(
                    new HeaderApiVersionReader("X-Api-Version"),
                    new QueryStringApiVersionReader("version"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {          
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger(c => 
            {
                c.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "UrbanZoo v1");
                c.RoutePrefix = string.Empty;
            });

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}