using System;
using Microsoft.DirectX;

namespace ns18
{
	// Token: 0x0200037B RID: 891
	public sealed class MathEngine
	{
		// Token: 0x0600156D RID: 5485 RVA: 0x00004A21 File Offset: 0x00002C21
		private MathEngine()
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0008B83C File Offset: 0x00089A3C
		public static Vector3 SphericalToCartesian(double latitude, double longitude, double radius)
		{
			latitude *= 0.017453292519943295;
			longitude *= 0.017453292519943295;
			double num = radius * Math.Cos(latitude);
			return new Vector3((float)(num * Math.Cos(longitude)), (float)(num * Math.Sin(longitude)), (float)(radius * Math.Sin(latitude)));
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0008B890 File Offset: 0x00089A90
		public static Vector3 SphericalToCartesian(Angle latitude, Angle longitude, double radius)
		{
			double radians = latitude.Radians;
			double radians2 = longitude.Radians;
			double num = radius * Math.Cos(radians);
			return new Vector3((float)(num * Math.Cos(radians2)), (float)(num * Math.Sin(radians2)), (float)(radius * Math.Sin(radians)));
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0008B8D8 File Offset: 0x00089AD8
		public static Point3d SphericalToCartesianD(Angle latitude, Angle longitude, double radius)
		{
			double radians = latitude.Radians;
			double radians2 = longitude.Radians;
			double num = radius * Math.Cos(radians);
			return new Point3d(num * Math.Cos(radians2), num * Math.Sin(radians2), radius * Math.Sin(radians));
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0008B920 File Offset: 0x00089B20
		public static Vector3 CartesianToSpherical(float x, float y, float z)
		{
			double num = Math.Sqrt((double)(x * x + y * y + z * z));
			float valueZ = (float)Math.Atan2((double)y, (double)x);
			float valueY = (float)Math.Asin((double)z / num);
			return new Vector3((float)num, valueY, valueZ);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0008B960 File Offset: 0x00089B60
		public static Point3d CartesianToSphericalD(double x, double y, double z)
		{
			double num = Math.Sqrt(x * x + y * y + z * z);
			double double_ = Math.Atan2(y, x);
			double double_2 = Math.Asin(z / num);
			return new Point3d(num, double_2, double_);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0008B99C File Offset: 0x00089B9C
		public static double DegreesToRadians(double degrees)
		{
			return 3.1415926535897931 * degrees / 180.0;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0008B9C0 File Offset: 0x00089BC0
		public static double RadiansToDegrees(double randians)
		{
			return randians * 180.0 / 3.1415926535897931;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0008B9E4 File Offset: 0x00089BE4
		public static Angle SphericalDistance(Angle latA, Angle lonA, Angle latB, Angle lonB)
		{
			double radians = latA.Radians;
			double radians2 = latB.Radians;
			double radians3 = lonA.Radians;
			double radians4 = lonB.Radians;
			return Angle.FromRadians(Math.Acos(Math.Cos(radians) * Math.Cos(radians2) * Math.Cos(radians3 - radians4) + Math.Sin(radians) * Math.Sin(radians2)));
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0008BA44 File Offset: 0x00089C44
		public static int GetRowFromLatitude(double latitude, double tileSize)
		{
			return (int)Math.Round(Math.Abs(-90.0 - latitude) % 180.0 / tileSize, 1);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0008BA78 File Offset: 0x00089C78
		public static int GetRowFromLatitude(Angle latitude, double tileSize)
		{
			return (int)Math.Round(Math.Abs(-90.0 - latitude.GetDegrees()) % 180.0 / tileSize, 1);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0008BAB0 File Offset: 0x00089CB0
		public static int GetColFromLongitude(double longitude, double tileSize)
		{
			return (int)Math.Round(Math.Abs(-180.0 - longitude) % 360.0 / tileSize, 1);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0008BAE4 File Offset: 0x00089CE4
		public static int GetColFromLongitude(Angle longitude, double tileSize)
		{
			return (int)Math.Round(Math.Abs(-180.0 - longitude.GetDegrees()) % 360.0 / tileSize, 1);
		}
	}
}
