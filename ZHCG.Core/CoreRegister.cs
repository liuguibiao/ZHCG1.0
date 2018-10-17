using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ZHCG.Core.Log;

namespace ZHCG.Core
{
    public class CoreRegister
    {
        public void DIRegister(IServiceCollection services)
        {
            //配置依赖注入映射关系
            services.AddTransient(typeof(ILog4NetServer), typeof(Log4NetServer));
            //注册Core层的依赖注入
            //CoreRegister sdr = new CoreRegister();
            //sdr.DIRegister(services);
        }
    }
}
