using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns11
{
	// Token: 0x020002EF RID: 751
	public sealed class Class562
	{
		// Token: 0x06001182 RID: 4482 RVA: 0x0007FB70 File Offset: 0x0007DD70
		public Class562(byte[,] byte_3)
		{
			if (byte_3 == null)
			{
				throw new Exception("Grid cannot be null");
			}
			this.byte_0 = byte_3;
			this.ushort_4 = (ushort)(this.byte_0.GetUpperBound(0) + 1);
			this.ushort_5 = (ushort)(this.byte_0.GetUpperBound(1) + 1);
			this.ushort_6 = (ushort)(this.ushort_4 - 1);
			this.ushort_7 = (ushort)Math.Log((double)this.ushort_5, 2.0);
			if (Math.Log((double)this.ushort_4, 2.0) == (double)((int)Math.Log((double)this.ushort_4, 2.0)) && Math.Log((double)this.ushort_5, 2.0) == (double)((int)Math.Log((double)this.ushort_5, 2.0)))
			{
				if (this.struct55_0 == null || this.struct55_0.Length != (int)(this.ushort_4 * this.ushort_5))
				{
					this.struct55_0 = new Class562.Struct55[(int)(this.ushort_4 * this.ushort_5)];
				}
				this.class559_0 = new Class559<int>(new Class562.Class563(this.struct55_0));
				return;
			}
			throw new Exception("Invalid Grid, size in X and Y must be power of 2");
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0000D3C7 File Offset: 0x0000B5C7
		public void vmethod_0(Enum137 enum137_1)
		{
			this.enum137_0 = enum137_1;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0007FD20 File Offset: 0x0007DF20
		public void vmethod_1(bool bool_10)
		{
			this.bool_2 = bool_10;
			if (this.bool_2)
			{
				this.sbyte_0 = new sbyte[,]
				{
					{
						0,
						-1
					},
					{
						1,
						0
					},
					{
						0,
						1
					},
					{
						-1,
						0
					},
					{
						1,
						-1
					},
					{
						1,
						1
					},
					{
						-1,
						1
					},
					{
						-1,
						-1
					}
				};
			}
			else
			{
				this.sbyte_0 = new sbyte[,]
				{
					{
						0,
						-1
					},
					{
						1,
						0
					},
					{
						0,
						1
					},
					{
						-1,
						0
					}
				};
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		public void vmethod_2(bool bool_10)
		{
			this.bool_6 = bool_10;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0000D3D9 File Offset: 0x0000B5D9
		public void vmethod_3(bool bool_10)
		{
			this.bool_3 = bool_10;
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public void vmethod_4(bool bool_10)
		{
			this.bool_4 = bool_10;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0000D3EB File Offset: 0x0000B5EB
		public void vmethod_5(bool bool_10)
		{
			this.bool_5 = bool_10;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		public void vmethod_6(int int_9)
		{
			this.int_2 = int_9;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0000D3FD File Offset: 0x0000B5FD
		public void vmethod_7(bool bool_10)
		{
			this.bool_7 = bool_10;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0007FD74 File Offset: 0x0007DF74
		public List<Struct54> vmethod_8(Point point_0, Point point_1)
		{
			List<Struct54> list;
			List<Struct54> result;
			lock (this)
			{
				Class558.smethod_0();
				this.bool_9 = false;
				this.bool_0 = false;
				this.bool_1 = false;
				this.int_6 = 0;
				this.byte_1 += 2;
				this.byte_2 += 2;
				this.class559_0.method_1();
				this.list_0.Clear();
				if (this.bool_7 && this.delegate33_0 != null)
				{
					this.delegate33_0(0, 0, point_0.X, point_0.Y, Enum136.const_0, -1, -1);
				}
				if (this.bool_7 && this.delegate33_0 != null)
				{
					this.delegate33_0(0, 0, point_1.X, point_1.Y, Enum136.const_1, -1, -1);
				}
				this.int_4 = (point_0.Y << (int)this.ushort_7) + point_0.X;
				this.int_7 = (point_1.Y << (int)this.ushort_7) + point_1.X;
				this.struct55_0[this.int_4].int_1 = 0;
				this.struct55_0[this.int_4].int_0 = this.int_1;
				this.struct55_0[this.int_4].ushort_0 = (ushort)point_0.X;
				this.struct55_0[this.int_4].ushort_1 = (ushort)point_0.Y;
				this.struct55_0[this.int_4].byte_0 = this.byte_1;
				this.class559_0.vmethod_1(this.int_4);
				while (this.class559_0.method_2() > 0 && !this.bool_0)
				{
					this.int_4 = this.class559_0.vmethod_2();
					if (this.struct55_0[this.int_4].byte_0 != this.byte_2)
					{
						this.ushort_0 = (ushort)(this.int_4 & (int)this.ushort_6);
						this.ushort_1 = (ushort)(this.int_4 >> (int)this.ushort_7);
						if (this.bool_7 && this.delegate33_0 != null)
						{
							this.delegate33_0(0, 0, this.int_4 & (int)this.ushort_6, this.int_4 >> (int)this.ushort_7, Enum136.const_4, -1, -1);
						}
						if (this.int_4 == this.int_7)
						{
							this.struct55_0[this.int_4].byte_0 = this.byte_2;
							this.bool_9 = true;
							break;
						}
						if (this.int_6 > this.int_2)
						{
							this.bool_1 = true;
							this.double_0 = Class558.smethod_1();
							list = null;
							result = list;
							return result;
						}
						if (this.bool_3)
						{
							this.int_0 = (int)(this.ushort_0 - this.struct55_0[this.int_4].ushort_0);
						}
						for (int i = 0; i < (this.bool_2 ? 8 : 4); i++)
						{
							this.ushort_2 = (ushort)(this.ushort_0 + (ushort)this.sbyte_0[i, 0]);
							this.ushort_3 = (ushort)(this.ushort_1 + (ushort)this.sbyte_0[i, 1]);
							this.int_5 = ((int)this.ushort_3 << (int)this.ushort_7) + (int)this.ushort_2;
							if (this.ushort_2 < this.ushort_4 && this.ushort_3 < this.ushort_5 && (this.struct55_0[this.int_5].byte_0 != this.byte_2 || this.bool_4) && this.byte_0[(int)this.ushort_2, (int)this.ushort_3] != 0)
							{
								if (this.bool_6 && i > 3)
								{
									this.int_8 = this.struct55_0[this.int_4].int_1 + (int)((double)this.byte_0[(int)this.ushort_2, (int)this.ushort_3] * 2.41);
								}
								else
								{
									this.int_8 = this.struct55_0[this.int_4].int_1 + (int)this.byte_0[(int)this.ushort_2, (int)this.ushort_3];
								}
								if (this.bool_3)
								{
									if (this.ushort_2 - this.ushort_0 != 0 && this.int_0 == 0)
									{
										this.int_8 += Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y);
									}
									if (this.ushort_3 - this.ushort_1 != 0 && this.int_0 != 0)
									{
										this.int_8 += Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y);
									}
								}
								if (this.struct55_0[this.int_5].byte_0 == this.byte_1)
								{
									goto IL_4FE;
								}
								if (this.struct55_0[this.int_5].byte_0 == this.byte_2)
								{
									goto IL_4FE;
								}
								bool arg_51F_0 = false;
								IL_51F:
								if (!arg_51F_0)
								{
									this.struct55_0[this.int_5].ushort_0 = this.ushort_0;
									this.struct55_0[this.int_5].ushort_1 = this.ushort_1;
									this.struct55_0[this.int_5].int_1 = this.int_8;
									switch (this.enum137_0)
									{
									case Enum137.const_0:
										this.int_3 = this.int_1 * (Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y));
										break;
									case Enum137.const_1:
										this.int_3 = this.int_1 * Math.Max(Math.Abs((int)this.ushort_2 - point_1.X), Math.Abs((int)this.ushort_3 - point_1.Y));
										break;
									case Enum137.const_2:
									{
										int num = Math.Min(Math.Abs((int)this.ushort_2 - point_1.X), Math.Abs((int)this.ushort_3 - point_1.Y));
										int num2 = Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y);
										this.int_3 = this.int_1 * 2 * num + this.int_1 * (num2 - 2 * num);
										break;
									}
									case Enum137.const_3:
										this.int_3 = (int)((double)this.int_1 * Math.Sqrt(Math.Pow((double)((int)this.ushort_3 - point_1.X), 2.0) + Math.Pow((double)((int)this.ushort_3 - point_1.Y), 2.0)));
										break;
									case Enum137.const_4:
										this.int_3 = (int)((double)this.int_1 * (Math.Pow((double)((int)this.ushort_2 - point_1.X), 2.0) + Math.Pow((double)((int)this.ushort_3 - point_1.Y), 2.0)));
										break;
									case Enum137.const_5:
									{
										Point point = new Point(Math.Abs(point_1.X - (int)this.ushort_2), Math.Abs(point_1.Y - (int)this.ushort_3));
										int num3 = Math.Abs(point.X - point.Y);
										int num4 = Math.Abs((point.X + point.Y - num3) / 2);
										this.int_3 = this.int_1 * (num4 + num3 + point.X + point.Y);
										break;
									}
									default:
										this.int_3 = this.int_1 * (Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y));
										break;
									}
									if (this.bool_5)
									{
										int num5 = (int)this.ushort_0 - point_1.X;
										int num6 = (int)this.ushort_1 - point_1.Y;
										int num7 = point_0.X - point_1.X;
										int num8 = point_0.Y - point_1.Y;
										int num9 = Math.Abs(num5 * num8 - num7 * num6);
										this.int_3 = (int)((double)this.int_3 + (double)num9 * 0.001);
									}
									this.struct55_0[this.int_5].int_0 = this.int_8 + this.int_3;
									if (this.bool_7 && this.delegate33_0 != null)
									{
										this.delegate33_0((int)this.ushort_0, (int)this.ushort_1, (int)this.ushort_2, (int)this.ushort_3, Enum136.const_2, this.struct55_0[this.int_5].int_0, this.struct55_0[this.int_5].int_1);
									}
									this.class559_0.vmethod_1(this.int_5);
									this.struct55_0[this.int_5].byte_0 = this.byte_1;
									goto IL_920;
								}
								goto IL_920;
								IL_4FE:
								arg_51F_0 = (this.struct55_0[this.int_5].int_1 <= this.int_8);
								goto IL_51F;
							}
							IL_920:;
						}
						this.int_6++;
						this.struct55_0[this.int_4].byte_0 = this.byte_2;
						if (this.bool_7 && this.delegate33_0 != null)
						{
							this.delegate33_0(0, 0, (int)this.ushort_0, (int)this.ushort_1, Enum136.const_3, this.struct55_0[this.int_4].int_0, this.struct55_0[this.int_4].int_1);
						}
					}
				}
				this.double_0 = Class558.smethod_1();
				if (this.bool_9)
				{
					this.list_0.Clear();
					int x = point_1.X;
					int y = point_1.Y;
					Class562.Struct55 @struct = this.struct55_0[(point_1.Y << (int)this.ushort_7) + point_1.X];
					Struct54 item;
					item.int_0 = @struct.int_0;
					item.int_1 = @struct.int_1;
					item.int_2 = 0;
					item.int_5 = (int)@struct.ushort_0;
					item.int_6 = (int)@struct.ushort_1;
					item.int_3 = point_1.X;
					item.int_4 = point_1.Y;
					while (item.int_3 != item.int_5 || item.int_4 != item.int_6)
					{
						this.list_0.Add(item);
						if (this.bool_8 && this.delegate33_0 != null)
						{
							this.delegate33_0(item.int_5, item.int_6, item.int_3, item.int_4, Enum136.const_5, item.int_0, item.int_1);
						}
						x = item.int_5;
						y = item.int_6;
						@struct = this.struct55_0[(y << (int)this.ushort_7) + x];
						item.int_0 = @struct.int_0;
						item.int_1 = @struct.int_1;
						item.int_2 = 0;
						item.int_5 = (int)@struct.ushort_0;
						item.int_6 = (int)@struct.ushort_1;
						item.int_3 = x;
						item.int_4 = y;
					}
					this.list_0.Add(item);
					if (this.bool_8 && this.delegate33_0 != null)
					{
						this.delegate33_0(item.int_5, item.int_6, item.int_3, item.int_4, Enum136.const_5, item.int_0, item.int_1);
					}
					this.bool_1 = true;
					list = this.list_0;
				}
				else
				{
					this.bool_1 = true;
					list = null;
				}
			}
			result = list;
			return result;
		}

		// Token: 0x04000710 RID: 1808
		[CompilerGenerated]
		private Delegate33 delegate33_0;

		// Token: 0x04000711 RID: 1809
		private byte[,] byte_0;

		// Token: 0x04000712 RID: 1810
		private Class559<int> class559_0;

		// Token: 0x04000713 RID: 1811
		private List<Struct54> list_0 = new List<Struct54>();

		// Token: 0x04000714 RID: 1812
		private bool bool_0;

		// Token: 0x04000715 RID: 1813
		private bool bool_1 = true;

		// Token: 0x04000716 RID: 1814
		private int int_0;

		// Token: 0x04000717 RID: 1815
		private Enum137 enum137_0 = Enum137.const_0;

		// Token: 0x04000718 RID: 1816
		private bool bool_2 = true;

		// Token: 0x04000719 RID: 1817
		private int int_1 = 2;

		// Token: 0x0400071A RID: 1818
		private bool bool_3;

		// Token: 0x0400071B RID: 1819
		private bool bool_4 = true;

		// Token: 0x0400071C RID: 1820
		private bool bool_5;

		// Token: 0x0400071D RID: 1821
		private bool bool_6;

		// Token: 0x0400071E RID: 1822
		private int int_2 = 2000;

		// Token: 0x0400071F RID: 1823
		private double double_0;

		// Token: 0x04000720 RID: 1824
		private bool bool_7;

		// Token: 0x04000721 RID: 1825
		private bool bool_8;

		// Token: 0x04000722 RID: 1826
		private Class562.Struct55[] struct55_0;

		// Token: 0x04000723 RID: 1827
		private byte byte_1 = 1;

		// Token: 0x04000724 RID: 1828
		private byte byte_2 = 2;

		// Token: 0x04000725 RID: 1829
		private int int_3 = 0;

		// Token: 0x04000726 RID: 1830
		private int int_4;

		// Token: 0x04000727 RID: 1831
		private int int_5;

		// Token: 0x04000728 RID: 1832
		private ushort ushort_0;

		// Token: 0x04000729 RID: 1833
		private ushort ushort_1;

		// Token: 0x0400072A RID: 1834
		private ushort ushort_2;

		// Token: 0x0400072B RID: 1835
		private ushort ushort_3;

		// Token: 0x0400072C RID: 1836
		private int int_6;

		// Token: 0x0400072D RID: 1837
		private ushort ushort_4;

		// Token: 0x0400072E RID: 1838
		private ushort ushort_5;

		// Token: 0x0400072F RID: 1839
		private ushort ushort_6;

		// Token: 0x04000730 RID: 1840
		private ushort ushort_7;

		// Token: 0x04000731 RID: 1841
		private bool bool_9;

		// Token: 0x04000732 RID: 1842
		private sbyte[,] sbyte_0 = new sbyte[,]
		{
			{
				0,
				-1
			},
			{
				1,
				0
			},
			{
				0,
				1
			},
			{
				-1,
				0
			},
			{
				1,
				-1
			},
			{
				1,
				1
			},
			{
				-1,
				1
			},
			{
				-1,
				-1
			}
		};

		// Token: 0x04000733 RID: 1843
		private int int_7;

		// Token: 0x04000734 RID: 1844
		private int int_8;

		// Token: 0x020002F0 RID: 752
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Struct55
		{
			// Token: 0x04000735 RID: 1845
			public int int_0;

			// Token: 0x04000736 RID: 1846
			public int int_1;

			// Token: 0x04000737 RID: 1847
			public ushort ushort_0;

			// Token: 0x04000738 RID: 1848
			public ushort ushort_1;

			// Token: 0x04000739 RID: 1849
			public byte byte_0;
		}

		// Token: 0x020002F1 RID: 753
		public sealed class Class563 : IComparer<int>
		{
			// Token: 0x0600118C RID: 4492 RVA: 0x0000D406 File Offset: 0x0000B606
			public Class563(Class562.Struct55[] struct55_1)
			{
				this.struct55_0 = struct55_1;
			}

			// Token: 0x0600118D RID: 4493 RVA: 0x00080A10 File Offset: 0x0007EC10
			public int Compare(int x, int y)
			{
				int result;
				if (this.struct55_0[x].int_0 > this.struct55_0[y].int_0)
				{
					result = 1;
				}
				else if (this.struct55_0[x].int_0 < this.struct55_0[y].int_0)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
				return result;
			}

			// Token: 0x0400073A RID: 1850
			private Class562.Struct55[] struct55_0;
		}
	}
}
