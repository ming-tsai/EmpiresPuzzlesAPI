using System.Collections.Generic;
using EmpiresPuzzles.API.GraphQL;
using EmpiresPuzzles.API.GraphQL.Queries;
using EmpiresPuzzles.API.GraphQL.Types;
using EmpiresPuzzles.API.Implementations.Services;
using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Migrations;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Npgsql;

namespace EmpiresPuzzles.API
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

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Empires & Puzzles API", Version = "v1" });
            });

            services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationContext>(
                options => options.UseNpgsql(new NpgsqlConnection(Configuration.GetConnectionString("PostgreSQL")))
            );

            services.AddTransient<IHeroService, HeroService>();

            // GraphQL
            
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<ISchema, RootSchema>();
            services.AddSingleton<HeroType>();
            services.AddSingleton<HeroSpeedType>();
            services.AddScoped<HeroQuery>();
            services.AddTransient<IDocumentExecuter, DocumentExecuter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseDefaultFiles();
            app.UseStaticFiles();

            // GraphQL UI
            app.UseGraphiQl();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
            });
            
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
