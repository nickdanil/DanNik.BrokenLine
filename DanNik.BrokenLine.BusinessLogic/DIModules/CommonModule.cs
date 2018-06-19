using DanNik.BrokenLine.BusinessLogic.Handlers.BrokenLine;
using DanNik.BrokenLine.Common;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace DanNik.BrokenLine.BusinessLogic.DIModules
{
	/// <summary>
	/// Функционал настройки общего модуля DI, который будет использоваться вне зависимости от платформы 
	/// </summary>
    public class CommonModule: IDIModule
    {
		protected AmbientContext Context { get; set; }

		public CommonModule(bool isBuildServiceProvider = true)
		{
			Context = AmbientContext.Current;
			Configure();

			if(isBuildServiceProvider){ Context.BuildServiceProvider(); }
		}

		private void Configure()
		{
			Context.Services.AddTransient<GetBrokenLineLengthHandler, GetBrokenLineLengthHandler>();
		}

		private void ConfigureLogger()
		{
			Log.Logger = new LoggerConfiguration()
				.CreateLogger()
				;

			Context.Services.AddSingleton<ILogger>(Log.Logger);
		}
    }
}
