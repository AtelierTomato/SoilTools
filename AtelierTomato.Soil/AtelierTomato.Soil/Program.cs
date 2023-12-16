using AtelierTomato.SoilTools;

namespace AtelierTomato.Soil
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Welcome to my cool program!");
			Console.WriteLine("In this program we will be soiling.");
			SoilTextureTriangle myGround = new SoilTextureTriangle(80, 20, 10);
			SoilTextureTriangle yourGround = new SoilTextureTriangle(40, 20, 40);
			Console.WriteLine("Please input three numeric values assigned to clay, silt, and sand, respectively, seperated by spaces:");
			var userInput = Console.ReadLine();
			var userSoilTextureValues = userInput.Split(' ').Select(s => float.Parse(s)).ToArray();
			SoilTextureTriangle userGround = new SoilTextureTriangle(userSoilTextureValues[0], userSoilTextureValues[1], userSoilTextureValues[2]);
		}
	}
}