namespace AtelierTomato.SoilTools.Test
{
	public class SoilTextureNameTests
	{
		[Theory]
		[InlineData(90, 5, 5, "Clay")]
		[InlineData(50, 10, 40, "Clay")]
		[InlineData(45, 30, 25, "Clay")]
		[InlineData(50, 45, 5, "Silty Clay")]
		[InlineData(40, 10, 50, "Sandy Clay")]
		[InlineData(35, 25, 40, "Clay Loam")]
		[InlineData(35, 40, 25, "Clay Loam")]
		[InlineData(35, 50, 15, "Silty Clay Loam")]
		[InlineData(35, 60, 5, "Silty Clay Loam")]
		[InlineData(32.5, 20, 47.5, "Sandy Clay Loam")]
		[InlineData(22.5, 22.5, 50, "Sandy Clay Loam")]
		[InlineData(30, 5, 65, "Sandy Clay Loam")]
		[InlineData(25, 30, 45, "Loam")]
		[InlineData(20, 45, 35, "Loam")]
		[InlineData(10, 40, 50, "Loam")]
		[InlineData(15, 80, 5, "Silt Loam")]
		[InlineData(20, 70, 10, "Silt Loam")]
		[InlineData(10, 75, 15, "Silt Loam")]
		[InlineData(5, 55, 40, "Silt Loam")]
		[InlineData(10, 85, 5, "Silt")]
		[InlineData(5, 85, 10, "Silt")]
		[InlineData(15, 5, 80, "Sandy Loam")]
		[InlineData(10, 20, 70, "Sandy Loam")]
		[InlineData(15, 25, 60, "Sandy Loam")]
		[InlineData(5, 40, 55, "Sandy Loam")]
		[InlineData(5, 45, 50, "Sandy Loam")]
		[InlineData(10, 5, 85, "Loamy Sand")]
		[InlineData(2.5, 15, 82.5, "Loamy Sand")]
		[InlineData(5, 5, 90, "Sand")]
		public void WithinTriangleTests(int clay, int silt, int sand, string expectedName)
		{
			SoilTexture texture = new SoilTexture(clay, silt, sand);
			texture.Name.Equals(expectedName);
		}

		[Theory]
		[InlineData(100, 0, 0, "Clay")]
		[InlineData(90, 10, 0, "Clay")]
		[InlineData(90, 0, 10, "Clay")]
		[InlineData(50, 50, 0, "Silty Clay")]
		[InlineData(50, 0, 50, "Sandy Clay")]
		[InlineData(35, 65, 0, "Silty Clay Loam")]
		[InlineData(30, 0, 70, "Sandy Clay Loam")]
		[InlineData(20, 80, 0, "Silt Loam")]
		[InlineData(0, 60, 40, "Silt Loam")]
		[InlineData(17.5, 0, 82.5, "Sandy Loam")]
		[InlineData(0, 35, 65, "Sandy Loam")]
		[InlineData(0, 45, 55, "Sandy Loam")]
		[InlineData(12.5, 0, 87.5, "Loamy Sand")]
		[InlineData(0, 20, 80, "Loamy Sand")]
		[InlineData(5, 95, 0, "Silt")]
		[InlineData(0, 90, 10, "Silt")]
		[InlineData(0, 100, 0, "Silt")]
		[InlineData(5, 0, 95, "Sand")]
		[InlineData(0, 5, 95, "Sand")]
		[InlineData(0, 0, 100, "Sand")]
		public void ZeroTests(int clay, int silt, int sand, string expectedName)
		{
			SoilTexture texture = new SoilTexture(clay, silt, sand);
			texture.Name.Equals(expectedName);
		}
	}
}
