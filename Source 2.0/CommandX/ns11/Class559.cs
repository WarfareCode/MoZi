using System;
using System.Collections.Generic;

namespace ns11
{
	// Token: 0x020002D1 RID: 721
	public sealed class Class559<T>
	{
		// Token: 0x1700017D RID: 381
		public T this[int int_0]
		{
			get
			{
				return this.list_0[int_0];
			}
			set
			{
				this.list_0[int_0] = value;
				this.vmethod_3(int_0);
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0000CEBA File Offset: 0x0000B0BA
		public Class559()
		{
			this.icomparer_0 = Comparer<T>.Default;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0000CED8 File Offset: 0x0000B0D8
		public Class559(IComparer<T> icomparer_1)
		{
			this.icomparer_0 = icomparer_1;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0000CEF2 File Offset: 0x0000B0F2
		public Class559(IComparer<T> icomparer_1, int int_0)
		{
			this.icomparer_0 = icomparer_1;
			this.list_0.Capacity = int_0;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0007EB28 File Offset: 0x0007CD28
		protected void method_0(int int_0, int int_1)
		{
			T value = this.list_0[int_0];
			this.list_0[int_0] = this.list_0[int_1];
			this.list_0[int_1] = value;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0007EB68 File Offset: 0x0007CD68
		protected  int vmethod_0(int int_0, int int_1)
		{
			return this.icomparer_0.Compare(this.list_0[int_0], this.list_0[int_1]);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0007EB9C File Offset: 0x0007CD9C
		public int vmethod_1(T gparam_0)
		{
			int num = this.list_0.Count;
			this.list_0.Add(gparam_0);
			while (num != 0)
			{
				int num2 = (num - 1) / 2;
				if (this.vmethod_0(num, num2) >= 0)
				{
					break;
				}
				this.method_0(num, num2);
				num = num2;
			}
			return num;
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0007EBEC File Offset: 0x0007CDEC
		public T vmethod_2()
		{
			T result = this.list_0[0];
			int num = 0;
			this.list_0[0] = this.list_0[this.list_0.Count - 1];
			this.list_0.RemoveAt(this.list_0.Count - 1);
			while (true)
			{
				int num2 = num;
				int num3 = 2 * num + 1;
				int num4 = 2 * num + 2;
				if (this.list_0.Count > num3 && this.vmethod_0(num, num3) > 0)
				{
					num = num3;
				}
				if (this.list_0.Count > num4 && this.vmethod_0(num, num4) > 0)
				{
					num = num4;
				}
				if (num == num2)
				{
					break;
				}
				this.method_0(num, num2);
			}
			return result;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0007ECB8 File Offset: 0x0007CEB8
		public void vmethod_3(int int_0)
		{
			int num;
			int num2;
			for (num = int_0; num != 0; num = num2)
			{
				num2 = (num - 1) / 2;
				if (this.vmethod_0(num, num2) >= 0)
				{
					break;
				}
				this.method_0(num, num2);
			}
			if (num >= int_0)
			{
				while (true)
				{
					int num3 = num;
					int num4 = 2 * num + 1;
					num2 = 2 * num + 2;
					if (this.list_0.Count > num4 && this.vmethod_0(num, num4) > 0)
					{
						num = num4;
					}
					if (this.list_0.Count > num2 && this.vmethod_0(num, num2) > 0)
					{
						num = num2;
					}
					if (num == num3)
					{
						break;
					}
					this.method_0(num, num3);
				}
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0000CF18 File Offset: 0x0000B118
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0007ED64 File Offset: 0x0007CF64
		public int method_2()
		{
			return this.list_0.Count;
		}

		// Token: 0x040006CA RID: 1738
		protected List<T> list_0 = new List<T>();

		// Token: 0x040006CB RID: 1739
		protected IComparer<T> icomparer_0;
	}
}
