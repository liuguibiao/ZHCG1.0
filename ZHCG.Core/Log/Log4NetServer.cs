using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZHCG.Core.Log
{
    public class Log4NetServer : ILog4NetServer
    {
        private static ILoggerRepository repository;
        public Log4NetServer()
        {
            if (repository == null)
                repository = LogManager.CreateRepository("NETCoreRepository");
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));            
        }
        public ILog Log
        {
            get
            {
                return LogManager.GetLogger(repository.Name, "NETCorelog4net");
            }
        }
    }
}
