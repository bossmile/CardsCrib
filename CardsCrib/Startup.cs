using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CardsCrib.DAL;
using Microsoft.EntityFrameworkCore;

namespace CardsCrib
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
			services.AddMvc();

			var con = "Data Source=DESKTOP-NCHQR4I;Initial Catalog=CardsCrib;Persist Security Info=True;User ID=sa;Password=Mi1eRu1z12sa";
			//var con = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
			services.AddDbContext<CardsCribContext>(options => options.UseSqlServer(con));

			//services.AddAuthentication(sharedOptions =>
			//{
			//    sharedOptions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			//})
			//.AddAzureAdB2CBearer(options => Configuration.Bind("AzureAdB2C", options));

			// Add framework services.  
			//services.AddDbContext<CardsCribContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("CardsCrib")));

			
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
        }
	}
}
