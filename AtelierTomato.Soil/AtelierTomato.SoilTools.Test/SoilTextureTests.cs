namespace AtelierTomato.SoilTools.Test
{
	[TestClass]
	public class SoilTextureTests
	{
		[TestMethod]
		public void LowPercentageTest()
		{
			var soilTexture = new SoilTexture(10, 5, 25);
			var expectedClay = 25f;
			var expectedSilt = 12.5f;
			var expectedSand = 62.5f;
			Assert.AreEqual(expectedClay, soilTexture.Clay);
			Assert.AreEqual(expectedSilt, soilTexture.Silt);
			Assert.AreEqual(expectedSand, soilTexture.Sand);
		}
		[TestMethod]
		public void HighPercentageTest()
		{
			var soilTexture = new SoilTexture(2500, 1200, 1300);
			var expectedClay = 50f;
			var expectedSilt = 24f;
			var expectedSand = 26f;
			Assert.AreEqual(expectedClay, soilTexture.Clay);
			Assert.AreEqual(expectedSilt, soilTexture.Silt);
			Assert.AreEqual(expectedSand, soilTexture.Sand);
		}
	}
}