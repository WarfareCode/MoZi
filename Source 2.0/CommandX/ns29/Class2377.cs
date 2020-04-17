using System;
using System.Collections;

namespace ns29
{
	// Token: 0x0200017E RID: 382
	public sealed class Class2377 : IEnumerator, IDictionaryEnumerator
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0006B1D4 File Offset: 0x000693D4
		public object Value
		{
			get
			{
				return this.Entry.Value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0006B1F4 File Offset: 0x000693F4
		public object Key
		{
			get
			{
				return this.Entry.Key;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0006B214 File Offset: 0x00069414
		public DictionaryEntry Entry
		{
			get
			{
				return this.method_0();
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0006B22C File Offset: 0x0006942C
		object IEnumerator.Current
		{
			get
			{
				if (this.int_0 < 0 || this.int_0 >= this.arrayList_0.Count)
				{
					throw new InvalidOperationException();
				}
				return this.arrayList_0[this.int_0];
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00008908 File Offset: 0x00006B08
		internal Class2377(ArrayList arrayList_1)
		{
			this.arrayList_0 = arrayList_1;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0006B274 File Offset: 0x00069474
		public DictionaryEntry method_0()
		{
			if (this.int_0 < 0 || this.int_0 >= this.arrayList_0.Count)
			{
				throw new InvalidOperationException();
			}
			return (DictionaryEntry)this.arrayList_0[this.int_0];
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0000891E File Offset: 0x00006B1E
		public bool MoveNext()
		{
			this.int_0++;
			return this.int_0 < this.arrayList_0.Count;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00008941 File Offset: 0x00006B41
		public void Reset()
		{
			this.int_0 = -1;
		}

		// Token: 0x04000397 RID: 919
		private int int_0 = -1;

		// Token: 0x04000398 RID: 920
		private ArrayList arrayList_0;
	}
}
