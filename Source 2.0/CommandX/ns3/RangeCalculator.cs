using System;
using System.Collections.Generic;
using Command_Core;

namespace ns3
{
	// Token: 0x02000BAD RID: 2989
	public sealed class RangeCalculator
	{
		// Token: 0x060062A0 RID: 25248 RVA: 0x00301EF8 File Offset: 0x003000F8
		public static double GetAngularDistance(double lat1_, double lon1_, double lat2_, double lon2_)
		{
			double d = lat1_ * 0.0174532925199433;
			double d2 = lat2_ * 0.0174532925199433;
			double num = (lat2_ - lat1_) * 0.0174532925199433;
			double num2 = (lon2_ - lon1_) * 0.0174532925199433;
			double num3 = Math.Sin(num / 2.0);
			double num4 = Math.Sin(num2 / 2.0);
			double num5 = num3 * num3 + Math.Cos(d) * Math.Cos(d2) * (num4 * num4);
			return 2.0 * Math.Atan2(Math.Sqrt(num5), Math.Sqrt(1.0 - num5));
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x00301FA4 File Offset: 0x003001A4
		public static double GetAngularDistance_Degree(double lat1_, double lon1_, double lat2_, double lon2_)
		{
			double d = lat1_ * 0.0174532925199433;
			double d2 = lat2_ * 0.0174532925199433;
			double num = (lat2_ - lat1_) * 0.0174532925199433;
			double num2 = (lon2_ - lon1_) * 0.0174532925199433;
			double num3 = Math.Sin(num / 2.0);
			double num4 = Math.Sin(num2 / 2.0);
			double num5 = num3 * num3 + Math.Cos(d) * Math.Cos(d2) * (num4 * num4);
			return 2.0 * Math.Atan2(Math.Sqrt(num5), Math.Sqrt(1.0 - num5)) * 57.2957795130823;
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x0030205C File Offset: 0x0030025C
		public static double GetRange(double lat1, double lon1, double lat2, double lon2)
		{
			double d = lat1 * 0.0174532925199433;
			double d2 = lat2 * 0.0174532925199433;
			double num = (lat2 - lat1) * 0.0174532925199433;
			double num2 = (lon2 - lon1) * 0.0174532925199433;
			double num3 = Math.Sin(num / 2.0);
			double num4 = Math.Sin(num2 / 2.0);
			double num5 = num3 * num3 + Math.Cos(d) * Math.Cos(d2) * (num4 * num4);
			double num6 = 2.0 * Math.Atan2(Math.Sqrt(num5), Math.Sqrt(1.0 - num5));
			return 3441.6865234375 * num6;
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x00302118 File Offset: 0x00300318
		public static List<ActiveUnit> GetUnitsInRange(IEnumerable<ActiveUnit> ActiveUnits, bool bool_0, double PlatformLat_, double PlatformLon_, double range_)
		{
			double num = Math2.ApproxAngularDistance(range_);
			List<ActiveUnit> list = new List<ActiveUnit>();
			bool flag = true;
			double num2 = PlatformLat_ + num;
			double num3 = PlatformLat_ - num;
			if (num2 > 90.0 || num3 < -90.0)
			{
				flag = false;
			}
			bool? hintIsOperating = null;
			if (bool_0)
			{
				hintIsOperating = new bool?(true);
			}
			foreach (ActiveUnit current in ActiveUnits)
			{
				double latitude = current.GetLatitude(hintIsOperating);
				double longitude = current.GetLongitude(hintIsOperating);
				if ((!flag || (num2 >= latitude && num3 <= latitude)) && RangeCalculator.GetAngularDistance_Degree(PlatformLat_, PlatformLon_, latitude, longitude) <= num)
				{
					list.Add(current);
				}
			}
			return list;
		}
	}
}
