using System;
using System.Collections;
using System.Collections.Generic;
using Iesi_NTS.Collections;
using Iesi_NTS.Collections.Generic;

namespace ns14
{
	// Token: 0x0200045E RID: 1118
	public sealed class Class660<T> : IEnumerable<T>, ICollection<T>, Iesi_NTS.Collections.Generic.ISet<T>, IEnumerable, ICloneable
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x000B56E4 File Offset: 0x000B38E4
		public int Count
		{
			get
			{
				return this.iset_0.Count;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class660()
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00011DA6 File Offset: 0x0000FFA6
		public Class660(ISet iset_1)
		{
			if (iset_1 == null)
			{
				throw new ArgumentNullException();
			}
			this.iset_0 = iset_1;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00011DC4 File Offset: 0x0000FFC4
		public bool Contains(T item)
		{
			return this.iset_0.Contains(item);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00011DD7 File Offset: 0x0000FFD7
		public bool vmethod_0(T gparam_0)
		{
			return this.iset_0.Add(gparam_0);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00011DEA File Offset: 0x0000FFEA
		public bool Remove(T item)
		{
			return this.iset_0.imethod_0(item);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00011DFD File Offset: 0x0000FFFD
		public void Clear()
		{
			this.iset_0.Clear();
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x000B5700 File Offset: 0x000B3900
		public Iesi_NTS.Collections.Generic.ISet<T> vmethod_1()
		{
			return new Class660<T>((ISet)this.iset_0.Clone());
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00011E0A File Offset: 0x0001000A
		void ICollection<T>.Add(T item)
		{
			this.vmethod_0(item);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00011E14 File Offset: 0x00010014
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.iset_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000B5724 File Offset: 0x000B3924
		public IEnumerator<T> GetEnumerator()
		{
			return new Struct59<T>(this.iset_0.GetEnumerator());
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000B5748 File Offset: 0x000B3948
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.iset_0.GetEnumerator();
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000B5764 File Offset: 0x000B3964
		object ICloneable.Clone()
		{
			return this.vmethod_1();
		}

		// Token: 0x04000C7E RID: 3198
		private ISet iset_0;
	}
}
