using System;

namespace DanNik.BrokenLine.Common
{
	/// <summary>
	/// Функционал вызова бизнес логики
	/// </summary>
    public static class HandlerProcessor
    {
		public static TResult Process<THandler, TResult>(Func<THandler, TResult> func)
		{
			var type = typeof(THandler);
			var handler = (THandler)AmbientContext.Current.ServiceProvider.GetService(type);

			try{ 
				var res = func(handler);
				return res;
			}
			catch(Exception e){ 
				AmbientContext.Current.Log.Error(e, "{type} {handler}", "HandlerError", nameof(type));
				throw e;
			}
		}
    }
}
