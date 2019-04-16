using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Playground
{
	// Not in C# 8 yet: https://stackoverflow.com/a/53746372/702931

	public class Widget
	{
		public string SpecialSauce { get; set; }
	}

	// published library

	public interface IWidgetRunner
	{
		void Create(Widget widget);
	}

	public class WidgetRunner : IWidgetRunner
	{
		public void Create(Widget widget)
		{
			Console.WriteLine($"Widget {widget.SpecialSauce} is created");
		}

		#region more
		public void CreateAll(List<Widget> widgets)
		{
			foreach (var widget in widgets)
			{
				this.Create(widget);
			}
		}
		#endregion

	}

	// user of the library

	public class SpecialWidgetRunner : IWidgetRunner
	{
		public void Create(Widget widget)
		{
			Console.WriteLine($"Special widget {widget.SpecialSauce} creation achieved");
		}
	}



	public static class DefaultInterface
	{
		public static void Run()
		{
			Widget widget = new Widget { SpecialSauce = "Tall building jumping" };

			IWidgetRunner regularRunner = new WidgetRunner();
			regularRunner.Create(widget);

			IWidgetRunner specialRunner = new SpecialWidgetRunner();
			specialRunner.Create(widget);
			
		}
	}
}
