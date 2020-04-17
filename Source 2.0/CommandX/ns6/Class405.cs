using System;
using System.Collections.Generic;

namespace ns6
{
	// Token: 0x02000C85 RID: 3205
	public sealed class Class405<T> where T : Interface7
	{
		// Token: 0x06006A37 RID: 27191 RVA: 0x0002DBE9 File Offset: 0x0002BDE9
		public Class405()
		{
			this.icomparer_0 = Comparer<T>.Default;
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x0002DC07 File Offset: 0x0002BE07
		public Class405(IComparer<T> icomparer_1)
		{
			this.icomparer_0 = icomparer_1;
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x0002DC21 File Offset: 0x0002BE21
		public Class405(IComparer<T> icomparer_1, int int_0)
		{
			this.icomparer_0 = icomparer_1;
			this.list_0.Capacity = int_0;
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x00390BE4 File Offset: 0x0038EDE4
		protected void method_0(int int_0, int int_1)
		{
			T value = this.list_0[int_0];
			this.list_0[int_0] = this.list_0[int_1];
			this.list_0[int_1] = value;
			T t = this.list_0[int_0];
			t.imethod_2(int_0);
			t = this.list_0[int_1];
			t.imethod_2(int_1);
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x00390C5C File Offset: 0x0038EE5C
		protected  int vmethod_0(int int_0, int int_1)
		{
			return this.icomparer_0.Compare(this.list_0[int_0], this.list_0[int_1]);
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x00390C90 File Offset: 0x0038EE90
		public int method_1(T gparam_0)
		{
			int num = this.list_0.Count;
			gparam_0.imethod_2(this.list_0.Count);
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

		// Token: 0x06006A3D RID: 27197 RVA: 0x00390CF8 File Offset: 0x0038EEF8
		public T method_2()
		{
			T result = this.list_0[0];
			int num = 0;
			this.list_0[0] = this.list_0[this.list_0.Count - 1];
			T t = this.list_0[0];
			t.imethod_2(0);
			this.list_0.RemoveAt(this.list_0.Count - 1);
			result.imethod_2(-1);
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

		// Token: 0x06006A3E RID: 27198 RVA: 0x00390DF0 File Offset: 0x0038EFF0
		public void method_3(T gparam_0)
		{
			int count = this.list_0.Count;
			while (gparam_0.imethod_1() - 1 >= 0 && this.vmethod_0(gparam_0.imethod_1() - 1, gparam_0.imethod_1()) > 0)
			{
				this.method_0(gparam_0.imethod_1() - 1, gparam_0.imethod_1());
			}
			while (gparam_0.imethod_1() + 1 < count && this.vmethod_0(gparam_0.imethod_1() + 1, gparam_0.imethod_1()) < 0)
			{
				this.method_0(gparam_0.imethod_1() + 1, gparam_0.imethod_1());
			}
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x0002DC47 File Offset: 0x0002BE47
		public void method_4()
		{
			this.list_0.Clear();
		}

		// Token: 0x04003BFD RID: 15357
		protected List<T> list_0 = new List<T>();

		// Token: 0x04003BFE RID: 15358
		protected IComparer<T> icomparer_0;
	}
}
