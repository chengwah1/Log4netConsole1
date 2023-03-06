using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;

namespace Log4netConsole1
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));
        private static readonly Guid _requestId = Guid.NewGuid();
        static void Main(string[] args)
        {
            log4net.ThreadContext.Properties["RequestId"] = _requestId;

            // Use log4net to log a message
            _log.Info("Hello, world!");
            _log.Info("Hello logging world!");

            Console.WriteLine("Hello, World!");
        }
    }
}
