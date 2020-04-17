using System;
using ns28;

namespace ns23
{
	// Token: 0x0200065F RID: 1631
	public sealed class Class2255 : Class2254
	{
		// Token: 0x0600299D RID: 10653 RVA: 0x00016CDE File Offset: 0x00014EDE
		public Class2255(Class2252 class2252_1, int int_1)
		{
			this.class2252_0 = class2252_1;
			this.int_0 = int_1;
			this.double_0 = (class2252_1.vmethod_0() + class2252_1.vmethod_2()) / 2.0;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000FDA4C File Offset: 0x000FBC4C
		public  Class2252 vmethod_3()
		{
			return this.class2252_0;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000FDA64 File Offset: 0x000FBC64
		public static Class2255 smethod_1(Class2252 class2252_1)
		{
			Class2253 @class = new Class2253(class2252_1);
			return new Class2255(@class.vmethod_1(), @class.vmethod_0());
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000FDA8C File Offset: 0x000FBC8C
		public static Class2255 smethod_2(Class2255 class2255_1, Class2252 class2252_1)
		{
			Class2252 @class = new Class2252(class2252_1);
			if (class2255_1 != null)
			{
				@class.vmethod_5(class2255_1.class2252_0);
			}
			Class2255 class2 = Class2255.smethod_1(@class);
			if (class2255_1 != null)
			{
				class2.vmethod_6(class2255_1);
			}
			return class2;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00016D11 File Offset: 0x00014F11
		protected override bool vmethod_2(Class2252 class2252_1)
		{
			return class2252_1.vmethod_6(this.class2252_0);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000FDACC File Offset: 0x000FBCCC
		public  Class2255 vmethod_4(Class2252 class2252_1)
		{
			int num = Class2254.smethod_0(class2252_1, this.double_0);
			Class2255 result;
			if (num != -1)
			{
				Class2255 @class = this.method_0(num);
				result = @class.vmethod_4(class2252_1);
			}
			else
			{
				result = this;
			}
			return result;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000FDB04 File Offset: 0x000FBD04
		public  Class2254 vmethod_5(Class2252 class2252_1)
		{
			int num = Class2254.smethod_0(class2252_1, this.double_0);
			Class2254 result;
			if (num == -1)
			{
				result = this;
			}
			else if (this.Nodes[num] != null)
			{
				Class2255 @class = this.Nodes[num];
				result = @class.vmethod_5(class2252_1);
			}
			else
			{
				result = this;
			}
			return result;
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000FDB50 File Offset: 0x000FBD50
		public  void vmethod_6(Class2255 class2255_1)
		{
			Class2347.smethod_0(this.class2252_0 == null || this.class2252_0.vmethod_8(class2255_1.vmethod_3()));
			int num = Class2254.smethod_0(class2255_1.class2252_0, this.double_0);
			if (class2255_1.int_0 == this.int_0 - 1)
			{
				this.Nodes[num] = class2255_1;
			}
			else
			{
				Class2255 @class = this.method_1(num);
				@class.vmethod_6(class2255_1);
				this.Nodes[num] = @class;
			}
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000FDBC8 File Offset: 0x000FBDC8
		private Class2255 method_0(int int_1)
		{
			if (this.Nodes[int_1] == null)
			{
				this.Nodes[int_1] = this.method_1(int_1);
			}
			return this.Nodes[int_1];
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000FDC00 File Offset: 0x000FBE00
		private Class2255 method_1(int int_1)
		{
			double double_ = 0.0;
			double double_2 = 0.0;
			switch (int_1)
			{
			case 0:
				double_ = this.class2252_0.vmethod_0();
				double_2 = this.double_0;
				break;
			case 1:
				double_ = this.double_0;
				double_2 = this.class2252_0.vmethod_2();
				break;
			}
			Class2252 class2252_ = new Class2252(double_, double_2);
			return new Class2255(class2252_, this.int_0 - 1);
		}

		// Token: 0x040013F5 RID: 5109
		private readonly double double_0;

		// Token: 0x040013F6 RID: 5110
		private readonly Class2252 class2252_0;

		// Token: 0x040013F7 RID: 5111
		private readonly int int_0;
	}
}
