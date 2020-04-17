using System;
using System.Collections;
using ns25;
using ns28;

namespace ns24
{
	// Token: 0x02000566 RID: 1382
	public sealed class Class2196 : Class2195
	{
		// Token: 0x060023B1 RID: 9137 RVA: 0x000E0798 File Offset: 0x000DE998
		public override void vmethod_3(Class2192 class2192_0)
		{
			Class2193 @class = (Class2193)class2192_0;
			base.method_2(@class, @class);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x000E07B4 File Offset: 0x000DE9B4
		public  int vmethod_6(Class2205 class2205_0)
		{
			int num = 0;
			IEnumerator enumerator = this.vmethod_4();
			while (enumerator.MoveNext())
			{
				Class2193 @class = (Class2193)enumerator.Current;
				if (@class.vmethod_15() == class2205_0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x000E07F8 File Offset: 0x000DE9F8
		public  Class2193 vmethod_7()
		{
			IList list = this.vmethod_1();
			int count = list.Count;
			Class2193 result;
			if (count < 1)
			{
				result = null;
			}
			else
			{
				Class2193 @class = (Class2193)list[0];
				if (count == 1)
				{
					result = @class;
				}
				else
				{
					Class2193 class2 = (Class2193)list[count - 1];
					int int_ = @class.vmethod_5();
					int int_2 = class2.vmethod_5();
					if (Class2223.smethod_2(int_) && Class2223.smethod_2(int_2))
					{
						result = @class;
					}
					else if (!Class2223.smethod_2(int_) && !Class2223.smethod_2(int_2))
					{
						result = class2;
					}
					else if (@class.vmethod_6() != 0.0)
					{
						result = @class;
					}
					else
					{
						if (class2.vmethod_6() == 0.0)
						{
							throw new Exception18();
						}
						result = class2;
					}
				}
			}
			return result;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x000E08D0 File Offset: 0x000DEAD0
		private void method_6()
		{
			if (this.ilist_1 == null)
			{
				this.ilist_1 = new ArrayList();
				IEnumerator enumerator = this.vmethod_4();
				while (enumerator.MoveNext())
				{
					Class2193 @class = (Class2193)enumerator.Current;
					if (@class.vmethod_18() || @class.vmethod_29().vmethod_18())
					{
						this.ilist_1.Add(@class);
					}
				}
			}
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000E0938 File Offset: 0x000DEB38
		public  void vmethod_8()
		{
			this.method_6();
			Class2193 @class = null;
			Class2193 class2 = null;
			int num = 1;
			for (int i = 0; i < this.ilist_1.Count; i++)
			{
				Class2193 class3 = (Class2193)this.ilist_1[i];
				Class2193 class4 = class3.vmethod_29();
				if (class3.vmethod_1().vmethod_7())
				{
					if (@class == null && class3.vmethod_18())
					{
						@class = class3;
					}
					switch (num)
					{
					case 1:
						if (class4.vmethod_18())
						{
							class2 = class4;
							num = 2;
						}
						break;
					case 2:
						if (class3.vmethod_18())
						{
							if (class2 != null)
							{
								class2.vmethod_26(class3);
							}
							num = 1;
						}
						break;
					}
				}
			}
			if (num == 2)
			{
				if (@class == null)
				{
					throw new TopologyException("no outgoing dirEdge found", this.vmethod_0());
				}
				Class2347.smethod_1(@class.vmethod_18(), "unable to link last incoming dirEdge");
				if (class2 != null)
				{
					class2.vmethod_26(@class);
				}
			}
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x000E0A38 File Offset: 0x000DEC38
		public  void vmethod_9(Class2205 class2205_0)
		{
			Class2193 @class = null;
			Class2193 class2 = null;
			int num = 1;
			for (int i = this.ilist_1.Count - 1; i >= 0; i--)
			{
				Class2193 class3 = (Class2193)this.ilist_1[i];
				Class2193 class4 = class3.vmethod_29();
				if (@class == null && class3.vmethod_15() == class2205_0)
				{
					@class = class3;
				}
				switch (num)
				{
				case 1:
					if (class4.vmethod_15() == class2205_0)
					{
						class2 = class4;
						num = 2;
					}
					break;
				case 2:
					if (class3.vmethod_15() == class2205_0)
					{
						if (class2 != null)
						{
							class2.vmethod_28(class3);
						}
						num = 1;
					}
					break;
				}
			}
			if (num == 2)
			{
				Class2347.smethod_1(@class != null, "found null for first outgoing dirEdge");
				if (@class != null)
				{
					Class2347.smethod_1(@class.vmethod_15() == class2205_0, "unable to link last incoming dirEdge");
					if (class2 != null)
					{
						class2.vmethod_28(@class);
					}
				}
			}
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x000E0B30 File Offset: 0x000DED30
		public  void vmethod_10(Class2193 class2193_0)
		{
			int num = this.vmethod_5(class2193_0);
			int int_ = class2193_0.vmethod_12(Enum158.const_1);
			int num2 = class2193_0.vmethod_12(Enum158.const_2);
			int int_2 = this.method_7(num + 1, base.method_1().Count, int_);
			int num3 = this.method_7(0, num, int_2);
			if (num3 != num2)
			{
				throw new TopologyException("depth mismatch at " + class2193_0.vmethod_3());
			}
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x000E0B94 File Offset: 0x000DED94
		private int method_7(int int_0, int int_1, int int_2)
		{
			int num = int_2;
			for (int i = int_0; i < int_1; i++)
			{
				Class2193 @class = (Class2193)base.method_1()[i];
				@class.vmethod_14(Enum158.const_2, num);
				num = @class.vmethod_12(Enum158.const_1);
			}
			return num;
		}

		// Token: 0x04001142 RID: 4418
		private IList ilist_1;
	}
}
