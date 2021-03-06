﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZHCG.Core.Log;

namespace ZHCG.Core
{
    public class CoreStartup
    {
        public CoreStartup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEnyimMemcached(options => Configuration.GetSection("enyimMemcached").Bind(options));
            //services.AddEnyimMemcached(options =>
            //{
            //    options.AddServer("172.0.0.1", 11211);
            //    //options.AddPlainTextAuthenticator("", "usename", "password");
            //});
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseEnyimMemcached();
        }
    }
}
