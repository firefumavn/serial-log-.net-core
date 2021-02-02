using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ApplicationCore.Configurations
{
    public static class LoggerConfiguration
    {
		public static ILoggerFactory AddLoggerFactory(this ILoggerFactory loggerFactory)
		{
			loggerFactory.AddSerilog();

			return loggerFactory;
		}

		public static void CreateLogger(this IConfiguration configuration)
		{
			Log.Logger = new Serilog.LoggerConfiguration()
				.ReadFrom.Configuration(configuration)
				//.WriteTo.File("D:\\Logs\\Log2-{DateTime.Now:yyyy-MM-dd}.txt", shared: true, fileSizeLimitBytes: 3000, rollOnFileSizeLimit: true, flushToDiskInterval: TimeSpan.FromSeconds(1))
				.CreateLogger();
		}
	}
}
