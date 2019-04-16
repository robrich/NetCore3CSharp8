using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Playground
{
	public static class AsyncForeach
	{
		public static async Task Run()
		{
			var watch = new Stopwatch();
			watch.Start();

			await foreach (var statement in StreamOfNumbers())
			{
				Console.WriteLine($"Elapsed time {watch.Elapsed}, {statement}");
			}
		}

		static async IAsyncEnumerable<int> StreamOfNumbers()
		{
			int x = 0;
			while (true)
			{
				await Task.Delay(1000);
				yield return x;
				x++;
			}
		}
	}
}
