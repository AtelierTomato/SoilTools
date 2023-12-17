using AtelierTomato.SoilTools;

namespace AtelierTomato.Soil
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("This program will allow you to enter the mineral make up of your soil and calculate the soil texture.");
			Console.WriteLine();
			bool loop = true;
			while (loop)
			{
				Console.WriteLine("Please input three numeric values assigned to clay, silt, and sand, respectively, seperated by spaces:");
				var userInput = Console.ReadLine();
				var userSoilTextureValues = userInput.Split(' ').Select(s => float.Parse(s)).ToArray();
				SoilTexture userGround = new SoilTexture(userSoilTextureValues[0], userSoilTextureValues[1], userSoilTextureValues[2]);
				Console.WriteLine(userGround.Name);
				Console.WriteLine();
				Console.WriteLine("Press 'X' to close the program or any other key to calculate another soil texture.");
				if (Console.ReadKey(false).Key == ConsoleKey.X)
				{
					loop = false;
				}
				Console.WriteLine();
			}
		}
	}
}