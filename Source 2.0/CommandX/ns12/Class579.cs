using System;
using GeoAPI.Geometries;
using ns13;
using ns14;

namespace ns12
{
	// Token: 0x0200036A RID: 874
	public class Class579 : Class578
	{
		// Token: 0x060014B5 RID: 5301 RVA: 0x0000EA27 File Offset: 0x0000CC27
		public Class579(ICoordinate icoordinate_1, Class624 class624_1)
		{
			this.icoordinate_0 = icoordinate_1;
			this.class624_0 = class624_1;
			this.class652_0 = new Class652(0, Enum143.const_3);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000899E8 File Offset: 0x00087BE8
		public override ICoordinate vmethod_0()
		{
			return this.icoordinate_0;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00089A00 File Offset: 0x00087C00
		public Class624 method_3()
		{
			return this.class624_0;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0000EA58 File Offset: 0x0000CC58
		public override bool vmethod_2()
		{
			return this.class652_0.method_7() == 1;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void vmethod_1(Class666 class666_0)
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0000EA68 File Offset: 0x0000CC68
		public void method_4(Class573 class573_0)
		{
			this.class624_0.vmethod_0(class573_0);
			class573_0.method_5(this);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0000EA7D File Offset: 0x0000CC7D
		public void method_5(int int_0, Enum143 enum143_0)
		{
			if (this.class652_0 == null)
			{
				this.class652_0 = new Class652(int_0, enum143_0);
			}
			else
			{
				this.class652_0.method_4(int_0, enum143_0);
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00089A18 File Offset: 0x00087C18
		public void method_6(int int_0)
		{
			Enum143 enum143_;
			if (this.class652_0 != null)
			{
				switch (this.class652_0.method_2(int_0))
				{
				case Enum143.const_0:
					enum143_ = Enum143.const_1;
					goto IL_32;
				case Enum143.const_1:
					enum143_ = Enum143.const_0;
					goto IL_32;
				}
			}
			enum143_ = Enum143.const_1;
			IL_32:
			this.class652_0.method_4(int_0, enum143_);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00089A64 File Offset: 0x00087C64
		public override string ToString()
		{
			return this.icoordinate_0 + " " + this.class624_0;
		}

		// Token: 0x040008C9 RID: 2249
		protected ICoordinate icoordinate_0 = null;

		// Token: 0x040008CA RID: 2250
		protected Class624 class624_0 = null;
	}
}
