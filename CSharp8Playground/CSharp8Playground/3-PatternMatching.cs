using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Playground
{

	// Thank you David Pine
	// https://github.com/IEvangelist/csharp-eight/blob/master/IEvangelist.CSharp.Eight/PatternMatching.cs

	public enum Rainbow
	{
		Red,
		Orange,
		Yellow,
		Green,
		Blue,
		Indigo,
		Violet
	}

	public class RGBColor
	{
		public byte Red { get; }

		public byte Green { get; }

		public byte Blue { get; }

		public RGBColor(byte red, byte green, byte blue)
		{
			Red = red;
			Green = green;
			Blue = blue;
		}

		public override string ToString() => $"rgb({Red}, {Green}, {Blue})";
	}

	public static class SwitchExpressions
	{
		public static RGBColor FromRainbow(this Rainbow rainbowBolor)
		{
			switch (rainbowBolor)
			{
				case Rainbow.Red:
					return new RGBColor(0xFF, 0x00, 0x00);
				case Rainbow.Orange:
					return new RGBColor(0xFF, 0x7F, 0x00);
				case Rainbow.Yellow:
					return new RGBColor(0xFF, 0xFF, 0x00);
				case Rainbow.Green:
					return new RGBColor(0x00, 0xFF, 0x00);
				case Rainbow.Blue:
					return new RGBColor(0x00, 0x00, 0xFF);
				case Rainbow.Indigo:
					return new RGBColor(0x4B, 0x00, 0x82);
				case Rainbow.Violet:
					return new RGBColor(0x94, 0x00, 0xD3);
				default:
					throw new ArgumentException(message: "invalid enum value", paramName: nameof(rainbowBolor));
			};
		}

		public static RGBColor TasteTheRainbow(Rainbow rainbowColor) =>
			rainbowColor switch
		{
			Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
			Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
			Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
			Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
			Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
			Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
			Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
			_ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(rainbowColor))
		};
	}

	public class RockPaperScisorsGame
	{
		public static string ScoreGame(string first, string second)
		{
			string score = (first, second) switch
			{
				("rock", "paper") => "Rock is covered by Paper. Paper wins!",
				("rock", "scissors") => "Rock breaks Scissors. Rock wins!",
				("paper", "rock") => "Paper covers Rock. Paper wins!",
				("paper", "scissors") => "Paper is cut by Scissors. Scissors wins!",
				("scissors", "rock") => "Scissors is broken by Rock. Rock wins!",
				("scissors", "paper") => "Scissors cuts Paper. Scissors wins!",
				(_, _) => "tie"
			};
			return score;
		}
	}

	public static class PatternMatching
	{
		public static void Run()
		{

			Console.WriteLine($"Legacy switch: {SwitchExpressions.FromRainbow(Rainbow.Violet)}");
			Console.WriteLine($"Expressive switch: {SwitchExpressions.TasteTheRainbow(Rainbow.Red)}");

			string score = RockPaperScisorsGame.ScoreGame("rock", "scissors");
			Console.WriteLine(score);

		}
	}
}
