using System;
using Microsoft.DirectX;
using ns18;

namespace ns19
{
	// Token: 0x020003A4 RID: 932
	public sealed class Class1958
	{
		// Token: 0x060016D0 RID: 5840 RVA: 0x00090CA4 File Offset: 0x0008EEA4
		public static Point3d smethod_0(DateTime dateTime_0)
		{
			Point3d result;
			if (World.Settings.method_42())
			{
				double num = Class1958.smethod_1(dateTime_0);
				double num2 = (num - 2451545.0) / 36525.0;
				double num3 = 0.017453292519943295;
				double num4 = 357.5291 + 35999.0503 * num2 - 0.0001559 * num2 * num2 - 4.8E-07 * num2 * num2 * num2;
				double num5 = 280.46645 + 36000.76983 * num2 + 0.0003032 * num2 * num2;
				double num6 = (1.9146 - 0.004817 * num2 - 1.4E-05 * num2 * num2) * Math.Sin(num3 * num4) + (0.019993 - 0.000101 * num2) * Math.Sin(0.034906585039886591 * num4) + 0.00029 * Math.Sin(0.05235987755982989 * num4);
				double num7 = num5 + num6;
				num7 %= 360.0;
				double num8 = 23.43929111111111 - (46.815 * num2 + 0.00059 * num2 * num2 - 0.001813 * num2 * num2 * num2) / 3600.0;
				double num9 = Math.Cos(num3 * num7);
				double num10 = Math.Cos(num3 * num8) * Math.Sin(num3 * num7);
				double num11 = Math.Sin(num3 * num8) * Math.Sin(num3 * num7);
				double num12 = Math.Sqrt(1.0 - num11 * num11);
				double num13 = 57.295779513082323 * Math.Atan(num11 / num12);
				double num14 = 7.6394372684109761 * Math.Atan(num10 / (num9 + num12));
				double num15 = (280.46061837 + 360.98564736629 * (num - 2451545.0) + 0.000387933 * num2 * num2 - num2 * num2 * num2 / 38710000.0) % 360.0;
				num14 *= 15.0;
				double num16 = num15 - num14;
				result = MathEngine.SphericalToCartesianD(Angle.FromDegrees(-num13), Angle.FromDegrees(-(num16 - 180.0)), 1.0);
			}
			else
			{
				double radius = 6378137.0;
				result = Class1958.smethod_2(MathEngine.SphericalToCartesian(World.Settings.method_21(), World.Settings.method_22(), radius), Angle.FromRadians(World.Settings.method_44()), Angle.FromRadians(World.Settings.method_43()), World.Settings.method_45());
			}
			return result;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00090F64 File Offset: 0x0008F164
		private static double smethod_1(DateTime dateTime_0)
		{
			double num = (double)dateTime_0.Day + (double)dateTime_0.Hour / 24.0 + (double)dateTime_0.Minute / 1440.0 + (double)dateTime_0.Second / 86400.0 + (double)dateTime_0.Millisecond / 86400000.0;
			int num2 = (dateTime_0.Month < 3) ? (dateTime_0.Month + 12) : dateTime_0.Month;
			int num3 = (dateTime_0.Month < 3) ? (dateTime_0.Year - 1) : dateTime_0.Year;
			int num4 = 2 - (int)Math.Floor((double)(num3 / 100)) + (int)Math.Floor((double)(num3 / 400));
			return (double)((int)Math.Floor((double)(1461 * (num3 + 4716)) / 4.0) + (int)Math.Floor((double)(153 * (num2 + 1) / 5))) + num + (double)num4 - 1524.5;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00091064 File Offset: 0x0008F264
		public static Point3d smethod_2(Vector3 vector3_0, Angle struct63_0, Angle struct63_1, double double_0)
		{
			Vector3 vector = MathEngine.SphericalToCartesian(struct63_1, Angle.FromRadians(3.1415926535897931 - struct63_0.Radians), double_0);
			Vector3 vector2 = MathEngine.CartesianToSpherical(vector3_0.X, vector3_0.Y, vector3_0.Z);
			Matrix matrix = Matrix.Identity;
			matrix *= Matrix.Translation(0f, 0f, vector2.X);
			matrix *= Matrix.RotationY(1.57079637f - vector2.Y);
			matrix *= Matrix.RotationZ(vector2.Z);
			vector.TransformCoordinate(matrix);
			return new Point3d(-(double)vector.X, -(double)vector.Y, -(double)vector.Z);
		}
	}
}
