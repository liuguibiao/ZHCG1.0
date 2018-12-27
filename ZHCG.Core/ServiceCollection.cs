using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZHCG.Core
{
    public class ServiceCollection
    {
        private IConfiguration Configuration { get; }
        private IServiceCollection Services { get; }
        private IApplicationBuilder App { get; }
        public ServiceCollection(IConfiguration configuration, IServiceCollection services, IApplicationBuilder app)
        {
            Configuration = configuration;
            Services = services;
            App = app;
        }

        public void Run()
        {
            Services.AddEnyimMemcached(options => Configuration.GetSection("enyimMemcached").Bind(options));
            //Services.AddEnyimMemcached(options =>
            //{
            //    //options.AddServer("memcached", 11211);
            //    //options.AddPlainTextAuthenticator("", "usename", "password");
            //});
        }
    }
}
