using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;

namespace SDA.Common.Configuration.Extensions
{
    public static class HostBuilderExtensions
    {
        /// <summary>
        /// Configures Serilog for the specified <see cref="ConfigureHostBuilder"/> instance.
        /// </summary>
        /// <param name="host">The <see cref="ConfigureHostBuilder"/> instance to configure.</param>
        /// <param name="connectionString">The connection string for the SQL Server database.</param>
        /// <returns>The configured <see cref="ConfigureHostBuilder"/> instance.</returns>
        /// <remarks>
        /// This sets up Serilog to log to the console and to a SQL Server database.
        /// </remarks>
        public static ConfigureHostBuilder ConfigureSerilog(
            this ConfigureHostBuilder host,
            string connectionString
        )
        {
            ArgumentException.ThrowIfNullOrEmpty(connectionString, nameof(connectionString));
            host.UseSerilog(
                (context, services, loggerConfiguration) =>
                    loggerConfiguration
                        .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
                        .WriteTo.MSSqlServer(
                            connectionString: connectionString,
                            sinkOptions: new MSSqlServerSinkOptions
                            {
                                TableName = "Logs",
                                AutoCreateSqlTable = true,
                                SchemaName = "audit",
                            },
                            columnOptions: GenerateSqlColumnOptions(),
                            restrictedToMinimumLevel: LogEventLevel.Error
                        )
            );

            return host;
        }

        private static ColumnOptions GenerateSqlColumnOptions()
        {
            var columnOptions = new ColumnOptions();
            columnOptions.Store.Remove(StandardColumn.Properties);
            columnOptions.Store.Add(StandardColumn.LogEvent);
            columnOptions.Store.Add(StandardColumn.Message);
            columnOptions.Store.Add(StandardColumn.Exception);
            columnOptions.Store.Add(StandardColumn.Level);
            columnOptions.Store.Add(StandardColumn.TimeStamp);

            columnOptions.Message = new ColumnOptions.MessageColumnOptions
            {
                NonClusteredIndex = false,
                DataLength = -1,
            };

            columnOptions.Exception = new ColumnOptions.ExceptionColumnOptions { DataLength = -1 };

            return columnOptions;
        }
    }
}
