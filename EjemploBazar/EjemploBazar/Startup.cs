using EjemploBazar;
using Microsoft.EntityFrameworkCore;
using System;

namespace EjemploBazar
{
    public class Startup
    {
        public IConfiguration Configuration { get; }



        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }



        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                var frontendURL = Configuration.GetValue<string>("frontend_url");
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
                });
            });
            services.AddControllers();
        }




        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {

        }
    }
}
