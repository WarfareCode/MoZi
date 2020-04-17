using System;
using System.Collections;

namespace ns19
{
	// Token: 0x0200043B RID: 1083
	public sealed class Class1978 : IDisposable
	{
		// Token: 0x06001BC4 RID: 7108 RVA: 0x0001171F File Offset: 0x0000F91F
		public Class1978()
		{
			Class1979.class1978_0 = this;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000B23A8 File Offset: 0x000B05A8
		public  void vmethod_0(object object_0)
		{
			object syncRoot = this.arrayList_0.SyncRoot;
			lock (syncRoot)
			{
				for (int i = this.arrayList_0.Count - 1; i >= 0; i--)
				{
					Class1979 @class = (Class1979)this.arrayList_0[i];
					if (@class.method_0() == object_0)
					{
						this.arrayList_0.RemoveAt(i);
						@class.Dispose();
					}
				}
			}
			this.vmethod_2();
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000B2444 File Offset: 0x000B0644
		protected  Class1979 vmethod_1()
		{
			Class1979 result = null;
			float num = -3.40282347E+38f;
			object syncRoot = this.arrayList_0.SyncRoot;
			lock (syncRoot)
			{
				for (int i = this.arrayList_0.Count - 1; i >= 0; i--)
				{
					Class1979 @class = (Class1979)this.arrayList_0[i];
					if (!@class.vmethod_0())
					{
						float num2 = @class.vmethod_2();
						if (float.IsNegativeInfinity(num2))
						{
							this.arrayList_0.RemoveAt(i);
							@class.Dispose();
						}
						else if (num2 > num)
						{
							num = num2;
							result = @class;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000B2510 File Offset: 0x000B0710
		protected  void vmethod_2()
		{
			object syncRoot = this.arrayList_0.SyncRoot;
			lock (syncRoot)
			{
				for (int i = this.arrayList_1.Count - 1; i >= 0; i--)
				{
					if (!((Class1979)this.arrayList_1[i]).vmethod_0())
					{
						this.arrayList_1.RemoveAt(i);
					}
				}
				while (this.arrayList_1.Count < Class1978.int_1)
				{
					Class1979 @class = this.vmethod_1();
					if (@class == null)
					{
						break;
					}
					this.arrayList_1.Add(@class);
					@class.vmethod_1();
				}
			}
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000B25D4 File Offset: 0x000B07D4
		internal void method_0(Class1979 class1979_0)
		{
			object syncRoot = this.arrayList_0.SyncRoot;
			lock (syncRoot)
			{
				this.arrayList_0.Remove(class1979_0);
				class1979_0.Dispose();
			}
			this.vmethod_2();
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000B2630 File Offset: 0x000B0830
		public void Dispose()
		{
			object syncRoot = this.arrayList_0.SyncRoot;
			lock (syncRoot)
			{
                IEnumerator enumerator = this.arrayList_0.GetEnumerator();
				{
					while (enumerator.MoveNext())
					{
						((Class1979)enumerator.Current).Dispose();
					}
				}
				this.arrayList_0.Clear();
				this.arrayList_1.Clear();
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000BEF RID: 3055
		public static int int_0 = 200;

		// Token: 0x04000BF0 RID: 3056
		public static int int_1 = 2;

		// Token: 0x04000BF1 RID: 3057
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000BF2 RID: 3058
		private ArrayList arrayList_1 = new ArrayList();
	}
}
