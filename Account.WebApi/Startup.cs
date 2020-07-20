using System;
using Account.Data;
using Account.Data.Repositories;
using Account.Services.Interfaces;
using Account.Services.Services;
<<<<<<< HEAD
=======
using AutoMapper;
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
<<<<<<< HEAD
using AutoMapper;
=======
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4

namespace Account.WebApi
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
            services.AddDbContext<AccountContext>
<<<<<<< HEAD
            (options => options.UseSqlServer(Configuration.GetConnectionString("AccountContext")));
            services.AddScoped<ILoginServies, LoginServies>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IAccountInfoServies, AccountInfoServies>();
            services.AddScoped<IAccountInfoReposetory, AccountInfoReposetory>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

=======
            (options => options.UseSqlServer(Configuration.GetConnectionString("AccountDB")));
            services.AddScoped<INewAccountService, NewAccountService>();
            services.AddScoped<INewAccountRepository, NewAccountRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc(
                    "AccountOpenAPI",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "Account API",
                        Version = "1"
                    });
            });
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint(
                    "/swagger/AccountOpenAPI/swagger.json",
                    "Account API");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });



      

          


        }
    }
}
