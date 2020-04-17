using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ClipperLib;

namespace ns28
{
	// Token: 0x020000F9 RID: 249
	public sealed class Class2364
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00065A7C File Offset: 0x00063C7C
		[CompilerGenerated]
		public double method_0()
		{
			return this.double_6;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00006EF0 File Offset: 0x000050F0
		[CompilerGenerated]
		public void method_1(double double_8)
		{
			this.double_6 = double_8;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00065A94 File Offset: 0x00063C94
		[CompilerGenerated]
		public double method_2()
		{
			return this.double_7;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00006EF9 File Offset: 0x000050F9
		[CompilerGenerated]
		public void method_3(double double_8)
		{
			this.double_7 = double_8;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00065AAC File Offset: 0x00063CAC
		public Class2364(double miterLimit = 2.0, double arcTolerance = 0.25)
		{
			this.method_3(miterLimit);
			this.method_1(arcTolerance);
			this.intPoint_0.long_0 = -1L;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000636A0 File Offset: 0x000618A0
		internal static long smethod_0(double double_8)
		{
			long result;
			if (double_8 >= 0.0)
			{
				result = (long)(double_8 + 0.5);
			}
			else
			{
				result = (long)(double_8 - 0.5);
			}
			return result;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00065B54 File Offset: 0x00063D54
		public void method_4(List<IntPoint> list_4, Enum165 enum165_0, Enum166 enum166_0)
		{
			int num = list_4.Count - 1;
			if (num >= 0)
			{
				Class2353 @class = new Class2353();
				@class.enum165_0 = enum165_0;
				@class.enum166_0 = enum166_0;
				if (enum166_0 == Enum166.const_1 || enum166_0 == Enum166.const_0)
				{
					while (num > 0 && IntPoint.smethod_0(list_4[0], list_4[num]))
					{
						num--;
					}
				}
				@class.list_0.Capacity = num + 1;
				@class.list_0.Add(list_4[0]);
				int num2 = 0;
				int num3 = 0;
				for (int i = 1; i <= num; i++)
				{
					if (IntPoint.smethod_1(@class.list_0[num2], list_4[i]))
					{
						num2++;
						@class.list_0.Add(list_4[i]);
						if (list_4[i].long_1 > @class.list_0[num3].long_1 || (list_4[i].long_1 == @class.list_0[num3].long_1 && list_4[i].long_0 < @class.list_0[num3].long_0))
						{
							num3 = num2;
						}
					}
				}
				if ((enum166_0 != Enum166.const_0 || num2 >= 2) && (enum166_0 == Enum166.const_0 || num2 >= 0))
				{
					this.class2353_0.method_1(@class);
					if (enum166_0 == Enum166.const_0)
					{
						if (this.intPoint_0.long_0 < 0L)
						{
							this.intPoint_0 = new IntPoint(0L, (long)num3);
						}
						else
						{
							IntPoint intPoint = this.class2353_0.method_2()[(int)this.intPoint_0.long_0].list_0[(int)this.intPoint_0.long_1];
							if (@class.list_0[num3].long_1 > intPoint.long_1 || (@class.list_0[num3].long_1 == intPoint.long_1 && @class.list_0[num3].long_0 < intPoint.long_0))
							{
								this.intPoint_0 = new IntPoint((long)(this.class2353_0.method_0() - 1), (long)num3);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00065DB0 File Offset: 0x00063FB0
		public void method_5(List<List<IntPoint>> list_4, Enum165 enum165_0, Enum166 enum166_0)
		{
			foreach (List<IntPoint> current in list_4)
			{
				this.method_4(current, enum165_0, enum166_0);
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00065E04 File Offset: 0x00064004
		private void method_6()
		{
			if (this.intPoint_0.long_0 >= 0L && !Class2363.smethod_9(this.class2353_0.method_2()[(int)this.intPoint_0.long_0].list_0))
			{
				for (int i = 0; i < this.class2353_0.method_0(); i++)
				{
					Class2353 @class = this.class2353_0.method_2()[i];
					if (@class.enum166_0 == Enum166.const_0 || (@class.enum166_0 == Enum166.const_1 && Class2363.smethod_9(@class.list_0)))
					{
						@class.list_0.Reverse();
					}
				}
			}
			else
			{
				for (int j = 0; j < this.class2353_0.method_0(); j++)
				{
					Class2353 class2 = this.class2353_0.method_2()[j];
					if (class2.enum166_0 == Enum166.const_1 && !Class2363.smethod_9(class2.list_0))
					{
						class2.list_0.Reverse();
					}
				}
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00065F00 File Offset: 0x00064100
		internal static Struct68 smethod_1(IntPoint intPoint_1, IntPoint intPoint_2)
		{
			double num = (double)(intPoint_2.long_0 - intPoint_1.long_0);
			double num2 = (double)(intPoint_2.long_1 - intPoint_1.long_1);
			Struct68 result;
			if (num == 0.0 && num2 == 0.0)
			{
				result = default(Struct68);
			}
			else
			{
				double num3 = 1.0 / Math.Sqrt(num * num + num2 * num2);
				num *= num3;
				num2 *= num3;
				result = new Struct68(num2, -num);
			}
			return result;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00065F88 File Offset: 0x00064188
		private void method_7(double double_8)
		{
			this.list_0 = new List<List<IntPoint>>();
			this.double_0 = double_8;
			if (Class2362.smethod_0(double_8))
			{
				this.list_0.Capacity = this.class2353_0.method_0();
				for (int i = 0; i < this.class2353_0.method_0(); i++)
				{
					Class2353 @class = this.class2353_0.method_2()[i];
					if (@class.enum166_0 == Enum166.const_0)
					{
						this.list_0.Add(@class.list_0);
					}
				}
			}
			else
			{
				if (this.method_2() > 2.0)
				{
					this.double_4 = 2.0 / (this.method_2() * this.method_2());
				}
				else
				{
					this.double_4 = 0.5;
				}
				double num;
				if (this.method_0() <= 0.0)
				{
					num = 0.25;
				}
				else if (this.method_0() > Math.Abs(double_8) * 0.25)
				{
					num = Math.Abs(double_8) * 0.25;
				}
				else
				{
					num = this.method_0();
				}
				double num2 = 3.1415926535897931 / Math.Acos(1.0 - num / Math.Abs(double_8));
				this.double_2 = Math.Sin(6.2831853071795862 / num2);
				this.double_3 = Math.Cos(6.2831853071795862 / num2);
				this.double_5 = num2 / 6.2831853071795862;
				if (double_8 < 0.0)
				{
					this.double_2 = -this.double_2;
				}
				this.list_0.Capacity = this.class2353_0.method_0() * 2;
				for (int j = 0; j < this.class2353_0.method_0(); j++)
				{
					Class2353 class2 = this.class2353_0.method_2()[j];
					this.list_1 = class2.list_0;
					int count = this.list_1.Count;
					if (count != 0 && (double_8 > 0.0 || (count >= 3 && class2.enum166_0 == Enum166.const_0)))
					{
						this.list_2 = new List<IntPoint>();
						if (count == 1)
						{
							if (class2.enum165_0 == Enum165.const_1)
							{
								double num3 = 1.0;
								double num4 = 0.0;
								int num5 = 1;
								while ((double)num5 <= num2)
								{
									this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[0].long_0 + num3 * double_8), Class2364.smethod_0((double)this.list_1[0].long_1 + num4 * double_8)));
									double num6 = num3;
									num3 = num3 * this.double_3 - this.double_2 * num4;
									num4 = num6 * this.double_2 + num4 * this.double_3;
									num5++;
								}
							}
							else
							{
								double num7 = -1.0;
								double num8 = -1.0;
								for (int k = 0; k < 4; k++)
								{
									this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[0].long_0 + num7 * double_8), Class2364.smethod_0((double)this.list_1[0].long_1 + num8 * double_8)));
									if (num7 < 0.0)
									{
										num7 = 1.0;
									}
									else if (num8 < 0.0)
									{
										num8 = 1.0;
									}
									else
									{
										num7 = -1.0;
									}
								}
							}
							this.list_0.Add(this.list_2);
						}
						else
						{
							this.list_3.Clear();
							this.list_3.Capacity = count;
							for (int l = 0; l < count - 1; l++)
							{
								this.list_3.Add(Class2364.smethod_1(this.list_1[l], this.list_1[l + 1]));
							}
							if (class2.enum166_0 != Enum166.const_1 && class2.enum166_0 != Enum166.const_0)
							{
								this.list_3.Add(new Struct68(this.list_3[count - 2]));
							}
							else
							{
								this.list_3.Add(Class2364.smethod_1(this.list_1[count - 1], this.list_1[0]));
							}
							if (class2.enum166_0 == Enum166.const_0)
							{
								int num9 = count - 1;
								for (int m = 0; m < count; m++)
								{
									this.method_9(m, ref num9, class2.enum165_0);
								}
								this.list_0.Add(this.list_2);
							}
							else if (class2.enum166_0 == Enum166.const_1)
							{
								int num10 = count - 1;
								for (int n = 0; n < count; n++)
								{
									this.method_9(n, ref num10, class2.enum165_0);
								}
								this.list_0.Add(this.list_2);
								this.list_2 = new List<IntPoint>();
								Struct68 @struct = this.list_3[count - 1];
								for (int num11 = count - 1; num11 > 0; num11--)
								{
									this.list_3[num11] = new Struct68(-this.list_3[num11 - 1].double_0, -this.list_3[num11 - 1].double_1);
								}
								this.list_3[0] = new Struct68(-@struct.double_0, -@struct.double_1);
								num10 = 0;
								for (int num12 = count - 1; num12 >= 0; num12--)
								{
									this.method_9(num12, ref num10, class2.enum165_0);
								}
								this.list_0.Add(this.list_2);
							}
							else
							{
								int num13 = 0;
								for (int num14 = 1; num14 < count - 1; num14++)
								{
									this.method_9(num14, ref num13, class2.enum165_0);
								}
								if (class2.enum166_0 == Enum166.const_2)
								{
									int index = count - 1;
									IntPoint item = new IntPoint(Class2364.smethod_0((double)this.list_1[index].long_0 + this.list_3[index].double_0 * double_8), Class2364.smethod_0((double)this.list_1[index].long_1 + this.list_3[index].double_1 * double_8));
									this.list_2.Add(item);
									item = new IntPoint(Class2364.smethod_0((double)this.list_1[index].long_0 - this.list_3[index].double_0 * double_8), Class2364.smethod_0((double)this.list_1[index].long_1 - this.list_3[index].double_1 * double_8));
									this.list_2.Add(item);
								}
								else
								{
									int num15 = count - 1;
									num13 = count - 2;
									this.double_1 = 0.0;
									this.list_3[num15] = new Struct68(-this.list_3[num15].double_0, -this.list_3[num15].double_1);
									if (class2.enum166_0 == Enum166.const_3)
									{
										this.method_10(num15, num13);
									}
									else
									{
										this.method_12(num15, num13);
									}
								}
								for (int num16 = count - 1; num16 > 0; num16--)
								{
									this.list_3[num16] = new Struct68(-this.list_3[num16 - 1].double_0, -this.list_3[num16 - 1].double_1);
								}
								this.list_3[0] = new Struct68(-this.list_3[1].double_0, -this.list_3[1].double_1);
								num13 = count - 1;
								for (int num17 = num13 - 1; num17 > 0; num17--)
								{
									this.method_9(num17, ref num13, class2.enum165_0);
								}
								if (class2.enum166_0 == Enum166.const_2)
								{
									IntPoint item = new IntPoint(Class2364.smethod_0((double)this.list_1[0].long_0 - this.list_3[0].double_0 * double_8), Class2364.smethod_0((double)this.list_1[0].long_1 - this.list_3[0].double_1 * double_8));
									this.list_2.Add(item);
									item = new IntPoint(Class2364.smethod_0((double)this.list_1[0].long_0 + this.list_3[0].double_0 * double_8), Class2364.smethod_0((double)this.list_1[0].long_1 + this.list_3[0].double_1 * double_8));
									this.list_2.Add(item);
								}
								else
								{
									num13 = 1;
									this.double_1 = 0.0;
									if (class2.enum166_0 == Enum166.const_3)
									{
										this.method_10(0, 1);
									}
									else
									{
										this.method_12(0, 1);
									}
								}
								this.list_0.Add(this.list_2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00066918 File Offset: 0x00064B18
		public void method_8(ref List<List<IntPoint>> list_4, double double_8)
		{
			list_4.Clear();
			this.method_6();
			this.method_7(double_8);
			Class2363 @class = new Class2363(0);
			@class.method_8(this.list_0, Enum163.const_0, true);
			if (double_8 > 0.0)
			{
				@class.method_20(Enum162.const_1, list_4, Enum164.const_2, Enum164.const_2);
			}
			else
			{
				Struct70 @struct = Class2362.smethod_4(this.list_0);
				@class.method_7(new List<IntPoint>(4)
				{
					new IntPoint(@struct.long_0 - 10L, @struct.long_3 + 10L),
					new IntPoint(@struct.long_2 + 10L, @struct.long_3 + 10L),
					new IntPoint(@struct.long_2 + 10L, @struct.long_1 - 10L),
					new IntPoint(@struct.long_0 - 10L, @struct.long_1 - 10L)
				}, Enum163.const_0, true);
				@class.method_16(true);
				@class.method_20(Enum162.const_1, list_4, Enum164.const_3, Enum164.const_3);
				if (list_4.Count > 0)
				{
					list_4.RemoveAt(0);
				}
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00066A6C File Offset: 0x00064C6C
		private void method_9(int int_0, ref int int_1, Enum165 enum165_0)
		{
			this.double_1 = this.list_3[int_1].double_0 * this.list_3[int_0].double_1 - this.list_3[int_0].double_0 * this.list_3[int_1].double_1;
			if (this.double_1 >= 5E-05 || this.double_1 <= -5E-05)
			{
				if (this.double_1 > 1.0)
				{
					this.double_1 = 1.0;
				}
				else if (this.double_1 < -1.0)
				{
					this.double_1 = -1.0;
				}
				if (this.double_1 * this.double_0 < 0.0)
				{
					this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[int_0].long_0 + this.list_3[int_1].double_0 * this.double_0), Class2364.smethod_0((double)this.list_1[int_0].long_1 + this.list_3[int_1].double_1 * this.double_0)));
					this.list_2.Add(this.list_1[int_0]);
					this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[int_0].long_0 + this.list_3[int_0].double_0 * this.double_0), Class2364.smethod_0((double)this.list_1[int_0].long_1 + this.list_3[int_0].double_1 * this.double_0)));
				}
				else
				{
					switch (enum165_0)
					{
					case Enum165.const_0:
						this.method_10(int_0, int_1);
						break;
					case Enum165.const_1:
						this.method_12(int_0, int_1);
						break;
					case Enum165.const_2:
					{
						double num = 1.0 + (this.list_3[int_0].double_0 * this.list_3[int_1].double_0 + this.list_3[int_0].double_1 * this.list_3[int_1].double_1);
						if (num >= this.double_4)
						{
							this.method_11(int_0, int_1, num);
						}
						else
						{
							this.method_10(int_0, int_1);
						}
						break;
					}
					}
				}
				int_1 = int_0;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00066D08 File Offset: 0x00064F08
		internal void method_10(int int_0, int int_1)
		{
			double num = Math.Tan(Math.Atan2(this.double_1, this.list_3[int_1].double_0 * this.list_3[int_0].double_0 + this.list_3[int_1].double_1 * this.list_3[int_0].double_1) / 4.0);
			this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[int_0].long_0 + this.double_0 * (this.list_3[int_1].double_0 - this.list_3[int_1].double_1 * num)), Class2364.smethod_0((double)this.list_1[int_0].long_1 + this.double_0 * (this.list_3[int_1].double_1 + this.list_3[int_1].double_0 * num))));
			this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[int_0].long_0 + this.double_0 * (this.list_3[int_0].double_0 + this.list_3[int_0].double_1 * num)), Class2364.smethod_0((double)this.list_1[int_0].long_1 + this.double_0 * (this.list_3[int_0].double_1 - this.list_3[int_0].double_0 * num))));
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00066EA8 File Offset: 0x000650A8
		internal void method_11(int int_0, int int_1, double double_8)
		{
			double num = this.double_0 / double_8;
			this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[int_0].long_0 + (this.list_3[int_1].double_0 + this.list_3[int_0].double_0) * num), Class2364.smethod_0((double)this.list_1[int_0].long_1 + (this.list_3[int_1].double_1 + this.list_3[int_0].double_1) * num)));
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00066F48 File Offset: 0x00065148
		internal void method_12(int int_0, int int_1)
		{
			double value = Math.Atan2(this.double_1, this.list_3[int_1].double_0 * this.list_3[int_0].double_0 + this.list_3[int_1].double_1 * this.list_3[int_0].double_1);
			int num = (int)Class2364.smethod_0(this.double_5 * Math.Abs(value));
			double num2 = this.list_3[int_1].double_0;
			double num3 = this.list_3[int_1].double_1;
			for (int i = 0; i < num; i++)
			{
				this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[int_0].long_0 + num2 * this.double_0), Class2364.smethod_0((double)this.list_1[int_0].long_1 + num3 * this.double_0)));
				double num4 = num2;
				num2 = num2 * this.double_3 - this.double_2 * num3;
				num3 = num4 * this.double_2 + num3 * this.double_3;
			}
			this.list_2.Add(new IntPoint(Class2364.smethod_0((double)this.list_1[int_0].long_0 + this.list_3[int_0].double_0 * this.double_0), Class2364.smethod_0((double)this.list_1[int_0].long_1 + this.list_3[int_0].double_1 * this.double_0)));
		}

		// Token: 0x0400026E RID: 622
		private List<List<IntPoint>> list_0;

		// Token: 0x0400026F RID: 623
		private List<IntPoint> list_1;

		// Token: 0x04000270 RID: 624
		private List<IntPoint> list_2;

		// Token: 0x04000271 RID: 625
		private List<Struct68> list_3 = new List<Struct68>();

		// Token: 0x04000272 RID: 626
		private double double_0;

		// Token: 0x04000273 RID: 627
		private double double_1;

		// Token: 0x04000274 RID: 628
		private double double_2 = 0.0;

		// Token: 0x04000275 RID: 629
		private double double_3 = 0.0;

		// Token: 0x04000276 RID: 630
		private double double_4 = 0.0;

		// Token: 0x04000277 RID: 631
		private double double_5 = 0.0;

		// Token: 0x04000278 RID: 632
		private IntPoint intPoint_0;

		// Token: 0x04000279 RID: 633
		private Class2353 class2353_0 = new Class2353();

		// Token: 0x0400027A RID: 634
		[CompilerGenerated]
		private double double_6 = 0.0;

		// Token: 0x0400027B RID: 635
		[CompilerGenerated]
		private double double_7 = 0.0;
	}
}
