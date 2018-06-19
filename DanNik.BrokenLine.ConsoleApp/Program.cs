using System;

namespace DanNik.BrokenLine.ConsoleApp
{
    class Program
    {
		/// <summary>
		/// Пример использования функционала библиотеки DanNik.BrokenLine
		/// </summary>
		/// <param name="args"></param>
        static void Main(string[] args)
        {
			var brokenLineService = new BrokenLineService();
			var brokenLineProvider = new BrokenLineProvider();

			var brokenLine = brokenLineProvider.Get();

			var result = brokenLineService.GetBrokenLineLength(brokenLine);

            Console.WriteLine($"Result: {result}");
			Console.ReadLine();
        }
    }
}
