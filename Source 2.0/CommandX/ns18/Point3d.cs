using System;

namespace ns18
{
	// Token: 0x02000383 RID: 899
	public sealed class Point3d
	{
		// Token: 0x06001599 RID: 5529 RVA: 0x0000EFD1 File Offset: 0x0000D1D1
		public Point3d()
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		public Point3d(double double_3, double double_4, double double_5)
		{
			this.X = double_3;
			this.Y = double_4;
			this.Z = double_5;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0008BE20 File Offset: 0x0008A020
		public double norm()
		{
			return Math.Sqrt(this.norm2());
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0008BE3C File Offset: 0x0008A03C
		public double norm2()
		{
			return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0008BE74 File Offset: 0x0008A074
		public Point3d normalize()
		{
			double num = this.norm();
			return new Point3d(this.X / num, this.Y / num, this.Z / num);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0008BEA8 File Offset: 0x0008A0A8
		public static Point3d addition(Point3d p1, Point3d p2)
		{
			return new Point3d(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0008BEE4 File Offset: 0x0008A0E4
		public static Point3d subtraction(Point3d p1, Point3d p2)
		{
			return new Point3d(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0008BF20 File Offset: 0x0008A120
		public static Point3d multiply(Point3d p1, double p2)
		{
			return new Point3d(p1.X * p2, p1.Y * p2, p1.Z * p2);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0008BF4C File Offset: 0x0008A14C
		public override bool Equals(object obj)
		{
			bool result = false;
			try
			{
				result = Point3d.equal(this, (Point3d)obj);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0008BF80 File Offset: 0x0008A180
		public override int GetHashCode()
		{
			return (int)(this.X * this.Y * this.Z);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0000F014 File Offset: 0x0000D214
		public static bool equal(Point3d p1, Point3d p2)
		{
			return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0008BFA4 File Offset: 0x0008A1A4
		public static Point3d Multiply(Point3d P1, Point3d P2)
		{
			return new Point3d(P1.Y * P2.Z - P1.Z * P2.Y, P1.Z * P2.X - P1.X * P2.Z, P1.X * P2.Y - P1.Y * P2.X);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0008C00C File Offset: 0x0008A20C
		public static Point3d Mult(Point3d P1, Point3d P2)
		{
			return Point3d.Multiply(P1, P2);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0008C024 File Offset: 0x0008A224
		public override string ToString()
		{
			return string.Format("{0} {1} {2}", this.X, this.Y, this.Z);
		}

		// Token: 0x040008F5 RID: 2293
		public double X;

		// Token: 0x040008F6 RID: 2294
		public double Y;

		// Token: 0x040008F7 RID: 2295
		public double Z = 0.0;
	}
}
