using System;
using Command_Core;
using MathNet.Spatial.Euclidean;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// Token: 0x02000BCF RID: 3023
	public sealed class Class263
	{
		// Token: 0x0600644A RID: 25674 RVA: 0x00319868 File Offset: 0x00317A68
		public static float GetIRCrossSectionModifier(double Altitude_ASL_m, double speed)
		{
			double num = 1718.0;
			double num2 = 1.4;
			double num3 = Altitude_ASL_m / 0.3048;
			double num4;
			if (num3 <= 36152.0)
			{
				num4 = 518.6 - 3.56 * num3 / 1000.0;
			}
			else if (num3 >= 36152.0 & num3 <= 82345.0)
			{
				num4 = 389.98;
			}
			else if (num3 >= 82345.0 & num3 <= 155348.0)
			{
				num4 = 389.98 + 1.645 * (num3 - 82345.0) / 1000.0;
			}
			else if (num3 >= 155348.0 & num3 <= 175346.0)
			{
				num4 = 508.788;
			}
			else if (num3 >= 175346.0 & num3 <= 262448.0)
			{
				num4 = 508.788 - 2.46888 * (num3 - 175346.0) / 1000.0;
			}
			else
			{
				num4 = 508.788;
			}
			double num5 = Math.Sqrt(num2 * num * num4);
			num5 = num5 * 60.0 / 88.0;
			num5 *= 0.8689755962687;
			return (float)(speed / num5);
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x00319A20 File Offset: 0x00317C20
		public static GeoPoint smethod_1(double double_0, double double_1, float float_0, double double_2, double double_3, float float_1, double double_4)
		{
			GeoPoint geoPoint = new GeoPoint();
			GeoPoint geoPoint2;
			double latitude = (geoPoint2 = geoPoint).GetLatitude();
			GeoPoint geoPoint3;
			double longitude = (geoPoint3 = geoPoint).GetLongitude();
			GeoPoint geoPoint4;
			float altitude = (geoPoint4 = geoPoint).GetAltitude();
			Class263.smethod_2(double_0, double_1, float_0, double_2, double_3, float_1, ref latitude, ref longitude, ref altitude, double_4);
			geoPoint4.SetAltitude(altitude);
			geoPoint3.SetLongitude(longitude);
			geoPoint2.SetLatitude(latitude);
			return geoPoint;
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x00319A84 File Offset: 0x00317C84
		public static void smethod_2(double lat1, double lon1, float float_0, double lat2, double lon2, float float_1, ref double double_4, ref double double_5, ref float float_2, double double_6)
		{
			double num = (double)Math2.GetDistance(lat1, lon1, lat2, lon2);
			Class258.smethod_7(lat1, lon1, ref double_4, ref double_5, (double)Math2.GetAzimuth(lat1, lon1, lat2, lon2), num);
			float_2 = (float)((double)float_0 + double_6 * (double)(float_1 - float_0) / num);
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x00319AC8 File Offset: 0x00317CC8
		public static float RelativeBearingTo(float angle1, float angle2)
		{
			angle2 = Math2.Normalize(angle2 - angle1);
			angle1 = 0f;
			float result;
			if (angle2 < 180f)
			{
				result = angle2;
			}
			else
			{
				result = -(360f - angle2);
			}
			return result;
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x00319B0C File Offset: 0x00317D0C
		public static float GetSlantRange(float range_nm, float deltaAlt_m)
		{
			float num = deltaAlt_m / 1852f;
			return (float)Math.Sqrt((double)(range_nm * range_nm + num * num));
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x00319B34 File Offset: 0x00317D34
		public static bool IsPerpendicular(int degree1, int degree2)
		{
			degree2 = Math2.Normalize(degree2 - degree1);
			degree1 = 0;
			return degree2 == 90 || degree2 == 270;
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x00319B68 File Offset: 0x00317D68
		public static double ToRadians(double degrees)
		{
			return degrees * 3.14159265358979 / 180.0;
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x00319B8C File Offset: 0x00317D8C
		public static double smethod_7(double double_0)
		{
			double num = Math.Abs(double_0);
			return (double)Class263.smethod_10(double_0) * (Conversion.Int(num) + Conversion.Int((num - Conversion.Int(num)) * 100.0 + 1E-05) / 60.0 + 100.0 * (num * 100.0 - Conversion.Int(num * 100.0 + 1E-05)) / 3600.0);
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x00319C18 File Offset: 0x00317E18
		public static double smethod_8(double double_0)
		{
			double num = Math.Abs(double_0);
			double num2 = Conversion.Int(num);
			double num3 = num - num2;
			double num4 = Conversion.Int(num3 * 60.0);
			double num5 = Conversion.Int((num3 * 60.0 - num4) * 60.0 + 0.5);
			return (double)Class263.smethod_10(double_0) * (num2 + num4 / 100.0 + num5 / 10000.0);
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x00319C98 File Offset: 0x00317E98
		public static string smethod_9(double double_0)
		{
			string @string = "";
			if (Strings.InStr(Conversions.ToString(double_0), ",", CompareMethod.Binary) > 0)
			{
				@string = ",";
			}
			if (Strings.InStr(Conversions.ToString(double_0), ".", CompareMethod.Binary) > 0)
			{
				@string = ".";
			}
			string result;
			if (Strings.InStr(Conversions.ToString(double_0), @string, CompareMethod.Binary) == 0)
			{
				result = Conversions.ToString(double_0) + "°";
			}
			else
			{
				string text = Strings.Left(Conversions.ToString(double_0), Strings.InStr(Conversions.ToString(double_0), @string, CompareMethod.Binary) - 1);
				string text2 = Conversions.ToString(double_0).Substring(Strings.InStr(Conversions.ToString(double_0), @string, CompareMethod.Binary)) + "0000";
				string text3 = text2.Substring(0, 2);
				string text4 = text2.Substring(2, 2);
				result = string.Concat(new string[]
				{
					text,
					"°",
					text3,
					"'",
					text4,
					"\""
				});
			}
			return result;
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x00319DB0 File Offset: 0x00317FB0
		public static int smethod_10(double double_0)
		{
			int result;
			if (double_0 < 0.0)
			{
				result = -1;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x00319DDC File Offset: 0x00317FDC
		public static float GetAngleBetween(float angle1, float angle2)
		{
			return Math2.Normalize(angle2 - angle1);
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x00319DF4 File Offset: 0x00317FF4
		public static GeoPoint smethod_12(GeoPoint geoPoint_0, double double_0, GeoPoint geoPoint_1, double double_1)
		{
			double num = geoPoint_0.GetLatitude() * 0.0174532925199433;
			double num2 = geoPoint_0.GetLongitude() * 0.0174532925199433;
			double num3 = geoPoint_1.GetLatitude() * 0.0174532925199433;
			double num4 = geoPoint_1.GetLongitude() * 0.0174532925199433;
			double num5 = double_0 * 0.0174532925199433;
			double num6 = double_1 * 0.0174532925199433;
			double num7 = num3 - num;
			double num8 = num4 - num2;
			double num9 = 2.0 * Math.Asin(Math.Sqrt(Math.Sin(num7 / 2.0) * Math.Sin(num7 / 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Sin(num8 / 2.0) * Math.Sin(num8 / 2.0)));
			GeoPoint result;
			if (num9 == 0.0)
			{
				result = null;
			}
			else
			{
				double num10 = Math.Acos((Math.Sin(num3) - Math.Sin(num) * Math.Cos(num9)) / (Math.Sin(num9) * Math.Cos(num)));
				if (double.IsNaN(num10))
				{
					num10 = 0.0;
				}
				double num11 = Math.Acos((Math.Sin(num) - Math.Sin(num3) * Math.Cos(num9)) / (Math.Sin(num9) * Math.Cos(num3)));
				double num12;
				double num13;
				if (Math.Sin(num4 - num2) > 0.0)
				{
					num12 = num10;
					num13 = 6.2831853071795862 - num11;
				}
				else
				{
					num12 = 6.2831853071795862 - num10;
					num13 = num11;
				}
				double num14 = (num5 - num12 + 3.1415926535897931) % 6.2831853071795862 - 3.1415926535897931;
				double num15 = (num13 - num6 + 3.1415926535897931) % 6.2831853071795862 - 3.1415926535897931;
				if (Math.Sin(num14) == 0.0 & Math.Sin(num15) == 0.0)
				{
					result = null;
				}
				else if (Math.Sin(num14) * Math.Sin(num15) < 0.0)
				{
					result = null;
				}
				else
				{
					double d = Math.Acos(-Math.Cos(num14) * Math.Cos(num15) + Math.Sin(num14) * Math.Sin(num15) * Math.Cos(num9));
					double num16 = Math.Atan2(Math.Sin(num9) * Math.Sin(num14) * Math.Sin(num15), Math.Cos(num15) + Math.Cos(num14) * Math.Cos(d));
					double num17 = Math.Asin(Math.Sin(num) * Math.Cos(num16) + Math.Cos(num) * Math.Sin(num16) * Math.Cos(num5));
					double num18 = Math.Atan2(Math.Sin(num5) * Math.Sin(num16) * Math.Cos(num), Math.Cos(num16) - Math.Sin(num) * Math.Sin(num17));
					double num19 = num2 + num18;
					num19 = (num19 + 3.1415926535897931) % 6.2831853071795862 - 3.1415926535897931;
					result = new GeoPoint(num19 * 57.2957795130823, num17 * 57.2957795130823);
				}
			}
			return result;
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x0031A15C File Offset: 0x0031835C
		public static float smethod_13(GeoPoint geoPoint_0, GeoPoint geoPoint_1, GeoPoint geoPoint_2)
		{
			double double_ = geoPoint_2.GetLatitude() * 3.1415926535897931 / 180.0;
			double double_2 = geoPoint_2.GetLongitude() * 3.1415926535897931 / 180.0;
			double double_3 = geoPoint_0.GetLatitude() * 3.1415926535897931 / 180.0;
			double double_4 = geoPoint_0.GetLongitude() * 3.1415926535897931 / 180.0;
			double double_5 = geoPoint_1.GetLatitude() * 3.1415926535897931 / 180.0;
			double double_6 = geoPoint_1.GetLongitude() * 3.1415926535897931 / 180.0;
			Class263.Struct34 @struct = Class263.Struct34.smethod_0(1.0, double_2, double_);
			Class263.Struct34 struct2 = Class263.Struct34.smethod_0(1.0, double_4, double_3);
			Class263.Struct34 struct34_ = Class263.Struct34.smethod_0(1.0, double_6, double_5);
			Class263.Struct34 struct34_2 = struct2.method_2(struct34_);
			Class263.Struct34 struct34_3 = struct34_2.method_2(@struct.method_2(struct34_2)).method_3();
			double num = Math.Acos(@struct.method_1(struct34_3));
			return (float)(3441.6865234375 * num);
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x0002BF1B File Offset: 0x0002A11B
		public static bool smethod_14(int int_0)
		{
			return int_0 % 2 != 0;
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x0031A28C File Offset: 0x0031848C
		public static GeoPoint smethod_15(Vector3D vector3D_0)
		{
			double double_ = 0.0;
			double double_2 = 0.0;
			double num = 0.0;
			Class258.smethod_4(vector3D_0.X, vector3D_0.Y, vector3D_0.Z, ref double_, ref double_2, ref num);
			return new GeoPoint(double_2, double_);
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x0031A2E0 File Offset: 0x003184E0
		public static Vector3D smethod_16(GeoPoint geoPoint_0)
		{
			Class258.Location location = Class258.smethod_2(geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), 1.0);
			return new Vector3D(location.longitude, location.latitude, location.altitude);
		}

		// Token: 0x02000BD0 RID: 3024
		private struct Struct34
		{
			// Token: 0x0600645C RID: 25692 RVA: 0x0031A324 File Offset: 0x00318524
			public double method_0()
			{
				return Math.Sqrt(this.double_0 * this.double_0 + this.double_1 * this.double_1 + this.double_2 * this.double_2);
			}

			// Token: 0x0600645D RID: 25693 RVA: 0x0002BF26 File Offset: 0x0002A126
			public Struct34(double double_3, double double_4, double double_5)
			{
				this = default(Class263.Struct34);
				this.double_0 = double_3;
				this.double_1 = double_4;
				this.double_2 = double_5;
			}

			// Token: 0x0600645E RID: 25694 RVA: 0x0031A364 File Offset: 0x00318564
			public static Class263.Struct34 smethod_0(double double_3, double double_4, double double_5)
			{
				double double_6 = double_3 * Math.Cos(double_5) * Math.Cos(double_4);
				double double_7 = double_3 * Math.Cos(double_5) * Math.Sin(double_4);
				double double_8 = double_3 * Math.Sin(double_5);
				return new Class263.Struct34(double_6, double_7, double_8);
			}

			// Token: 0x0600645F RID: 25695 RVA: 0x0031A3A4 File Offset: 0x003185A4
			public double method_1(Class263.Struct34 struct34_0)
			{
				return Class263.Struct34.smethod_1(this, struct34_0);
			}

			// Token: 0x06006460 RID: 25696 RVA: 0x0031A3C0 File Offset: 0x003185C0
			public static double smethod_1(Class263.Struct34 struct34_0, Class263.Struct34 struct34_1)
			{
				return struct34_0.double_0 * struct34_1.double_0 + struct34_0.double_1 * struct34_1.double_1 + struct34_0.double_2 * struct34_1.double_2;
			}

			// Token: 0x06006461 RID: 25697 RVA: 0x0031A400 File Offset: 0x00318600
			public Class263.Struct34 method_2(Class263.Struct34 struct34_0)
			{
				return Class263.Struct34.smethod_2(this, struct34_0);
			}

			// Token: 0x06006462 RID: 25698 RVA: 0x0031A41C File Offset: 0x0031861C
			public static Class263.Struct34 smethod_2(Class263.Struct34 struct34_0, Class263.Struct34 struct34_1)
			{
				return new Class263.Struct34(struct34_0.double_1 * struct34_1.double_2 - struct34_0.double_2 * struct34_1.double_1, struct34_0.double_2 * struct34_1.double_0 - struct34_0.double_0 * struct34_1.double_2, struct34_0.double_0 * struct34_1.double_1 - struct34_0.double_1 * struct34_1.double_0);
			}

			// Token: 0x06006463 RID: 25699 RVA: 0x0031A490 File Offset: 0x00318690
			public Class263.Struct34 method_3()
			{
				double num = this.method_0();
				return Class263.Struct34.smethod_4(this, 1.0 / num);
			}

			// Token: 0x06006464 RID: 25700 RVA: 0x0031A4BC File Offset: 0x003186BC
			public static Class263.Struct34 smethod_3(double double_3, Class263.Struct34 struct34_0)
			{
				return new Class263.Struct34(struct34_0.double_0 * double_3, struct34_0.double_1 * double_3, struct34_0.double_2 * double_3);
			}

			// Token: 0x06006465 RID: 25701 RVA: 0x0031A4EC File Offset: 0x003186EC
			public static Class263.Struct34 smethod_4(Class263.Struct34 struct34_0, double double_3)
			{
				return Class263.Struct34.smethod_3(double_3, struct34_0);
			}

			// Token: 0x04003672 RID: 13938
			public readonly double double_0;

			// Token: 0x04003673 RID: 13939
			public readonly double double_1;

			// Token: 0x04003674 RID: 13940
			public readonly double double_2;
		}
	}
}
