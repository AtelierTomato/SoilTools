using AtelierTomato.SoilTools;

namespace AtelierTomato.Soil
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Welcome to my cool program!");
			Console.WriteLine("In this program we will be soiling.");
			Console.WriteLine("Goodbye, World!");
			SoilTextureTriangle myGround = new SoilTextureTriangle(80, 20, 10);
			SoilTextureTriangle yourGround = new SoilTextureTriangle(40, 20, 40);
		}
	}
}