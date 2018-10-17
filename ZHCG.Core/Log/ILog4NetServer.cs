using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZHCG.Core.Log
{
    public interface ILog4NetServer
    {
        ILog Log { get; }
    }
}
