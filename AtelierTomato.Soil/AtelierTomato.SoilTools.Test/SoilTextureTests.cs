namespace AtelierTomato.SoilTools.Test
{
	public class SoilTextureTests
	{
		[Fact]
		public void LowPercentageTest()
		{
			var soilTexture = new SoilTexture(10, 5, 25);
			var expectedClay = 25f;
			var expectedSilt = 12.5f;
			var expectedSand = 62.5f;
			Assert.Equal(expectedClay, soilTexture.Clay);
			Assert.Equal(expectedSilt, soilTexture.Silt);
			Assert.Equal(expectedSand, soilTexture.Sand);
		}
		[Fact]
		public void HighPercentageTest()
		{
			var soilTexture = new SoilTexture(2500, 1200, 1300);
			var expectedClay = 50f;
			var expectedSilt = 24f;
			var expectedSand = 26f;
			Assert.Equal(expectedClay, soilTexture.Clay);
			Assert.Equal(expectedSilt, soilTexture.Silt);
			Assert.Equal(expectedSand, soilTexture.Sand);
		}
	}
}