using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000438 RID: 1080
	[Serializable]
	public sealed class Coordinate : IComparable<ICoordinate>, IEquatable<ICoordinate>, IComparable, ICloneable, ICoordinate
	{
		// Token: 0x06001BA6 RID: 7078 RVA: 0x000B2000 File Offset: 0x000B0200
		public double imethod_0()
		{
			return this.x;
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000115ED File Offset: 0x0000F7ED
		public void imethod_1(double double_0)
		{
			this.x = double_0;
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000B2018 File Offset: 0x000B0218
		public double imethod_2()
		{
			return this.y;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000115F6 File Offset: 0x0000F7F6
		public void imethod_3(double double_0)
		{
			this.y = double_0;
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000B2030 File Offset: 0x000B0230
		public double imethod_4()
		{
			return this.z;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000115FF File Offset: 0x0000F7FF
		public void imethod_5(double double_0)
		{
			this.z = double_0;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00011608 File Offset: 0x0000F808
		public Coordinate(double double_0, double double_1, double double_2)
		{
			this.x = double_0;
			this.y = double_1;
			this.z = double_2;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00011625 File Offset: 0x0000F825
		public Coordinate() : this(0.0, 0.0, double.NaN)
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00011648 File Offset: 0x0000F848
		public Coordinate(ICoordinate icoordinate_0) : this(icoordinate_0.imethod_0(), icoordinate_0.imethod_2(), icoordinate_0.imethod_4())
		{
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00011662 File Offset: 0x0000F862
		public Coordinate(double double_0, double double_1) : this(double_0, double_1, double.NaN)
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00011675 File Offset: 0x0000F875
		public void imethod_6(ICoordinate icoordinate_0)
		{
			this.x = icoordinate_0.imethod_0();
			this.y = icoordinate_0.imethod_2();
			this.z = icoordinate_0.imethod_4();
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0001169B File Offset: 0x0000F89B
		public bool imethod_8(ICoordinate icoordinate_0)
		{
			return this.x == icoordinate_0.imethod_0() && this.y == icoordinate_0.imethod_2();
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x000116BC File Offset: 0x0000F8BC
		public override bool Equals(object obj)
		{
			return obj != null && obj is Coordinate && this.Equals((Coordinate)obj);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000116D8 File Offset: 0x0000F8D8
		public bool Equals(ICoordinate other)
		{
			return this.imethod_8(other);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000B2048 File Offset: 0x000B0248
		public int CompareTo(object target)
		{
			ICoordinate other = (ICoordinate)target;
			return this.CompareTo(other);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000B2068 File Offset: 0x000B0268
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

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000B20D8 File Offset: 0x000B02D8
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

		// Token: 0x06001BB7 RID: 7095 RVA: 0x000B2140 File Offset: 0x000B0340
		public object Clone()
		{
			return new Coordinate(this.imethod_0(), this.imethod_2(), this.imethod_4());
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000B2168 File Offset: 0x000B0368
		public double imethod_7(ICoordinate icoordinate_0)
		{
			double num = this.x - icoordinate_0.imethod_0();
			double num2 = this.y - icoordinate_0.imethod_2();
			return Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000B21A0 File Offset: 0x000B03A0
		public override int GetHashCode()
		{
			int num = 629 + Coordinate.smethod_0(this.imethod_0());
			return 37 * num + Coordinate.smethod_0(this.imethod_2());
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0008B220 File Offset: 0x00089420
		private static int smethod_0(double double_0)
		{
			long num = BitConverter.DoubleToInt64Bits(double_0);
			return (int)(num ^ num >> 32);
		}

		// Token: 0x04000BE9 RID: 3049
		private double x;

		// Token: 0x04000BEA RID: 3050
		private double y;

		// Token: 0x04000BEB RID: 3051
		private double z;
	}
}
