using System;

namespace ns18
{
	// Token: 0x0200039F RID: 927
	public struct Quaternion4d
	{
		// Token: 0x0600169C RID: 5788 RVA: 0x0000F5BC File Offset: 0x0000D7BC
		public Quaternion4d(double double_4, double double_5, double double_6, double double_7)
		{
			this.X = double_4;
			this.Y = double_5;
			this.Z = double_6;
			this.W = double_7;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000901A8 File Offset: 0x0008E3A8
		public override int GetHashCode()
		{
			return (int)(this.X / this.Y / this.Z / this.W);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0000F5DB File Offset: 0x0000D7DB
		public override bool Equals(object obj)
		{
			return obj is Quaternion4d && Quaternion4d.Equals((Quaternion4d)obj, this);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000901D4 File Offset: 0x0008E3D4
		public static Quaternion4d EulerToQuaternion(double yaw, double pitch, double roll)
		{
			double num = Math.Cos(yaw * 0.5);
			double num2 = Math.Cos(pitch * 0.5);
			double num3 = Math.Cos(roll * 0.5);
			double num4 = Math.Sin(yaw * 0.5);
			double num5 = Math.Sin(pitch * 0.5);
			double num6 = Math.Sin(roll * 0.5);
			double double_ = num * num2 * num3 + num4 * num5 * num6;
			double double_2 = num4 * num2 * num3 - num * num5 * num6;
			double double_3 = num * num5 * num3 + num4 * num2 * num6;
			double double_4 = num * num2 * num6 - num4 * num5 * num3;
			return new Quaternion4d(double_2, double_3, double_4, double_);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00090298 File Offset: 0x0008E498
		public static Point3d QuaternionToEuler(Quaternion4d q)
		{
			double w = q.W;
			double x = q.X;
			double y = q.Y;
			double z = q.Z;
			double double_ = Math.Atan2(2.0 * (y * z + w * x), w * w - x * x - y * y + z * z);
			double double_2 = Math.Asin(-2.0 * (x * z - w * y));
			double double_3 = Math.Atan2(2.0 * (x * y + w * z), w * w + x * x - y * y - z * z);
			return new Point3d(double_, double_2, double_3);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0009033C File Offset: 0x0008E53C
		public static Quaternion4d Plus(Quaternion4d a, Quaternion4d b)
		{
			return new Quaternion4d(a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y, a.W * b.Y + a.Y * b.W + a.Z * b.X - a.X * b.Z, a.W * b.Z + a.Z * b.W + a.X * b.Y - a.Y * b.X, a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0009044C File Offset: 0x0008E64C
		public static double Norm2(Quaternion4d q)
		{
			return q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0009049C File Offset: 0x0008E69C
		public static double Abs(Quaternion4d q)
		{
			return Math.Sqrt(Quaternion4d.Norm2(q));
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000904B8 File Offset: 0x0008E6B8
		public static bool Equals(Quaternion4d a, Quaternion4d b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00090508 File Offset: 0x0008E708
		public static double Dot(Quaternion4d a, Quaternion4d b)
		{
			return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00090558 File Offset: 0x0008E758
		public static Quaternion4d Slerp(Quaternion4d q0, Quaternion4d q1, double t)
		{
			double num = q0.X * q1.X + q0.Y * q1.Y + q0.Z * q1.Z + q0.W * q1.W;
			double num2;
			double num3;
			double num4;
			double num5;
			if (num < 0.0)
			{
				num = -num;
				num2 = -q1.X;
				num3 = -q1.Y;
				num4 = -q1.Z;
				num5 = -q1.W;
			}
			else
			{
				num2 = q1.X;
				num3 = q1.Y;
				num4 = q1.Z;
				num5 = q1.W;
			}
			double num8;
			double num9;
			if (1.0 - num > 4.94065645841247E-324)
			{
				double num6 = Math.Acos(num);
				double num7 = Math.Sin(num6);
				num8 = Math.Sin((1.0 - t) * num6) / num7;
				num9 = Math.Sin(t * num6) / num7;
			}
			else
			{
				num8 = 1.0 - t;
				num9 = t;
			}
			return new Quaternion4d
			{
				X = num8 * q0.X + num9 * num2,
				Y = num8 * q0.Y + num9 * num3,
				Z = num8 * q0.Z + num9 * num4,
				W = num8 * q0.W + num9 * num5
			};
		}

		// Token: 0x04000965 RID: 2405
		public double X;

		// Token: 0x04000966 RID: 2406
		public double Y;

		// Token: 0x04000967 RID: 2407
		public double Z;

		// Token: 0x04000968 RID: 2408
		public double W;
	}
}
