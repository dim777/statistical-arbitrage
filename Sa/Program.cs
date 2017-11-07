using System;
using NLog;

namespace Sa
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        static void Main(string[] args)
        {
            logger.Info("Starting app . . . ");
        }
    }
}