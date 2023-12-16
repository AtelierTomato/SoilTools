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

		public static Vector3[][] ClayRegion = new[] {
				new [] { new Vector3 ( 100.0f,   0.0f,   0.0f ), new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  55.0f,   0.0f,  45.0f ) },
				new [] { new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  40.0f,  15.0f,  45.0f ), new Vector3 (  55.0f,   0.0f,  45.0f ) },
				new [] { new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  40.0f,  40.0f,  20.0f ), new Vector3 (  40.0f,  15.0f,  20.0f ) },
		};
		public static Vector3[][] SiltyClayRegion = new[] {
				new [] { new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  40.0f,  60.0f,   0.0f ), new Vector3 (  40.0f,  40.0f,  20.0f ) }
		};
		public static Dictionary<string, Vector3[][]> AllSections = new() {
			{ "Clay", ClayRegion },
			{ "Silty Clay", SiltyClayRegion }
		};
	}
}
