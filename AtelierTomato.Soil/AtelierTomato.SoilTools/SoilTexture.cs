using System.Numerics;

namespace AtelierTomato.SoilTools
{
	public record SoilTexture
	{
		private readonly Vector3 point;
		private string? name;
		public string Name
		{
			get {
				if (name is not null)
				{
					return name;
				} else
				{
					return name = DetermineSoilTexture();
				}
			}
		}

		public SoilTexture(float clay, float silt, float sand)
		{
			var total = clay + silt + sand;
			// Calculate percentage of each mineral type and make it to a Vector3
			point = new Vector3(clay / total * 100, silt / total * 100, sand / total * 100);
		}

		// Construct a soil texture triangle split into regions that are assigned specific soil textures as a dictionary
		public static Vector3[][] ClayRegion = new[] {
			new [] { new Vector3 ( 100.0f,   0.0f,   0.0f ), new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  55.0f,   0.0f,  45.0f ) },
			new [] { new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  40.0f,  15.0f,  45.0f ), new Vector3 (  55.0f,   0.0f,  45.0f ) },
			new [] { new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  40.0f,  40.0f,  20.0f ), new Vector3 (  40.0f,  15.0f,  20.0f ) }
		};
		public static Vector3[][] SiltyClayRegion = new[] {
			new [] { new Vector3 (  60.0f,  40.0f,   0.0f ), new Vector3 (  40.0f,  60.0f,   0.0f ), new Vector3 (  40.0f,  40.0f,  20.0f ) }
		};
		public static Vector3[][] SandyClayRegion = new[] {
			new [] { new Vector3 (  55.0f,  40.0f,   0.0f ), new Vector3 (  40.0f,  60.0f,   0.0f ), new Vector3 (  40.0f,  40.0f,  20.0f ) }
		};
		public static Vector3[][] ClayLoamRegion = new[] {
			new [] { new Vector3 (  40.0f,  15.0f,  45.0f ), new Vector3 (  40.0f,  40.0f,  20.0f ), new Vector3 (  27.5f,  27.5f,  45.0f ) },
			new [] { new Vector3 (  40.0f,  40.0f,  20.0f ), new Vector3 (  27.5f,  27.5f,  45.0f ), new Vector3 (  27.5f,  52.5f,  20.0f ) }
		};
		public static Vector3[][] SiltyClayLoamRegion = new[] {
			new [] { new Vector3 (  40.0f,  40.0f,  20.0f ), new Vector3 (  40.0f,  60.0f,   0.0f ), new Vector3 (  27.5f,  52.5f,  20.0f ) },
			new [] { new Vector3 (  40.0f,  60.0f,   0.0f ), new Vector3 (  27.5f,  52.5f,  20.0f ), new Vector3 (  27.5f,  72.5f,   0.0f ) }
		};
		public static Vector3[][] SandyClayLoamRegion = new[] {
			new [] { new Vector3 (  35.0f,   0.0f,  65.0f ), new Vector3 (  35.0f,  20.0f,  45.0f ), new Vector3 (  27.5f,  27.5f,  45.0f ) },
			new [] { new Vector3 (  27.5f,  27.5f,  45.0f ), new Vector3 (  20.0f,  27.5f,  52.5f ), new Vector3 (  20.0f,   0.0f,  80.0f ) },
			new [] { new Vector3 (  35.0f,   0.0f,  65.0f ), new Vector3 (  27.5f,  27.5f,  45.0f ), new Vector3 (  20.0f,   0.0f,  80.0f ) }
		};
		public static Vector3[][] LoamRegion = new[] {
			new [] { new Vector3 (  27.5f,  27.5f,  45.0f ), new Vector3 (  27.5f,  50.0f,  22.5f ), new Vector3 (  20.0f,  27.5f,  52.5f ) },
			new [] { new Vector3 (  20.0f,  27.5f,  52.5f ), new Vector3 (  27.5f,  50.0f,  22.5f ), new Vector3 (   7.5f,  50.0f,  42.5f ) },
			new [] { new Vector3 (   7.5f,  50.0f,  42.5f ), new Vector3 (   7.5f,  40.0f,  52.5f ), new Vector3 (  20.0f,  27.5f,  52.5f ) }
		};
		public static Vector3[][] SiltLoamRegion = new[] {
			new [] { new Vector3 (  27.5f,  50.0f,  22.5f ), new Vector3 (  27.5f,  72.5f,   0.0f ), new Vector3 (  12.5f,  80.0f,   7.5f ) },
			new [] { new Vector3 (  27.5f,  72.5f,   0.0f ), new Vector3 (  12.5f,  87.5f,   0.0f ), new Vector3 (  12.5f,  80.0f,   7.5f ) },
			new [] { new Vector3 (  27.5f,  50.0f,  22.5f ), new Vector3 (  12.5f,  80.0f,   7.5f ), new Vector3 (   0.0f,  80.0f,  20.0f ) },
			new [] { new Vector3 (  27.5f,  50.0f,  22.5f ), new Vector3 (   0.0f,  80.0f,  20.0f ), new Vector3 (   0.0f,  50.0f,  50.0f ) }
		};
		public static Vector3[][] SandyLoamRegion = new[] {
			new [] { new Vector3 (  20.0f,   0.0f,  80.0f ), new Vector3 (  20.0f,  27.5f,  52.5f ), new Vector3 (   7.5f,  40.0f,  52.5f ) },
			new [] { new Vector3 (  20.0f,   0.0f,  80.0f ), new Vector3 (   7.5f,  40.0f,  52.5f ), new Vector3 (   0.0f,  30.0f,  70.0f ) },
			new [] { new Vector3 (  20.0f,   0.0f,  80.0f ), new Vector3 (   0.0f,  30.0f,  70.0f ), new Vector3 (  15.0f,   0.0f,  85.0f ) },
			new [] { new Vector3 (   7.5f,  40.0f,  52.5f ), new Vector3 (   7.5f,  50.0f,  42.5f ), new Vector3 (   0.0f,  50.0f,  50.0f ) },
			new [] { new Vector3 (   7.5f,  40.0f,  52.5f ), new Vector3 (   0.0f,  50.0f,  50.0f ), new Vector3 (   0.0f,  30.0f,  70.0f ) }
		};
		public static Vector3[][] SiltRegion = new[] {
			new [] { new Vector3 (  12.5f,  80.0f,   7.5f ), new Vector3 (  12.5f,  87.5f,   0.0f ), new Vector3 (   0.0f, 100.0f,   0.0f ) },
			new [] { new Vector3 (  12.5f,  80.0f,   7.5f ), new Vector3 (   0.0f, 100.0f,   0.0f ), new Vector3 (   0.0f,  80.0f,  20.0f ) }
		};
		public static Vector3[][] LoamySandRegion = new[] {
			new [] { new Vector3 (  15.0f,   0.0f,  85.0f ), new Vector3 (   0.0f,  30.0f,  70.0f ), new Vector3 (  10.0f,   0.0f,  90.0f ) },
			new [] { new Vector3 (  10.0f,   0.0f,  90.0f ), new Vector3 (   0.0f,  30.0f,  70.0f ), new Vector3 (   0.0f,  15.0f,  85.0f ) }
		};
		public static Vector3[][] SandRegion = new[] {
			new [] { new Vector3 (  10.0f,   0.0f,  90.0f ), new Vector3 (   0.0f,  15.0f,  85.0f ), new Vector3 (   0.0f,   0.0f, 100.0f ) }
		};

		public static Dictionary<string, Vector3[][]> SoilTextureTriangle = new() {
			{ "Clay", ClayRegion },
			{ "Silty Clay", SiltyClayRegion },
			{ "Sandy Clay", SandyClayRegion },
			{ "Clay Loam", ClayLoamRegion },
			{ "Silty Clay Loam", SiltyClayLoamRegion },
			{ "Sandy Clay Loam", SandyClayLoamRegion },
			{ "Loam", LoamRegion },
			{ "Silt Loam", SiltLoamRegion },
			{ "Sandy Loam", SandyLoamRegion },
			{ "Silt", SiltRegion },
			{ "Loamy Sand", LoamySandRegion },
			{ "Sand", SandRegion }
		};

		private string DetermineSoilTexture() => SoilTextureTriangle
			.First(region => region
				.Value
				.Any(triangle => IsPointInsideTriangle(point, triangle[0], triangle[1], triangle[2])))
			.Key;

		private static bool IsPointInsideTriangle(Vector3 p, Vector3 v0, Vector3 v1, Vector3 v2)
		{
			// Compute vectors
			Vector3 v0v1 = v1 - v0;
			Vector3 v0v2 = v2 - v0;
			Vector3 vp = p - v0;

			// Compute dot products
			float dot00 = Vector3.Dot(v0v1, v0v1);
			float dot01 = Vector3.Dot(v0v1, v0v2);
			float dot02 = Vector3.Dot(v0v1, vp);
			float dot11 = Vector3.Dot(v0v2, v0v2);
			float dot12 = Vector3.Dot(v0v2, vp);

			// Computer barycentric coordinates
			float invDenom = 1 / (dot00 * dot11 - dot01 * dot01);
			float u = (dot11 * dot02 - dot01 * dot12) * invDenom;
			float v = (dot00 * dot12 - dot01 * dot02) * invDenom;

			// Check if point is in triangle
			return (u >= 0) && (v >= 0) && (u + v <= 1);
		}
	}
}
