using System;
using System.Collections;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.GeometriesGraph;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x0200041F RID: 1055
	public sealed class Class641
	{
		// Token: 0x06001AB2 RID: 6834 RVA: 0x000111D2 File Offset: 0x0000F3D2
		public Class641(Class640[] class640_1)
		{
			this.class640_0 = class640_1;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000A0CC0 File Offset: 0x0009EEC0
		public Class666 method_0()
		{
			Class666 @class = new Class666();
			@class.method_0(Enum143.const_2, Enum143.const_2, Dimensions.Surface);
			Class666 result;
			if (!this.class640_0[0].method_5().imethod_8().imethod_9(this.class640_0[1].method_5().imethod_8()))
			{
				this.method_5(@class);
				result = @class;
			}
			else
			{
				this.class640_0[0].method_13(this.class596_0, false);
				this.class640_0[1].method_13(this.class596_0, false);
				Class647 class647_ = this.class640_0[0].method_14(this.class640_0[1], this.class596_0, false);
				this.method_4(0);
				this.method_4(1);
				this.method_3(0);
				this.method_3(1);
				this.method_10();
				this.method_2(class647_, @class);
				Class588 class2 = new Class588();
				IList ilist_ = class2.method_0(this.class640_0[0].method_0());
				this.method_1(ilist_);
				IList ilist_2 = class2.method_0(this.class640_0[1].method_0());
				this.method_1(ilist_2);
				this.method_6();
				this.method_8(0, 1);
				this.method_8(1, 0);
				this.method_7(@class);
				result = @class;
			}
			return result;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000A0DEC File Offset: 0x0009EFEC
		private void method_1(IList ilist_0)
		{
			IEnumerator enumerator = ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class573 class573_ = (Class573)enumerator.Current;
				this.nodes.method_1(class573_);
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000A0E24 File Offset: 0x0009F024
		private void method_2(Class647 class647_0, Class666 class666_0)
		{
			Dimensions dimensions = this.class640_0[0].method_5().imethod_7();
			Dimensions dimensions2 = this.class640_0[1].method_5().imethod_7();
			bool flag = class647_0.method_1();
			bool flag2 = class647_0.method_2();
			if (dimensions == Dimensions.Surface && dimensions2 == Dimensions.Surface)
			{
				if (flag)
				{
					class666_0.method_3("212101212");
				}
			}
			else if (dimensions == Dimensions.Surface && dimensions2 == Dimensions.Curve)
			{
				if (flag)
				{
					class666_0.method_3("FFF0FFFF2");
				}
				if (flag2)
				{
					class666_0.method_3("1FFFFF1FF");
				}
			}
			else if (dimensions == Dimensions.Curve && dimensions2 == Dimensions.Surface)
			{
				if (flag)
				{
					class666_0.method_3("F0FFFFFF2");
				}
				if (flag2)
				{
					class666_0.method_3("1F1FFFFFF");
				}
			}
			else if (dimensions == Dimensions.Curve && dimensions2 == Dimensions.Curve && flag2)
			{
				class666_0.method_3("0FFFFFFFF");
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x000A0F14 File Offset: 0x0009F114
		private void method_3(int int_0)
		{
			IEnumerator enumerator = this.class640_0[int_0].method_3();
			while (enumerator.MoveNext())
			{
				Class579 @class = (Class579)enumerator.Current;
				Class579 class2 = this.nodes.method_0(@class.vmethod_0());
				class2.method_5(int_0, @class.method_0().method_2(int_0));
			}
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000A0F6C File Offset: 0x0009F16C
		private void method_4(int int_0)
		{
			IEnumerator enumerator = this.class640_0[int_0].method_0();
			while (enumerator.MoveNext())
			{
				Class581 @class = (Class581)enumerator.Current;
				Enum143 @enum = @class.method_0().method_2(int_0);
				IEnumerator enumerator2 = @class.method_7().method_1();
				while (enumerator2.MoveNext())
				{
					Class649 class2 = (Class649)enumerator2.Current;
					Class580 class3 = (Class580)this.nodes.method_0(class2.method_0());
					if (@enum == Enum143.const_1)
					{
						class3.method_6(int_0);
					}
					else if (class3.method_0().method_8(int_0))
					{
						class3.method_5(int_0, Enum143.const_0);
					}
				}
			}
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000A101C File Offset: 0x0009F21C
		private void method_5(Class666 class666_0)
		{
			IGeometry geometry = this.class640_0[0].method_5();
			if (!geometry.imethod_10())
			{
				class666_0.method_0(Enum143.const_0, Enum143.const_2, geometry.imethod_7());
				class666_0.method_0(Enum143.const_1, Enum143.const_2, geometry.imethod_4());
			}
			IGeometry geometry2 = this.class640_0[1].method_5();
			if (!geometry2.imethod_10())
			{
				class666_0.method_0(Enum143.const_2, Enum143.const_0, geometry2.imethod_7());
				class666_0.method_0(Enum143.const_2, Enum143.const_1, geometry2.imethod_4());
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000A1090 File Offset: 0x0009F290
		private void method_6()
		{
			IEnumerator enumerator = this.nodes.method_3();
			while (enumerator.MoveNext())
			{
				Class580 @class = (Class580)enumerator.Current;
				@class.method_3().vmethod_1(this.class640_0);
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000A10D0 File Offset: 0x0009F2D0
		private void method_7(Class666 class666_0)
		{
			IEnumerator enumerator = this.arrayList_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class581 @class = (Class581)enumerator.Current;
				@class.method_2(class666_0);
			}
			IEnumerator enumerator2 = this.nodes.method_3();
			while (enumerator2.MoveNext())
			{
				Class580 class2 = (Class580)enumerator2.Current;
				class2.method_2(class666_0);
				class2.method_7(class666_0);
			}
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000A1138 File Offset: 0x0009F338
		private void method_8(int int_0, int int_1)
		{
			IEnumerator enumerator = this.class640_0[int_0].method_0();
			while (enumerator.MoveNext())
			{
				Class581 @class = (Class581)enumerator.Current;
				if (@class.vmethod_2())
				{
					this.method_9(@class, int_1, this.class640_0[int_1].method_5());
					this.arrayList_0.Add(@class);
				}
			}
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x000A1198 File Offset: 0x0009F398
		private void method_9(Class581 class581_0, int int_0, IGeometry igeometry_0)
		{
			if (igeometry_0.imethod_7() > Dimensions.Point)
			{
				Enum143 enum143_ = this.class631_0.method_0(class581_0.vmethod_0(), igeometry_0);
				class581_0.method_0().method_5(int_0, enum143_);
			}
			else
			{
				class581_0.method_0().method_5(int_0, Enum143.const_2);
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000A11E4 File Offset: 0x0009F3E4
		private void method_10()
		{
			IEnumerator enumerator = this.nodes.method_3();
			while (enumerator.MoveNext())
			{
				Class579 @class = (Class579)enumerator.Current;
				Class652 class2 = @class.method_0();
				Class570.smethod_0(class2.method_7() > 0, "node with empty label found");
				if (@class.vmethod_2())
				{
					if (class2.method_8(0))
					{
						this.method_11(@class, 0);
					}
					else
					{
						this.method_11(@class, 1);
					}
				}
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x000A1258 File Offset: 0x0009F458
		private void method_11(Class579 class579_0, int int_0)
		{
			Enum143 enum143_ = this.class631_0.method_0(class579_0.vmethod_0(), this.class640_0[int_0].method_5());
			class579_0.method_0().method_5(int_0, enum143_);
		}

		// Token: 0x04000B40 RID: 2880
		private Class596 class596_0 = new Class597();

		// Token: 0x04000B41 RID: 2881
		private Class631 class631_0 = new Class631();

		// Token: 0x04000B42 RID: 2882
		private Class640[] class640_0;

		// Token: 0x04000B43 RID: 2883
		private NodeMap nodes = new NodeMap(new Class583());

		// Token: 0x04000B44 RID: 2884
		private ArrayList arrayList_0 = new ArrayList();
	}
}
