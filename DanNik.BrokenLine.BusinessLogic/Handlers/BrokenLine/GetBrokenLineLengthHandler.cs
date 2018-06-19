using DanNik.BrokenLine.BusinessObjects;
using Serilog;
using System;

namespace DanNik.BrokenLine.BusinessLogic.Handlers.BrokenLine
{
    public class GetBrokenLineLengthHandler
    {
		public double Handle(BrokenLinePoint[] brokenLine)
		{ 
			double length = 0;
			double segment = 0;

			Validate(brokenLine);

			for(var i = 0 ; i < brokenLine.Length - 1 ;i++)
			{
				var p1 = brokenLine[i];
				var p2 = brokenLine[i + 1];
				segment = Math.Sqrt(
					Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y)
					, /*degree*/ 2
				));

				length += segment;
			}

			return 	length;
		}

		private void Validate(BrokenLinePoint[] brokenLine)
		{ 
			if(brokenLine == null) throw new Exception("Broken Line is null");

			if(brokenLine.Length <= 2 ) throw new Exception("Points must be greater than 2");
		}
    }
}
