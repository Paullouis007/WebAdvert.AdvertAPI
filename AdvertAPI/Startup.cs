using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertAPI.HealthChecks;
using AdvertAPI.Services;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AdvertAPI
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

            services.AddAutoMapper();
            services.AddTransient<IAdvertStorageService, DynamoDBAdvertStoragecs>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddHealthChecks(checks => {
            //    checks.AddCheck<StorageHealthCheck>("Storage", new System.TimeSpan(0, 1, 0));
            //});
            services.AddHealthChecks().AddCheck<StorageHealthCheck>("example_health_check");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHealthChecks("/health");
            app.UseMvc();
        }
    }
}
