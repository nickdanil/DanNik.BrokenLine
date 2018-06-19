using DanNik.BrokenLine.BusinessObjects;
using DanNik.BrokenLine.BusinessObjects.Contracts;

namespace DanNik.BrokenLine
{
	/// <summary>
	/// Функционал для доступа к объектам ломаных. Пока просто заглушка
	/// </summary>
    public class BrokenLineProvider: IBrokenLineProvider
    {
		public BrokenLinePoint[] Get(){ 
			var brokenLine = new BrokenLinePoint[]{ 
				new BrokenLinePoint(0, 1)
				, new BrokenLinePoint(2, 3)
				, new BrokenLinePoint(8, 12)
				, new BrokenLinePoint(7, 9)
				, new BrokenLinePoint(4, 5)
				, new BrokenLinePoint(5, 4)
				, new BrokenLinePoint(12, 18)
			};
			return brokenLine;
		}
    }
}
