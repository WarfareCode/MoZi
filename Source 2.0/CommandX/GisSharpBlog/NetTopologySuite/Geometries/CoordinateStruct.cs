using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200044F RID: 1103
	[Serializable]
	public struct CoordinateStruct : IComparable<ICoordinate>, IEquatable<ICoordinate>, IComparable, ICloneable, ICoordinate
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x00011AD3 File Offset: 0x0000FCD3
		public CoordinateStruct(double double_0, double double_1, double double_2)
		{
			this.x = double_0;
			this.y = double_1;
			this.z = double_2;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x000B4CE8 File Offset: 0x000B2EE8
		public double imethod_0()
		{
			return this.x;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00011AEA File Offset: 0x0000FCEA
		public void imethod_1(double double_0)
		{
			this.x = double_0;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x000B4D00 File Offset: 0x000B2F00
		public double imethod_2()
		{
			return this.y;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00011AF3 File Offset: 0x0000FCF3
		public void imethod_3(double double_0)
		{
			this.y = double_0;
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000B4D18 File Offset: 0x000B2F18
		public double imethod_4()
		{
			return this.z;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00011AFC File Offset: 0x0000FCFC
		public void imethod_5(double double_0)
		{
			this.z = double_0;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00011B05 File Offset: 0x0000FD05
		public void imethod_6(ICoordinate icoordinate_0)
		{
			this.x = icoordinate_0.imethod_0();
			this.y = icoordinate_0.imethod_2();
			this.z = icoordinate_0.imethod_4();
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000B4D30 File Offset: 0x000B2F30
		public double imethod_7(ICoordinate icoordinate_0)
		{
			double num = this.x - icoordinate_0.imethod_0();
			double num2 = this.y - icoordinate_0.imethod_2();
			return Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00011B2B File Offset: 0x0000FD2B
		public bool imethod_8(ICoordinate icoordinate_0)
		{
			return this.x == icoordinate_0.imethod_0() && this.y == icoordinate_0.imethod_2();
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x000B4D68 File Offset: 0x000B2F68
		public object Clone()
		{
			return new CoordinateStruct(this.imethod_0(), this.imethod_2(), this.imethod_4());
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000B4D94 File Offset: 0x000B2F94
		public int CompareTo(object target)
		{
			ICoordinate other = (ICoordinate)target;
			return this.CompareTo(other);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x000B4DB4 File Offset: 0x000B2FB4
		public int CompareTo(ICoordinate other)
		{
			int result;
			if (this.x < other.imethod_0())
			{
				result = -1;
			}
			else if (this.x > other.imethod_0())
			{
				result = 1;
			}
			else if (this.y < other.imethod_2())
			{
				result = -1;
			}
			else if (this.y > other.imethod_2())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public bool Equals(ICoordinate other)
		{
			return this.imethod_8(other);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00011B55 File Offset: 0x0000FD55
		public override bool Equals(object obj)
		{
			return obj != null && obj is CoordinateStruct && this.Equals((CoordinateStruct)obj);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000B4E24 File Offset: 0x000B3024
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"(",
				this.x,
				", ",
				this.y,
				", ",
				this.z,
				")"
			});
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000B4E8C File Offset: 0x000B308C
		public override int GetHashCode()
		{
			int num = 629 + CoordinateStruct.smethod_0(this.imethod_0());
			return 37 * num + CoordinateStruct.smethod_0(this.imethod_2());
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0008B220 File Offset: 0x00089420
		private static int smethod_0(double double_0)
		{
			long num = BitConverter.DoubleToInt64Bits(double_0);
			return (int)(num ^ num >> 32);
		}

		// Token: 0x04000C60 RID: 3168
		private double x;

		// Token: 0x04000C61 RID: 3169
		private double y;

		// Token: 0x04000C62 RID: 3170
		private double z;
	}
}
