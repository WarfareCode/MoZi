using System;
using System.Diagnostics;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns12;
using ns13;

namespace ns14
{
	// Token: 0x0200046F RID: 1135
	public sealed class Class597 : Class596
	{
		// Token: 0x06001D5F RID: 7519 RVA: 0x000BD75C File Offset: 0x000BB95C
		public override void vmethod_0(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6)
		{
			this.bool_0 = false;
			if (Envelope.smethod_0(icoordinate_5, icoordinate_6, icoordinate_4) && Class628.smethod_0(icoordinate_5, icoordinate_6, icoordinate_4) == 0 && Class628.smethod_0(icoordinate_6, icoordinate_5, icoordinate_4) == 0)
			{
				this.bool_0 = true;
				if (icoordinate_4.Equals(icoordinate_5) || icoordinate_4.Equals(icoordinate_6))
				{
					this.bool_0 = false;
				}
				this.int_0 = 1;
			}
			else
			{
				this.int_0 = 0;
			}
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000BD7D0 File Offset: 0x000BB9D0
		public override int vmethod_1(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6, ICoordinate icoordinate_7)
		{
			this.bool_0 = false;
			int result;
			if (!Envelope.smethod_1(icoordinate_4, icoordinate_5, icoordinate_6, icoordinate_7))
			{
				result = 0;
			}
			else
			{
				int num = Class628.smethod_0(icoordinate_4, icoordinate_5, icoordinate_6);
				int num2 = Class628.smethod_0(icoordinate_4, icoordinate_5, icoordinate_7);
				if ((num > 0 && num2 > 0) || (num < 0 && num2 < 0))
				{
					result = 0;
				}
				else
				{
					int num3 = Class628.smethod_0(icoordinate_6, icoordinate_7, icoordinate_4);
					int num4 = Class628.smethod_0(icoordinate_6, icoordinate_7, icoordinate_5);
					if ((num3 > 0 && num4 > 0) || (num3 < 0 && num4 < 0))
					{
						result = 0;
					}
					else if (num == 0 && num2 == 0 && num3 == 0 && num4 == 0)
					{
						result = this.method_10(icoordinate_4, icoordinate_5, icoordinate_6, icoordinate_7);
					}
					else
					{
						if (num == 0 || num2 == 0 || num3 == 0 || num4 == 0)
						{
							this.bool_0 = false;
							if (num == 0)
							{
								this.icoordinate_1[0] = new Coordinate(icoordinate_6);
							}
							if (num2 == 0)
							{
								this.icoordinate_1[0] = new Coordinate(icoordinate_7);
							}
							if (num3 == 0)
							{
								this.icoordinate_1[0] = new Coordinate(icoordinate_4);
							}
							if (num4 == 0)
							{
								this.icoordinate_1[0] = new Coordinate(icoordinate_5);
							}
						}
						else
						{
							this.bool_0 = true;
							this.icoordinate_1[0] = this.method_11(icoordinate_4, icoordinate_5, icoordinate_6, icoordinate_7);
						}
						result = 1;
					}
				}
			}
			return result;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x000BD92C File Offset: 0x000BBB2C
		private int method_10(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6, ICoordinate icoordinate_7)
		{
			bool flag = Envelope.smethod_0(icoordinate_4, icoordinate_5, icoordinate_6);
			bool flag2 = Envelope.smethod_0(icoordinate_4, icoordinate_5, icoordinate_7);
			bool flag3 = Envelope.smethod_0(icoordinate_6, icoordinate_7, icoordinate_4);
			bool flag4 = Envelope.smethod_0(icoordinate_6, icoordinate_7, icoordinate_5);
			int result;
			if (flag && flag2)
			{
				this.icoordinate_1[0] = icoordinate_6;
				this.icoordinate_1[1] = icoordinate_7;
				result = 2;
			}
			else if (flag3 && flag4)
			{
				this.icoordinate_1[0] = icoordinate_4;
				this.icoordinate_1[1] = icoordinate_5;
				result = 2;
			}
			else if (flag && flag3)
			{
				this.icoordinate_1[0] = icoordinate_6;
				this.icoordinate_1[1] = icoordinate_4;
				result = ((!icoordinate_6.Equals(icoordinate_4) || flag2 || flag4) ? 2 : 1);
			}
			else if (flag && flag4)
			{
				this.icoordinate_1[0] = icoordinate_6;
				this.icoordinate_1[1] = icoordinate_5;
				result = ((!icoordinate_6.Equals(icoordinate_5) || flag2 || flag3) ? 2 : 1);
			}
			else if (flag2 && flag3)
			{
				this.icoordinate_1[0] = icoordinate_7;
				this.icoordinate_1[1] = icoordinate_4;
				result = ((!icoordinate_7.Equals(icoordinate_4) || flag || flag4) ? 2 : 1);
			}
			else if (flag2 && flag4)
			{
				this.icoordinate_1[0] = icoordinate_7;
				this.icoordinate_1[1] = icoordinate_5;
				result = ((!icoordinate_7.Equals(icoordinate_5) || flag || flag3) ? 2 : 1);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000BDA94 File Offset: 0x000BBC94
		private ICoordinate method_11(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6, ICoordinate icoordinate_7)
		{
			ICoordinate coordinate = new Coordinate(icoordinate_4);
			ICoordinate coordinate2 = new Coordinate(icoordinate_5);
			ICoordinate coordinate3 = new Coordinate(icoordinate_6);
			ICoordinate coordinate4 = new Coordinate(icoordinate_7);
			ICoordinate coordinate5 = new Coordinate();
			this.method_12(coordinate, coordinate2, coordinate3, coordinate4, coordinate5);
			ICoordinate coordinate6 = null;
			try
			{
				coordinate6 = Class644.smethod_0(coordinate, coordinate2, coordinate3, coordinate4);
			}
			catch (Exception10)
			{
				Class570.smethod_2("Coordinate for intersection is not calculable");
			}
			ICoordinate coordinate7 = coordinate6;
			coordinate7.imethod_1(coordinate7.imethod_0() + coordinate5.imethod_0());
			ICoordinate coordinate8 = coordinate6;
			coordinate8.imethod_3(coordinate8.imethod_2() + coordinate5.imethod_2());
			if (!this.method_13(coordinate6))
			{
				Trace.WriteLine("Intersection outside segment envelopes: " + coordinate6);
			}
			if (this.iprecisionModel_0 != null)
			{
				this.iprecisionModel_0.imethod_3(coordinate6);
			}
			return coordinate6;
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000BDB6C File Offset: 0x000BBD6C
		private void method_12(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6, ICoordinate icoordinate_7, ICoordinate icoordinate_8)
		{
			double num = (icoordinate_4.imethod_0() < icoordinate_5.imethod_0()) ? icoordinate_4.imethod_0() : icoordinate_5.imethod_0();
			double num2 = (icoordinate_4.imethod_2() < icoordinate_5.imethod_2()) ? icoordinate_4.imethod_2() : icoordinate_5.imethod_2();
			double num3 = (icoordinate_4.imethod_0() > icoordinate_5.imethod_0()) ? icoordinate_4.imethod_0() : icoordinate_5.imethod_0();
			double num4 = (icoordinate_4.imethod_2() > icoordinate_5.imethod_2()) ? icoordinate_4.imethod_2() : icoordinate_5.imethod_2();
			double num5 = (icoordinate_6.imethod_0() < icoordinate_7.imethod_0()) ? icoordinate_6.imethod_0() : icoordinate_7.imethod_0();
			double num6 = (icoordinate_6.imethod_2() < icoordinate_7.imethod_2()) ? icoordinate_6.imethod_2() : icoordinate_7.imethod_2();
			double num7 = (icoordinate_6.imethod_0() > icoordinate_7.imethod_0()) ? icoordinate_6.imethod_0() : icoordinate_7.imethod_0();
			double num8 = (icoordinate_6.imethod_2() > icoordinate_7.imethod_2()) ? icoordinate_6.imethod_2() : icoordinate_7.imethod_2();
			double num9 = (num > num5) ? num : num5;
			double num10 = (num3 < num7) ? num3 : num7;
			double num11 = (num2 > num6) ? num2 : num6;
			double num12 = (num4 < num8) ? num4 : num8;
			double double_ = (num9 + num10) / 2.0;
			double double_2 = (num11 + num12) / 2.0;
			icoordinate_8.imethod_1(double_);
			icoordinate_8.imethod_3(double_2);
			icoordinate_4.imethod_1(icoordinate_4.imethod_0() - icoordinate_8.imethod_0());
			icoordinate_4.imethod_3(icoordinate_4.imethod_2() - icoordinate_8.imethod_2());
			icoordinate_5.imethod_1(icoordinate_5.imethod_0() - icoordinate_8.imethod_0());
			icoordinate_5.imethod_3(icoordinate_5.imethod_2() - icoordinate_8.imethod_2());
			icoordinate_6.imethod_1(icoordinate_6.imethod_0() - icoordinate_8.imethod_0());
			icoordinate_6.imethod_3(icoordinate_6.imethod_2() - icoordinate_8.imethod_2());
			icoordinate_7.imethod_1(icoordinate_7.imethod_0() - icoordinate_8.imethod_0());
			icoordinate_7.imethod_3(icoordinate_7.imethod_2() - icoordinate_8.imethod_2());
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x000BDD78 File Offset: 0x000BBF78
		private bool method_13(ICoordinate icoordinate_4)
		{
			IEnvelope envelope = new Envelope(this.icoordinate_0[0], this.icoordinate_0[1]);
			IEnvelope envelope2 = new Envelope(this.icoordinate_0[2], this.icoordinate_0[3]);
			return envelope.imethod_5(icoordinate_4) && envelope2.imethod_5(icoordinate_4);
		}
	}
}
