using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Models;
using eProdaja.Services;
using eProdaja.WebAPI.Filters;
using eProdaja.Model.Requests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.Authentication;
using eProdaja.WebAPI.Security;
using eProdaja.WebAPI.Services;
using Newtonsoft.Json;

namespace eProdaja
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
            services.AddControllers();
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddMvc(x => x.EnableEndpointRouting = false)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            // komanda za instalaciju
            //Install-Package Swashbuckle.AspNetCore -Version 5.0.0
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eProdaja API", Version = "v1" });

                // basic auth swagger

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            // auto mapper

            services.AddAutoMapper(typeof(Startup));

            // skripta za kreiranje klasa iz baze
            //Scaffold - DbContext 'Data Source=.;Initial Catalog=eProdaja; Integrated Security = true;' Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models
            var connection = Configuration.GetConnectionString("eProdaja");
            services.AddDbContext<eProdajaContext>(options => options.UseSqlServer(connection));

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            //dependency injection

            services.AddScoped<IKorisniciService, KorisniciService>();

            services.AddScoped<IKorisniciUlogeService, KorisniciUlogeService>();

            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloge>>();

            services.AddScoped<IService<Model.VrsteProizvoda, object>, BaseService<Model.VrsteProizvoda, object, VrsteProizvoda>>();

            services.AddScoped<IService<Model.JediniceMjere, object>, BaseService<Model.JediniceMjere, object, JediniceMjere>>();

            services.AddScoped<ICRUDService<Model.Proizvod, ProizvodiSearchRequest, ProizvodiInsertRequest, ProizvodUpdateRequest>
                ,ProizvodService>();
            
            //services.AddScoped<ICRUDService<Model.Korisnici, KorisniciSearchRequest, KorisniciInsertRequest, KorisniciUpdateRequest>
            //    ,KorisniciService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // swagger

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
