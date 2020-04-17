using System;

namespace ns3
{
	// Token: 0x02000BAE RID: 2990
	public sealed class GeoPointGenerator
	{
		// Token: 0x060062A5 RID: 25253 RVA: 0x003021FC File Offset: 0x003003FC
		public static void GetOtherPointsAroundAGeoPoint(double latitude, double longitude, double distance, int numpoints, ref Class258.Location[] GeoPoints)
		{
			if (numpoints < 3)
			{
				throw new Exception("insufficient numpoints");
			}
			double lng = Class258.smethod_6(longitude);
			GeoPoints = new Class258.Location[numpoints - 1 + 1];
			double num = 0.0;
			double num2 = 360.0 / (double)numpoints;
			int num3 = numpoints - 1;
			for (int i = 0; i <= num3; i++)
			{
				GeoPoints[i].altitude = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(lng, latitude, ref GeoPoints[i].longitude, ref GeoPoints[i].latitude, distance, num);
				num += num2;
			}
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x003022A4 File Offset: 0x003004A4
		public static void GetOtherGeoPoint(double lng1, double lat1, ref double lng2, ref double lat2, double distance, double azimuth)
		{
			double num = distance / 3441.6865234375;
			double num2 = azimuth * 0.0174532925199433;
			double num3 = lat1 * 0.0174532925199433;
			double num4 = lng1 * 0.0174532925199433;
			double num5 = Math.Sin(num3);
			double num6 = Math.Cos(num3);
			double num7 = Math.Sin(num);
			double num8 = Math.Cos(num);
			double num9 = Math.Asin(num5 * num8 + num6 * num7 * Math.Cos(num2));
			double num10 = Math.Atan2(Math.Sin(num2) * num7 * num6, num8 - num5 * Math.Sin(num9));
			double num11 = num4 + num10 + 3.1415926535897931;
			double num12 = 6.28318530717958;
			double num13 = num11 - num12 * (double)((int)Math.Round(num11 / num12));
			if (num13 < 0.0)
			{
				num13 += num12;
			}
			num13 -= 3.1415926535897931;
			lng2 = num13 * 57.2957795130823;
			lat2 = num9 * 57.2957795130823;
		}
	}
}
