using System;
using System.Text;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x02000415 RID: 1045
	public sealed class Class581 : Class578
	{
		// Token: 0x06001A70 RID: 6768 RVA: 0x000A004C File Offset: 0x0009E24C
		public static void smethod_0(Class652 class652_1, Class666 class666_0)
		{
			class666_0.method_2(class652_1.method_1(0, Enum140.const_0), class652_1.method_1(1, Enum140.const_0), Dimensions.Curve);
			if (class652_1.method_10())
			{
				class666_0.method_2(class652_1.method_1(0, Enum140.const_1), class652_1.method_1(1, Enum140.const_1), Dimensions.Surface);
				class666_0.method_2(class652_1.method_1(0, Enum140.const_2), class652_1.method_1(1, Enum140.const_2), Dimensions.Surface);
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000A00AC File Offset: 0x0009E2AC
		public Class581(ICoordinate[] icoordinate_1, Class652 class652_1)
		{
			this.class622_0 = new Class622(this);
			this.icoordinate_0 = icoordinate_1;
			this.class652_0 = class652_1;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000A00FC File Offset: 0x0009E2FC
		public ICoordinate[] method_3()
		{
			return this.icoordinate_0;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x000A0114 File Offset: 0x0009E314
		public int method_4()
		{
			return this.method_3().Length;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000A012C File Offset: 0x0009E32C
		public ICoordinate[] method_5()
		{
			return this.method_3();
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000A0144 File Offset: 0x0009E344
		public ICoordinate method_6(int int_1)
		{
			return this.method_3()[int_1];
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000A015C File Offset: 0x0009E35C
		public override ICoordinate vmethod_0()
		{
			ICoordinate result;
			if (this.method_3().Length > 0)
			{
				result = this.method_3()[0];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000A018C File Offset: 0x0009E38C
		public Class622 method_7()
		{
			return this.class622_0;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000A01A4 File Offset: 0x0009E3A4
		public Class621 method_8()
		{
			if (this.class621_0 == null)
			{
				this.class621_0 = new Class621(this);
			}
			return this.class621_0;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00011016 File Offset: 0x0000F216
		public bool method_9()
		{
			return this.method_3()[0].Equals(this.method_3()[this.method_3().Length - 1]);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00011036 File Offset: 0x0000F236
		public void method_10(bool bool_5)
		{
			this.bool_4 = bool_5;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0001103F File Offset: 0x0000F23F
		public override bool vmethod_2()
		{
			return this.bool_4;
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000A01D4 File Offset: 0x0009E3D4
		public void method_11(Class596 class596_0, int int_1, int int_2)
		{
			for (int i = 0; i < class596_0.method_5(); i++)
			{
				this.method_12(class596_0, int_1, int_2, i);
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000A0200 File Offset: 0x0009E400
		public void method_12(Class596 class596_0, int int_1, int int_2, int int_3)
		{
			ICoordinate coordinate = new Coordinate(class596_0.method_6(int_3));
			int num = int_1;
			double double_ = class596_0.method_9(int_2, int_3);
			int num2 = num + 1;
			if (num2 < this.method_3().Length)
			{
				ICoordinate coordinate2 = this.method_3()[num2];
				if (coordinate.imethod_8(coordinate2))
				{
					num = num2;
					double_ = 0.0;
				}
				this.method_7().method_0(coordinate, num, double_);
			}
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00011047 File Offset: 0x0000F247
		public override void vmethod_1(Class666 class666_0)
		{
			Class581.smethod_0(this.class652_0, class666_0);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00011055 File Offset: 0x0000F255
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class581 && this.method_13(obj as Class581);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000A0270 File Offset: 0x0009E470
		protected bool method_13(Class581 class581_0)
		{
			bool flag;
			bool result;
			if (this.method_3().Length != class581_0.method_3().Length)
			{
				flag = false;
			}
			else
			{
				bool flag2 = true;
				bool flag3 = true;
				int num = this.method_3().Length;
				for (int i = 0; i < this.method_3().Length; i++)
				{
					if (!this.method_3()[i].imethod_8(class581_0.method_3()[i]))
					{
						flag2 = false;
					}
					if (!this.method_3()[i].imethod_8(class581_0.method_3()[--num]))
					{
						flag3 = false;
					}
					if (!flag2 && !flag3)
					{
						result = false;
						return result;
					}
				}
				flag = true;
			}
			result = flag;
			return result;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000A0310 File Offset: 0x0009E510
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("edge " + this.string_0 + ": ");
			stringBuilder.Append("LINESTRING (");
			for (int i = 0; i < this.method_3().Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(this.method_3()[i].imethod_0() + " " + this.method_3()[i].imethod_2());
			}
			stringBuilder.Append(string.Concat(new object[]
			{
				")  ",
				this.class652_0,
				" ",
				this.int_0
			}));
			return stringBuilder.ToString();
		}

		// Token: 0x04000B2A RID: 2858
		private ICoordinate[] icoordinate_0;

		// Token: 0x04000B2B RID: 2859
		private Class622 class622_0 = null;

		// Token: 0x04000B2C RID: 2860
		private string string_0;

		// Token: 0x04000B2D RID: 2861
		private Class621 class621_0;

		// Token: 0x04000B2E RID: 2862
		private bool bool_4 = true;

		// Token: 0x04000B2F RID: 2863
		private Class623 class623_0 = new Class623();

		// Token: 0x04000B30 RID: 2864
		private int int_0 = 0;
	}
}
