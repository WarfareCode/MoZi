using System;
using System.Collections;
using System.Collections.Generic;
using ns11;

namespace ns12
{
	// Token: 0x02000358 RID: 856
	public sealed class Class568<T> : Class567<T>, IEnumerable<T>, IList<T>, ICollection<T>, IEnumerable
	{
		// Token: 0x170001B6 RID: 438
		public T this[int index]
		{
			get
			{
				return (T)((object)this.ilist_0[index]);
			}
			set
			{
				this.ilist_0[index] = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0008827C File Offset: 0x0008647C
		public int Count
		{
			get
			{
				return this.ilist_0.Count;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0000E555 File Offset: 0x0000C755
		public bool IsReadOnly
		{
			get
			{
				return this.ilist_0.IsReadOnly;
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0000E562 File Offset: 0x0000C762
		public Class568(IList ilist_1) : base(ilist_1)
		{
			this.ilist_0 = ilist_1;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00088298 File Offset: 0x00086498
		public int IndexOf(T item)
		{
			return this.ilist_0.IndexOf(item);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0000E572 File Offset: 0x0000C772
		public void Insert(int index, T item)
		{
			this.ilist_0.Insert(index, item);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0000E586 File Offset: 0x0000C786
		public void RemoveAt(int index)
		{
			this.ilist_0.Remove(index);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0000E599 File Offset: 0x0000C799
		public void Add(T item)
		{
			this.ilist_0.Add(item);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0000E5AD File Offset: 0x0000C7AD
		public void Clear()
		{
			this.ilist_0.Clear();
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0000E5BA File Offset: 0x0000C7BA
		public bool Contains(T item)
		{
			return this.ilist_0.Contains(item);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0000E5CD File Offset: 0x0000C7CD
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.ilist_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x000882B8 File Offset: 0x000864B8
		public bool Remove(T item)
		{
			bool result;
			if (!this.ilist_0.Contains(item))
			{
				result = false;
			}
			else
			{
				this.ilist_0.Remove(item);
				result = true;
			}
			return result;
		}

		// Token: 0x04000869 RID: 2153
		private IList ilist_0;
	}
}
