using System;
using System.Collections;
using ns13;
using ns14;

namespace ns12
{
	// Token: 0x02000362 RID: 866
	public sealed class Class574 : Class573
	{
		// Token: 0x06001492 RID: 5266 RVA: 0x0000E90F File Offset: 0x0000CB0F
		public Class574(Class573 class573_0) : base(class573_0.method_1(), class573_0.method_3(), class573_0.method_4(), new Class652(class573_0.method_2()))
		{
			this.method_8(class573_0);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00089410 File Offset: 0x00087610
		public IEnumerator method_7()
		{
			return this.ilist_0.GetEnumerator();
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0000E946 File Offset: 0x0000CB46
		public void method_8(Class573 class573_0)
		{
			this.ilist_0.Add(class573_0);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0008942C File Offset: 0x0008762C
		public  void vmethod_0()
		{
			bool flag = false;
			IEnumerator enumerator = this.method_7();
			while (enumerator.MoveNext())
			{
				Class573 @class = (Class573)enumerator.Current;
				if (@class.method_2().method_10())
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.class652_0 = new Class652(Enum143.const_3, Enum143.const_3, Enum143.const_3);
			}
			else
			{
				this.class652_0 = new Class652(Enum143.const_3);
			}
			for (int i = 0; i < 2; i++)
			{
				this.method_9(i);
				if (flag)
				{
					this.method_10(i);
				}
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x000894B0 File Offset: 0x000876B0
		private void method_9(int int_1)
		{
			int num = 0;
			bool flag = false;
			IEnumerator enumerator = this.method_7();
			Enum143 @enum;
			while (enumerator.MoveNext())
			{
				Class573 @class = (Class573)enumerator.Current;
				@enum = @class.method_2().method_2(int_1);
				if (@enum == Enum143.const_1)
				{
					num++;
				}
				if (@enum == Enum143.const_0)
				{
					flag = true;
				}
			}
			@enum = Enum143.const_3;
			if (flag)
			{
				@enum = Enum143.const_0;
			}
			if (num > 0)
			{
				@enum = Class640.smethod_1(num);
			}
			this.class652_0.method_4(int_1, @enum);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0000E955 File Offset: 0x0000CB55
		private void method_10(int int_1)
		{
			this.method_11(int_1, Enum140.const_1);
			this.method_11(int_1, Enum140.const_2);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00089534 File Offset: 0x00087734
		private void method_11(int int_1, Enum140 enum140_0)
		{
			IEnumerator enumerator = this.method_7();
			while (enumerator.MoveNext())
			{
				Class573 @class = (Class573)enumerator.Current;
				if (@class.method_2().method_10())
				{
					Enum143 @enum = @class.method_2().method_1(int_1, enum140_0);
					if (@enum == Enum143.const_0)
					{
						this.class652_0.method_3(int_1, enum140_0, Enum143.const_0);
						return;
					}
					if (@enum == Enum143.const_2)
					{
						this.class652_0.method_3(int_1, enum140_0, Enum143.const_2);
					}
				}
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0000E967 File Offset: 0x0000CB67
		public void method_12(Class666 class666_0)
		{
			Class581.smethod_0(this.class652_0, class666_0);
		}

		// Token: 0x040008B6 RID: 2230
		private IList ilist_0 = new ArrayList();
	}
}
