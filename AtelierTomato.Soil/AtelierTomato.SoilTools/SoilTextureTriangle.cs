using System.Numerics;

namespace AtelierTomato.SoilTools
{
	public record SoilTextureTriangle
	{
		private readonly Vector3 point;

		public SoilTextureTriangle(float clay, float silt, float sand)
		{
			var total = clay + silt + sand;
			// Calculate percentage of each mineral type and make it to a Vector3
			point = new Vector3(clay / total * 100, silt / total * 100, sand / total * 100);
		}
	}
}
