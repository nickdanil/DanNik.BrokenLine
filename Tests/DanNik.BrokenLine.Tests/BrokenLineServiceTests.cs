using DanNik.BrokenLine.BusinessObjects;
using Xunit;

namespace DanNik.BrokenLine.Tests
{
    public class BrokenLineServiceTests
    {
		/// <summary>
		/// Проверка длины ломаной на основе периметра треуголника
		/// </summary>
        [Fact]
        public void TrueLength_ShouldBePassed()
        {
			var brokenLineService = new BrokenLineService();

			var brokenLine = new BrokenLinePoint[]{ 
				new BrokenLinePoint(0, 0)
				, new BrokenLinePoint(0, 4)
				, new BrokenLinePoint(3, 0)
				, new BrokenLinePoint(0, 0)
			};
			var result = brokenLineService.GetBrokenLineLength(brokenLine);

			Assert.Equal(3+4+5, result);
        }

		/// <summary>
		/// Проверка алгоритма расчета длины ломаной на минимальное количество точек
		/// </summary>
		[Fact]
        public void MinPointCount_ShouldNotBePassed()
        {
			var brokenLineService = new BrokenLineService();

			var brokenLine = new BrokenLinePoint[]{ 
				new BrokenLinePoint(0, 0)
				, new BrokenLinePoint(0, 4)
			};
			var result = brokenLineService.GetBrokenLineLength(brokenLine);
        }

		/// <summary>
		/// Проверка алгоритма расчета длины ломаной на передачу нулевого параметра
		/// </summary>
		[Fact]
        public void NullPointCount_ShouldNotBePassed()
        {
			var brokenLineService = new BrokenLineService();

			BrokenLinePoint[] brokenLine = null;
			var result = brokenLineService.GetBrokenLineLength(brokenLine);
        }
    }
}
