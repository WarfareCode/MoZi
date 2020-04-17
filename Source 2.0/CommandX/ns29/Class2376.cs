using System;
using System.Collections;

namespace ns29
{
	// Token: 0x02000176 RID: 374
	public sealed class Class2376 : IEnumerable, ICollection, IDictionary
	{
		// Token: 0x170000BA RID: 186
		public object this[int int_0]
		{
			get
			{
				return ((DictionaryEntry)this.arrayList_0[int_0]).Value;
			}
			set
			{
				if (int_0 < 0 || int_0 >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				object key = ((DictionaryEntry)this.arrayList_0[int_0]).Key;
				this.arrayList_0[int_0] = new DictionaryEntry(key, value);
				this.hashtable_0[key] = value;
			}
		}

		// Token: 0x170000BB RID: 187
		public object this[object key]
		{
			get
			{
				return this.hashtable_0[key];
			}
			set
			{
				if (this.hashtable_0.Contains(key))
				{
					this.hashtable_0[key] = value;
					this.hashtable_0[this.IndexOf(key)] = new DictionaryEntry(key, value);
				}
				else
				{
					this.Add(key, value);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0006AE6C File Offset: 0x0006906C
		public int Count
		{
			get
			{
				return this.arrayList_0.Count;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0006A0BC File Offset: 0x000682BC
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0006AE88 File Offset: 0x00069088
		public ICollection Keys
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < this.arrayList_0.Count; i++)
				{
					arrayList.Add(((DictionaryEntry)this.arrayList_0[i]).Key);
				}
				return arrayList;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0006AED8 File Offset: 0x000690D8
		public ICollection Values
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < this.arrayList_0.Count; i++)
				{
					arrayList.Add(((DictionaryEntry)this.arrayList_0[i]).Value);
				}
				return arrayList;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00008708 File Offset: 0x00006908
		public void Add(object key, object value)
		{
			this.hashtable_0.Add(key, value);
			this.arrayList_0.Add(new DictionaryEntry(key, value));
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0000872F File Offset: 0x0000692F
		public void Clear()
		{
			this.hashtable_0.Clear();
			this.arrayList_0.Clear();
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00008747 File Offset: 0x00006947
		public bool Contains(object key)
		{
			return this.hashtable_0.Contains(key);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00008755 File Offset: 0x00006955
		public void CopyTo(Array array, int index)
		{
			this.hashtable_0.CopyTo(array, index);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00008764 File Offset: 0x00006964
		public void Remove(object key)
		{
			this.hashtable_0.Remove(key);
			this.arrayList_0.RemoveAt(this.IndexOf(key));
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0006AF28 File Offset: 0x00069128
		public IEnumerator GetEnumerator()
		{
			return new Class2377(this.arrayList_0);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0006AF44 File Offset: 0x00069144
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Class2377(this.arrayList_0);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0006AF28 File Offset: 0x00069128
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Class2377(this.arrayList_0);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0006AF60 File Offset: 0x00069160
		private int IndexOf(object object_0)
		{
			int result;
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				if (((DictionaryEntry)this.arrayList_0[i]).Key.Equals(object_0))
				{
					int num = i;
					result = num;
					return result;
				}
			}
			result = -1;
			return result;
		}

		// Token: 0x04000389 RID: 905
		private Hashtable hashtable_0 = new Hashtable();

		// Token: 0x0400038A RID: 906
		private ArrayList arrayList_0 = new ArrayList();
	}
}
