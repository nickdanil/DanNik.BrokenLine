using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;

namespace DanNik.BrokenLine.Common
{
	/// <summary>
	/// Потокобезопасная реализация паттерна AmbientContext
	/// </summary>
	public sealed class AmbientContext
	{
		private static readonly AmbientContext instance = new AmbientContext();

		public readonly ServiceCollection Services;
		public IServiceProvider ServiceProvider { get ; protected set; }

		public ILogger Log => ServiceProvider.GetService<ILogger>();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static AmbientContext()
		{
		}

		private AmbientContext()
		{
			Services = new ServiceCollection();			
		}

		public static AmbientContext Current
		{
			get
			{
				return instance;
			}
		}

		public void BuildServiceProvider()
		{
			if(ServiceProvider == null)
			{ 
				ServiceProvider = Services.BuildServiceProvider();
			}
		}
	}
}
