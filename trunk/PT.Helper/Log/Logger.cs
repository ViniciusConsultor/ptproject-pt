using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;
using System.Reflection;

namespace PT.Log
{
    public class Logger
    {
        private const string FRAMEWORK_LOGGER = "FrameworkLogger";
        private static readonly ILog frameworkLogger;

        public static bool IsDebugEnabled
        {
            get
            {
                return frameworkLogger.IsDebugEnabled;
            }
        }

        public static bool IsErrorEnabled
        {
            get
            {
                return frameworkLogger.IsErrorEnabled;
            }
        }

        public static bool IsFatalEnabled
        {
            get
            {
                return frameworkLogger.IsFatalEnabled;
            }
        }

        public static bool IsInfoEnabled
        {
            get
            {
                return frameworkLogger.IsInfoEnabled;
            }
        }

        public static bool IsWarnEnabled
        {
            get
            {
                return frameworkLogger.IsWarnEnabled;
            }
        }

        static Logger()
        {
            XmlConfigurator.Configure();
            frameworkLogger = LogManager.GetLogger("FrameworkLogger");
        }

        public static void Debug(object message)
        {
            frameworkLogger.Debug(message);
        }

        public static void Debug(object message, Exception ex)
        {
            frameworkLogger.Debug(message, ex);
        }

        public static void Error(object message)
        {
            frameworkLogger.Error(message);
        }

        public static void Error(object message, Exception ex)
        {
            frameworkLogger.Error(message, ex);
        }

        public static void Fatal(object message)
        {
            frameworkLogger.Fatal(message);
        }

        public static void Fatal(object message, Exception ex)
        {
            frameworkLogger.Fatal(message, ex);
        }

        public static ILog GetLogger(string name)
        {
            return LogManager.GetLogger(name);
        }

        public static ILog GetLogger(Type type)
        {
            return LogManager.GetLogger(type);
        }

        public static ILog GetLogger(Assembly assembly, string name)
        {
            return LogManager.GetLogger(assembly, name);
        }

        public static ILog GetLogger(Assembly assembly, Type type)
        {
            return LogManager.GetLogger(assembly, type);
        }

        public static ILog GetLogger(string repository, string name)
        {
            return LogManager.GetLogger(repository, name);
        }

        public static ILog GetLogger(string repository, Type type)
        {
            return LogManager.GetLogger(repository, type);
        }

        public static void Info(object message)
        {
            frameworkLogger.Info(message);
        }

        public static void Info(object message, Exception ex)
        {
            frameworkLogger.Info(message, ex);
        }

        public static void Warn(object message)
        {
            frameworkLogger.Warn(message);
        }

        public static void Warn(object message, Exception ex)
        {
            frameworkLogger.Warn(message, ex);
        }
    }
}
