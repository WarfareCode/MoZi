using System;
using System.Collections;
using ns16;
using ns24;
using ns25;

namespace ns26
{
	// Token: 0x02000794 RID: 1940
	public sealed class Class2194 : Class2192
	{
		// Token: 0x0600301E RID: 12318 RVA: 0x00019E02 File Offset: 0x00018002
		public Class2194(Class2192 class2192_0) : base(class2192_0.vmethod_0(), class2192_0.vmethod_3(), class2192_0.vmethod_4(), new Class2217(class2192_0.vmethod_1()))
		{
			this.method_1(class2192_0);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x001098B4 File Offset: 0x00107AB4
		public  IList vmethod_12()
		{
			return this.ilist_0;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x001098CC File Offset: 0x00107ACC
		public  IEnumerator vmethod_13()
		{
			return this.ilist_0.GetEnumerator();
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00019E39 File Offset: 0x00018039
		public void method_1(Class2192 class2192_0)
		{
			this.ilist_0.Add(class2192_0);
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x001098E8 File Offset: 0x00107AE8
		public  void vmethod_11()
		{
			bool flag = false;
			IEnumerator enumerator = this.vmethod_13();
			while (enumerator.MoveNext())
			{
				Class2192 @class = (Class2192)enumerator.Current;
				if (@class.vmethod_1().vmethod_7())
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.vmethod_2(new Class2217(LocationType.Null, LocationType.Null, LocationType.Null));
			}
			else
			{
				this.vmethod_2(new Class2217(LocationType.Null));
			}
			for (int i = 0; i < 2; i++)
			{
				this.method_2(i);
				if (flag)
				{
					this.method_3(i);
				}
			}
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0010996C File Offset: 0x00107B6C
		private void method_2(int int_1)
		{
			int num = 0;
			bool flag = false;
			IEnumerator enumerator = this.vmethod_13();
			LocationType locationType;
			while (enumerator.MoveNext())
			{
				Class2192 @class = (Class2192)enumerator.Current;
				locationType = @class.vmethod_1().vmethod_2(int_1);
				if (locationType == LocationType.Boundary)
				{
					num++;
				}
				if (locationType == LocationType.Interior)
				{
					flag = true;
				}
			}
			locationType = LocationType.Null;
			if (flag)
			{
				locationType = LocationType.Interior;
			}
			if (num > 0)
			{
				locationType = GeometryGraph.DetermineBoundary(num);
			}
			this.vmethod_1().vmethod_4(int_1, locationType);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x00019E48 File Offset: 0x00018048
		private void method_3(int int_1)
		{
			this.method_4(int_1, Enum158.const_1);
			this.method_4(int_1, Enum158.const_2);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x001099F0 File Offset: 0x00107BF0
		private void method_4(int int_1, Enum158 enum158_0)
		{
			IEnumerator enumerator = this.vmethod_13();
			while (enumerator.MoveNext())
			{
				Class2192 @class = (Class2192)enumerator.Current;
				if (@class.vmethod_1().vmethod_7())
				{
					LocationType locationType = @class.vmethod_1().vmethod_1(int_1, enum158_0);
					if (locationType == LocationType.Interior)
					{
						this.vmethod_1().vmethod_3(int_1, enum158_0, LocationType.Interior);
						return;
					}
					if (locationType == LocationType.Exterior)
					{
						this.vmethod_1().vmethod_3(int_1, enum158_0, LocationType.Exterior);
					}
				}
			}
		}

		// Token: 0x04001676 RID: 5750
		private readonly IList ilist_0 = new ArrayList();
	}
}
