using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enyim.Caching;
using Microsoft.AspNetCore.Mvc;
using ZHCG.Core.Log;
using ZHCG.Data;

namespace ZHCG.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILog4NetServer _log4NetServer;
        private readonly ZHCGContext _context;
        private IMemcachedClient _memcachedClient;
        //static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public ValuesController(ZHCGContext context, ILog4NetServer log4NetServer, IMemcachedClient memcachedClient)
        {
            _context = context;
            _log4NetServer = log4NetServer;
            _memcachedClient = memcachedClient;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Logger.Default.Trace("Hello World! Trace");
            Logger.Default.Info("Hello World! Info");
            Logger.Default.Warn("Hello World! Warn");
            Logger.Default.Debug("Hello World! Debug");
            Logger.Default.Error("Hello World! Error");
            Logger.Default.Fatal("Hello World! Fatal");

            Logger.Default.Process(new ZHCG.Data.Entity.Logs("Info", "Hello World! Info", "TEST", "100.00"));
            Logger.Default.Process(new ZHCG.Data.Entity.Logs("Debug", "Hello World! Debug", "TEST", "100.00"));
            Logger.Default.Process(new ZHCG.Data.Entity.Logs("Error", "Hello World! Error", "TEST", "100.00"));
            Logger.Default.Flush();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
