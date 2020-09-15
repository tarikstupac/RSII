using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Stripe;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.SwaggerGen;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Database;
using VGFeed.WebAPI.Filters;
using VGFeed.WebAPI.Security;
using VGFeed.WebAPI.Services;

namespace VGFeed.WebAPI
{
    public class BasicAuthOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var filter = new SecurityRequirementsOperationFilter(securitySchemaName: BasicAuthenticationOptions.DefaultScheme);
            filter.Apply(operation, context);
        }
    }
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            StripeConfiguration.ApiKey = Configuration.GetSection("Stripe")["SecretKey"];
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x=> x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition(BasicAuthenticationOptions.DefaultScheme, new OpenApiSecurityScheme
                {
                    Name= BasicAuthenticationHandler.BasicHeaderName,
                    In= ParameterLocation.Header,
                    Scheme="basic",
                    Type = SecuritySchemeType.Http                   
                });
                c.OperationFilter <BasicAuthOperationFilter> ();

            });
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<BasicAuthenticationOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddScoped<IKorisniciService,KorisniciService>();
            services.AddScoped<ICRUDService<Model.Igre, IgreSearchRequest, IgreInsertRequest, IgreInsertRequest>, IgreService>();
            services.AddScoped<IService<Model.Drzave, object>, BaseService<Model.Drzave, object, Database.Drzave>>();
            services.AddScoped<ICRUDService<Model.Zanrovi, object, ZanroviInsertRequest, ZanroviInsertRequest>, BaseCRUDService<Model.Zanrovi, object, Database.Zanrovi, ZanroviInsertRequest, ZanroviInsertRequest>>();
            services.AddScoped<ICRUDService<Model.Platforme, object, PlatformeInsertRequest,PlatformeInsertRequest>, BaseCRUDService<Model.Platforme, object, Database.Platforme, PlatformeInsertRequest, PlatformeInsertRequest>>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloge>>();
            services.AddScoped<ICRUDService<Model.Store,object, StoreInsertRequest, StoreInsertRequest>, BaseCRUDService<Model.Store, object, Database.Store, StoreInsertRequest, StoreInsertRequest>>();
            services.AddScoped<ICRUDService<Model.Sale, SaleSearchRequest, SaleInsertRequest, SaleInsertRequest>, SaleService>();
            services.AddScoped<IService<Model.SaleDetalji,SaleDetaljiSearchRequest >, SaleDetaljiService>();
            services.AddScoped<ICRUDService<Model.KorisnikIgre, KorisnikIgreSearchRequest, KorisnikIgreInsertRequest, KorisnikIgreInsertRequest>, KorisnikIgreService>();
            services.AddScoped<ICRUDService<Model.KorisnikSocials, KorisnikSocialsSearchRequest, KorisnikSocialsInsertRequest, KorisnikSocialsInsertRequest>, KorisnikSocialsService>();
            services.AddScoped<IRecommendService<Model.Igre>,RecommendIgreService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPorukeService, PorukeService>();
            services.AddScoped<IRecommendService<Model.Korisnici>, RecommendKorisnikeService>();

            var connection = Configuration.GetConnectionString("VGFeed");
            services.AddDbContext<_3123Context>(options => options.UseSqlServer(connection));
            services.AddAutoMapper(typeof(Mappers.Mapper));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
