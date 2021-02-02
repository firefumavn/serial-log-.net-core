using System.Diagnostics;
using ApplicationCore.Interfaces;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace ApplicationCore.Logger
{
    public class LoggerAdapter: ILoggerAdapter
    {
        private static IConfiguration _configuration;
        public static IConfiguration Configuration
        {
            set
            {
                if (_configuration == null)
                {
                    _configuration = value;
                }
            }
        }
        /// <summary>
        /// Debug
        /// </summary>
        /// <param name="messageTemplate"></param>
        public void Debug(string messageTemplate)
        {
            Log.Debug(messageTemplate);
        }
        /// <summary>
        /// Debug
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        public void Debug<T>(string messageTemplate, T propertyValue)
        {
            Log.Debug<T>(messageTemplate, propertyValue);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="messageTemplate"></param>
        public void Error(string messageTemplate)
        {
            Log.Error(messageTemplate);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        public void Error<T>(string messageTemplate, T propertyValue)
        {
            Log.Error<T>(messageTemplate, propertyValue);
        }

        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="messageTemplate"></param>
        public void Fatal(string messageTemplate)
        {
            Log.Fatal(messageTemplate);
        }

        /// <summary>
        /// Fatal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        public void Fatal<T>(string messageTemplate, T propertyValue)
        {
            Log.Fatal<T>(messageTemplate, propertyValue);
        }

        /// <summary>
        /// Information
        /// </summary>
        /// <param name="messageTemplate"></param>
        public void Information(string messageTemplate)
        {
            Log.Information(messageTemplate);
        }

        /// <summary>
        /// Information
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        public void Information<T>(string messageTemplate, T propertyValue)
        {
            Log.Information<T>(messageTemplate, propertyValue);
        }

        /// <summary>
        /// Warning
        /// </summary>
        /// <param name="messageTemplate"></param>
        public void Warning(string messageTemplate)
        {
            Log.Warning(messageTemplate);
        }

        /// <summary>
        /// Warning
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        public void Warning<T>(string messageTemplate, T propertyValue)
        {
            Log.Warning<T>(messageTemplate, propertyValue);
        }

        /// <summary>
        /// WriteMethodInfo
        /// </summary>
        /// <param name="parameters"></param>
        public void WriteMethodInfo(params object[] parameters)
        {
            var parentMethod = new StackTrace().GetFrame(1).GetMethod();
            var paramNum = 1;

            Log.Information(parentMethod.DeclaringType.FullName + (".") + parentMethod.Name);
            Log.Information("(");
            foreach (var param in parameters)
            {
                if (param != null)
                {
                    Log.Information("Param_" + paramNum + " As Type " + param.GetType().Name.Split("`")[0] + ": {@" + param.GetType().Name.Split("`")[0].Replace("[]", string.Empty) + "}", param == null ? "null" : param);
                }
                paramNum += 1;
            }

            Log.Information(")");
        }
    }
}
