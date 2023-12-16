using AtelierTomato.SoilTools;

namespace AtelierTomato.Soil
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Welcome to my cool program!");
			Console.WriteLine("In this program we will be soiling.");
			SoilTexture myGround = new SoilTexture(80, 20, 10);
			SoilTexture yourGround = new SoilTexture(40, 20, 40);
			Console.WriteLine("Please input three numeric values assigned to clay, silt, and sand, respectively, seperated by spaces:");
			var userInput = Console.ReadLine();
			var userSoilTextureValues = userInput.Split(' ').Select(s => float.Parse(s)).ToArray();
			SoilTexture userGround = new SoilTexture(userSoilTextureValues[0], userSoilTextureValues[1], userSoilTextureValues[2]);
			Console.WriteLine(userGround.Name);
		}
	}
}