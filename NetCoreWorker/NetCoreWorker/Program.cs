using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace NetCoreWorker
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				// Added: Microsoft.Extensions.Hosting.WindowsServices
				.UseServiceBaseLifetime()
				.ConfigureServices(services =>
				{
					services.AddHostedService<Worker>();
				});

		/* then:
		dotnet publish -c Release -o c:\code\workerpub
		sc create workertest binPath=c:\code\workerpub\NetCoreWorker.exe
		*/
	}
}
