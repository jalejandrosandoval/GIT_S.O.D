using API.Data;
using API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

namespace API
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

            // Migrations DBContext 

            services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DevConection")));

            // CORS

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                     builder =>
                     {
                         builder.AllowAnyHeader()
                         .AllowAnyMethod()
                         .AllowAnyOrigin()
                         ;
                     });
            });
            
            services.AddControllersWithViews()
               .AddNewtonsoftJson(options =>
                   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            //Using to Identity
            
            /*services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDBContext>()
                .AddDefaultTokenProviders();
                */
            //JWT

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey
                            (Encoding.UTF8.GetBytes(Configuration["Key"])),
                        ClockSkew = TimeSpan.Zero

                    }
                ) ;

            //Configuration the Swagger Docs

            services.AddSwaggerGen(config =>
              config.SwaggerDoc("V1.0", new OpenApiInfo
              {
                  Title = "PetManAPP - API V1.0",
                  Version = "V1.0",
                  Description = "PetManAPP APP - WEB API"
              })
              );

            services.AddControllers();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Autentication 

            //app.UseAuthentication(); 

            //SWAGGER
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/V1.0/swagger.json", "PetManAPP - API V1.0");
            });

            // CORS

            app.UseCors("AllowSpecificOrigin");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
