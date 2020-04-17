using System;

namespace ns25
{
	// Token: 0x020005AE RID: 1454
	public sealed class Class2216 : IComparable
	{
		// Token: 0x0600251C RID: 9500 RVA: 0x0001531B File Offset: 0x0001351B
		public Class2216(object object_2, double double_1, Class2216 class2216_1, object object_3)
		{
			this.object_1 = object_2;
			this.double_0 = double_1;
			this.class2216_0 = class2216_1;
			this.int_0 = 1;
			if (class2216_1 != null)
			{
				this.int_0 = 2;
			}
			this.object_0 = object_3;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000E3A2C File Offset: 0x000E1C2C
		public  object vmethod_0()
		{
			return this.object_1;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00015354 File Offset: 0x00013554
		public   bool vmethod_1()
		{
			return this.class2216_0 == null;
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0001535F File Offset: 0x0001355F
		public   bool vmethod_2()
		{
			return this.class2216_0 != null;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000E3A44 File Offset: 0x000E1C44
		public Class2216 method_0()
		{
			return this.class2216_0;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000E3A5C File Offset: 0x000E1C5C
		public  int vmethod_3()
		{
			return this.int_1;
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0001536D File Offset: 0x0001356D
		public  void vmethod_4(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000E3A74 File Offset: 0x000E1C74
		public  object vmethod_5()
		{
			return this.object_0;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000E3A8C File Offset: 0x000E1C8C
		public  int CompareTo(object target)
		{
			Class2216 @class = (Class2216)target;
			int result;
			if (this.double_0 < @class.double_0)
			{
				result = -1;
			}
			else if (this.double_0 > @class.double_0)
			{
				result = 1;
			}
			else if (this.int_0 < @class.int_0)
			{
				result = -1;
			}
			else if (this.int_0 > @class.int_0)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x040011DA RID: 4570
		private readonly int int_0;

		// Token: 0x040011DB RID: 4571
		private readonly Class2216 class2216_0;

		// Token: 0x040011DC RID: 4572
		private readonly object object_0;

		// Token: 0x040011DD RID: 4573
		private readonly double double_0;

		// Token: 0x040011DE RID: 4574
		private int int_1;

		// Token: 0x040011DF RID: 4575
		private object object_1;
	}
}
