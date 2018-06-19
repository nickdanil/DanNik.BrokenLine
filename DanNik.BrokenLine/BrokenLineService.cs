using DanNik.BrokenLine.Common;
using DanNik.BrokenLine.BusinessObjects;
using DanNik.BrokenLine.BusinessObjects.Contracts;
using DanNik.BrokenLine.BusinessLogic.DIModules;
using DanNik.BrokenLine.BusinessLogic.Handlers.BrokenLine;

namespace DanNik.BrokenLine
{
	/// <summary>
	/// Реализация фунционала расчета длины ломаной
	/// </summary>
    public class BrokenLineService: IBrokenLineService
    {
		public BrokenLineService()
		{
			//TODO: Вынести инициализацию контекста из сервиса - должен инициализировать один раз при подключении библиотеки
			var context = AmbientContext.Current;
			new ConsoleAppModule();
		}

		public double GetBrokenLineLength(BrokenLinePoint[] brokenLine)
		{
			return HandlerProcessor.Process<GetBrokenLineLengthHandler, double>( h => h.Handle(brokenLine));
		}
    }
}
