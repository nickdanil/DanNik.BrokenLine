using DanNik.BrokenLine.Common;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace DanNik.BrokenLine.BusinessLogic.DIModules
{
	/// <summary>
	/// Функционал настройки общего модуля DI, который будет использоваться в консольных приложениях
	/// </summary>
    public class ConsoleAppModule: CommonModule, IDIModule
    {
		public ConsoleAppModule(): base(false)
		{ 
			Configure();
			ConfigureLogger();
			Context.BuildServiceProvider();
		}

		private void Configure()
		{
			//Context.Services.AddSingleton<, >();
		}

		private void ConfigureLogger()
		{
			Log.Logger = new LoggerConfiguration()
				.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
				.CreateLogger()
				;

			Context.Services.AddSingleton<ILogger>(Log.Logger);
		}
    }
}
