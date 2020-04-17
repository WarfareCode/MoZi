using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000373 RID: 883
	[Serializable]
	public sealed class Envelope : IComparable<IEnvelope>, IEquatable<IEnvelope>, IComparable, ICloneable, IEnvelope
	{
		// Token: 0x0600151A RID: 5402 RVA: 0x0008ACE4 File Offset: 0x00088EE4
		public static bool smethod_0(ICoordinate icoordinate_0, ICoordinate icoordinate_1, ICoordinate icoordinate_2)
		{
			double num = icoordinate_2.imethod_0();
			double num2 = icoordinate_2.imethod_2();
			double num3 = icoordinate_0.imethod_0();
			double num4 = icoordinate_1.imethod_0();
			double num5 = icoordinate_0.imethod_2();
			double num6 = icoordinate_1.imethod_2();
			double num7;
			double num8;
			if (num3 < num4)
			{
				num7 = num3;
				num8 = num4;
			}
			else
			{
				num7 = num4;
				num8 = num3;
			}
			double num9;
			double num10;
			if (num5 < num6)
			{
				num9 = num5;
				num10 = num6;
			}
			else
			{
				num9 = num6;
				num10 = num5;
			}
			return num >= num7 && num <= num8 && num2 >= num9 && num2 <= num10;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0008AD98 File Offset: 0x00088F98
		public static bool smethod_1(ICoordinate icoordinate_0, ICoordinate icoordinate_1, ICoordinate icoordinate_2, ICoordinate icoordinate_3)
		{
			double val = icoordinate_0.imethod_0();
			double val2 = icoordinate_1.imethod_0();
			double val3 = icoordinate_2.imethod_0();
			double val4 = icoordinate_3.imethod_0();
			double num = Math.Min(val, val2);
			double num2 = Math.Max(val3, val4);
			bool result;
			if (num > num2)
			{
				result = false;
			}
			else
			{
				double num3 = Math.Min(val3, val4);
				double num4 = Math.Max(val, val2);
				if (num4 < num3)
				{
					result = false;
				}
				else
				{
					num = Math.Min(icoordinate_0.imethod_2(), icoordinate_1.imethod_2());
					num2 = Math.Max(icoordinate_2.imethod_2(), icoordinate_3.imethod_2());
					if (num > num2)
					{
						result = false;
					}
					else
					{
						num3 = Math.Min(icoordinate_2.imethod_2(), icoordinate_3.imethod_2());
						num4 = Math.Max(icoordinate_0.imethod_2(), icoordinate_1.imethod_2());
						result = (num4 >= num3);
					}
				}
			}
			return result;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0000ED2F File Offset: 0x0000CF2F
		public Envelope()
		{
			this.vmethod_0();
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0000ED3D File Offset: 0x0000CF3D
		public Envelope(double double_0, double double_1, double double_2, double double_3)
		{
			this.vmethod_1(double_0, double_1, double_2, double_3);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0000ED50 File Offset: 0x0000CF50
		public Envelope(ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			this.imethod_8(icoordinate_0, icoordinate_1);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0000ED60 File Offset: 0x0000CF60
		public Envelope(IEnvelope ienvelope_0)
		{
			this.vmethod_2(ienvelope_0);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0000ED6F File Offset: 0x0000CF6F
		public void vmethod_0()
		{
			this.vmethod_3();
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0008AE74 File Offset: 0x00089074
		public void vmethod_1(double double_0, double double_1, double double_2, double double_3)
		{
			if (double_0 < double_1)
			{
				this.minx = double_0;
				this.maxx = double_1;
			}
			else
			{
				this.minx = double_1;
				this.maxx = double_0;
			}
			if (double_2 < double_3)
			{
				this.miny = double_2;
				this.maxy = double_3;
			}
			else
			{
				this.miny = double_3;
				this.maxy = double_2;
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0000ED77 File Offset: 0x0000CF77
		public void imethod_8(ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			this.vmethod_1(icoordinate_0.imethod_0(), icoordinate_1.imethod_0(), icoordinate_0.imethod_2(), icoordinate_1.imethod_2());
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0000ED97 File Offset: 0x0000CF97
		public void vmethod_2(IEnvelope ienvelope_0)
		{
			this.minx = ienvelope_0.imethod_3();
			this.maxx = ienvelope_0.imethod_1();
			this.miny = ienvelope_0.imethod_4();
			this.maxy = ienvelope_0.imethod_2();
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0000EDC9 File Offset: 0x0000CFC9
		public void vmethod_3()
		{
			this.minx = 0.0;
			this.maxx = -1.0;
			this.miny = 0.0;
			this.maxy = -1.0;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0000EE07 File Offset: 0x0000D007
		public bool imethod_10()
		{
			return this.maxx < this.minx;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0008AED4 File Offset: 0x000890D4
		public double imethod_3()
		{
			return this.minx;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0008AEEC File Offset: 0x000890EC
		public double imethod_1()
		{
			return this.maxx;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0008AF04 File Offset: 0x00089104
		public double imethod_4()
		{
			return this.miny;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0008AF1C File Offset: 0x0008911C
		public double imethod_2()
		{
			return this.maxy;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0008AF34 File Offset: 0x00089134
		public void imethod_7(IEnvelope ienvelope_0)
		{
			if (!ienvelope_0.imethod_10())
			{
				if (this.imethod_10())
				{
					this.minx = ienvelope_0.imethod_3();
					this.maxx = ienvelope_0.imethod_1();
					this.miny = ienvelope_0.imethod_4();
					this.maxy = ienvelope_0.imethod_2();
				}
				else
				{
					if (ienvelope_0.imethod_3() < this.minx)
					{
						this.minx = ienvelope_0.imethod_3();
					}
					if (ienvelope_0.imethod_1() > this.maxx)
					{
						this.maxx = ienvelope_0.imethod_1();
					}
					if (ienvelope_0.imethod_4() < this.miny)
					{
						this.miny = ienvelope_0.imethod_4();
					}
					if (ienvelope_0.imethod_2() > this.maxy)
					{
						this.maxy = ienvelope_0.imethod_2();
					}
				}
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0008B008 File Offset: 0x00089208
		public bool imethod_9(IEnvelope ienvelope_0)
		{
			return !this.imethod_10() && !ienvelope_0.imethod_10() && ienvelope_0.imethod_3() <= this.maxx && ienvelope_0.imethod_1() >= this.minx && ienvelope_0.imethod_4() <= this.maxy && ienvelope_0.imethod_2() >= this.miny;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0000EE17 File Offset: 0x0000D017
		public bool imethod_5(ICoordinate icoordinate_0)
		{
			return this.vmethod_4(icoordinate_0.imethod_0(), icoordinate_0.imethod_2());
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0000EE2B File Offset: 0x0000D02B
		public bool vmethod_4(double double_0, double double_1)
		{
			return double_0 >= this.minx && double_0 <= this.maxx && double_1 >= this.miny && double_1 <= this.maxy;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0008B064 File Offset: 0x00089264
		public bool imethod_6(IEnvelope ienvelope_0)
		{
			return !this.imethod_10() && !ienvelope_0.imethod_10() && ienvelope_0.imethod_3() >= this.minx && ienvelope_0.imethod_1() <= this.maxx && ienvelope_0.imethod_4() >= this.miny && ienvelope_0.imethod_2() <= this.maxy;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0000EE57 File Offset: 0x0000D057
		public override bool Equals(object obj)
		{
			return obj != null && obj is Envelope && this.Equals((IEnvelope)obj);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0008B0C0 File Offset: 0x000892C0
		public bool Equals(IEnvelope other)
		{
			bool result;
			if (this.imethod_10())
			{
				result = other.imethod_10();
			}
			else
			{
				result = (this.maxx == other.imethod_1() && this.maxy == other.imethod_2() && this.minx == other.imethod_3() && this.miny == other.imethod_4());
			}
			return result;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0008B120 File Offset: 0x00089320
		public int CompareTo(object target)
		{
			return this.CompareTo((IEnvelope)target);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0008B13C File Offset: 0x0008933C
		public int CompareTo(IEnvelope other)
		{
			int result;
			if (this.imethod_10() && other.imethod_10())
			{
				result = 0;
			}
			else if (!this.imethod_10() && other.imethod_10())
			{
				result = 1;
			}
			else if (this.imethod_10() && !other.imethod_10())
			{
				result = -1;
			}
			else if (this.imethod_0() > other.imethod_0())
			{
				result = 1;
			}
			else if (this.imethod_0() < other.imethod_0())
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0008B1CC File Offset: 0x000893CC
		public override int GetHashCode()
		{
			int num = 629 + Envelope.smethod_2(this.minx);
			num = 37 * num + Envelope.smethod_2(this.maxx);
			num = 37 * num + Envelope.smethod_2(this.miny);
			return 37 * num + Envelope.smethod_2(this.maxy);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0008B220 File Offset: 0x00089420
		private static int smethod_2(double double_0)
		{
			long num = BitConverter.DoubleToInt64Bits(double_0);
			return (int)(num ^ num >> 32);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0008B240 File Offset: 0x00089440
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"Env[",
				this.minx,
				" : ",
				this.maxx,
				", ",
				this.miny,
				" : ",
				this.maxy,
				"]"
			});
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0008B2C0 File Offset: 0x000894C0
		object ICloneable.Clone()
		{
			return this.method_0();
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0008B2D8 File Offset: 0x000894D8
		public double imethod_0()
		{
			double num = 1.0;
			num *= this.maxx - this.minx;
			return num * (this.maxy - this.miny);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0008B310 File Offset: 0x00089510
		public IEnvelope method_0()
		{
			return new Envelope(this.minx, this.maxx, this.miny, this.maxy);
		}

		// Token: 0x040008E6 RID: 2278
		private double minx;

		// Token: 0x040008E7 RID: 2279
		private double maxx;

		// Token: 0x040008E8 RID: 2280
		private double miny;

		// Token: 0x040008E9 RID: 2281
		private double maxy;
	}
}
