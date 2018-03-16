using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.GenericUtil.GenericHelper
{
    public class Loghelper
    {
        private static ILog _Logger;
        private static ConsoleAppender _consoleAppender;
        private static FileAppender _fileAppender;
        private static RollingFileAppender _rollingFileAppender;
        //private static string layout= "%date{ABSOLUTE} [%class] [%level] [%method] - %message%newline";
        private static string layout = "%date{ABSOLUTE} [%level] - %message%newline";
        public static string appender;

        private static PatternLayout GetPatternLayout()
        {
            var patternLayout = new PatternLayout()
            {
                ConversionPattern = layout
            };
            patternLayout.ActivateOptions();
            return patternLayout;
        }

        private static ConsoleAppender GetconsoleAppender()
        {
            var consoleAppender = new ConsoleAppender()
            {
                Name = "ConsoleAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All
            };
            consoleAppender.ActivateOptions();
            return consoleAppender;
        }

        private static FileAppender GetFileAppender()
        {
            var fileAppender = new FileAppender()
            {
                Name = "FileAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All,
                AppendToFile = true,
                File = @"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\Log Files\FileLogger.log",
            };
            fileAppender.ActivateOptions();
            return fileAppender;
        }

        //private static RollingFileAppender GetRollingFileAppender()
        //{
        //    var rollingAppender = new RollingFileAppender()
        //    {
        //        Name="Rolling File Appender",
        //        AppendToFile=true,
        //        File= @"E:\ThomasPublishing\ThomasProject\ThomasProject\ThomasNetProject\ThomasNetProject\Log Files\RollingFile.log",
        //        Layout=GetPatternLayout(),
        //        Threshold=Level.All,
        //        MaximumFileSize="1MB",
        //        MaxSizeRollBackups=15
        //    };
        //    rollingAppender.ActivateOptions();
        //    return rollingAppender;
        //}


        public static ILog GetLog(Type type)
        {
            if (_consoleAppender == null && appender.Contains("ConsoleAppender"))
            {
                _consoleAppender = GetconsoleAppender();
            }
            else
            if (_fileAppender == null && appender.Contains("FileAppender"))
            {
                _fileAppender = GetFileAppender();
            }
            if (_Logger != null)
            {
                return _Logger;
            }


            BasicConfigurator.Configure(_consoleAppender);
            _Logger = LogManager.GetLogger((type));
            return _Logger;
        }

    }
}
