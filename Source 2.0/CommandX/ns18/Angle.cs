using System;
using System.Globalization;

namespace ns18
{
	// Token: 0x0200034F RID: 847
	public struct Angle
	{
		// Token: 0x060013D7 RID: 5079 RVA: 0x00085848 File Offset: 0x00083A48
		public static Angle FromRadians(double radians)
		{
			return new Angle
			{
				Radians = radians
			};
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00085868 File Offset: 0x00083A68
		public static Angle FromDegrees(double degrees)
		{
			return new Angle
			{
				Radians = 3.1415926535897931 * degrees / 180.0
			};
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0008589C File Offset: 0x00083A9C
		public double GetDegrees()
		{
			return MathEngine.RadiansToDegrees(this.Radians);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0000E3BD File Offset: 0x0000C5BD
		public void SetDegrees(double degree)
		{
			this.Radians = MathEngine.DegreesToRadians(degree);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000858B8 File Offset: 0x00083AB8
		public static Angle Abs(Angle a)
		{
			return Angle.FromRadians(Math.Abs(a.Radians));
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0000E3CB File Offset: 0x0000C5CB
		public static bool IsNaN(Angle a)
		{
			return double.IsNaN(a.Radians);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000858D8 File Offset: 0x00083AD8
		public override bool Equals(object obj)
		{
			bool result;
			if (obj != null && !(base.GetType() != obj.GetType()))
			{
				Angle angle = (Angle)obj;
				result = (Math.Abs(this.Radians - angle.Radians) < 1.4012984643248171E-45);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0000E3D9 File Offset: 0x0000C5D9
		public static bool NotEqual(Angle a, Angle b)
		{
			return Math.Abs(a.Radians - b.Radians) > 1.4012984643248171E-45;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0000E3FA File Offset: 0x0000C5FA
		public static bool IsLittleThan(Angle a, Angle b)
		{
			return a.Radians < b.Radians;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0000E40C File Offset: 0x0000C60C
		public static bool IsLargerThan(Angle a, Angle b)
		{
			return a.Radians > b.Radians;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00085934 File Offset: 0x00083B34
		public static Angle Addition(Angle a, Angle b)
		{
			return Angle.FromRadians(a.Radians + b.Radians);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00085958 File Offset: 0x00083B58
		public static Angle Minus(Angle a, Angle b)
		{
			return Angle.FromRadians(a.Radians - b.Radians);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0008597C File Offset: 0x00083B7C
		public static Angle Multiply(Angle a, double times)
		{
			return Angle.FromRadians(a.Radians * times);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0008599C File Offset: 0x00083B9C
		public static Angle Divide(Angle a, double divisor)
		{
			return Angle.FromRadians(a.Radians / divisor);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000859BC File Offset: 0x00083BBC
		public override int GetHashCode()
		{
			return (int)(this.Radians * 100000.0);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000859DC File Offset: 0x00083BDC
		public override string ToString()
		{
			return this.GetDegrees().ToString(CultureInfo.InvariantCulture) + "°";
		}

		// Token: 0x04000836 RID: 2102
		[NonSerialized]
		public double Radians;

		// Token: 0x04000837 RID: 2103
		public static readonly Angle Zero;

		// Token: 0x04000838 RID: 2104
		public static readonly Angle MinValue = Angle.FromRadians(-1.7976931348623157E+308);

		// Token: 0x04000839 RID: 2105
		public static readonly Angle MaxValue = Angle.FromRadians(1.7976931348623157E+308);

		// Token: 0x0400083A RID: 2106
		public static readonly Angle NaN = Angle.FromRadians(double.NaN);
	}
}
