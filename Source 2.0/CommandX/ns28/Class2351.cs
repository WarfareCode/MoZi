using System;
using System.Collections;
using System.Collections.Generic;

namespace ns28
{
	// Token: 0x02000802 RID: 2050
	public sealed class Class2351<T> : IEnumerable<T>, ICollection<T>, IEnumerable
	{
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x00118C04 File Offset: 0x00116E04
		public int Count
		{
			get
			{
				return this.dictionary_0.Count;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x0001B298 File Offset: 0x00019498
		public void Add(T t)
		{
			this.dictionary_0.Add(t, t);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x0001B2A7 File Offset: 0x000194A7
		public void Clear()
		{
			this.dictionary_0.Clear();
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0001B2B4 File Offset: 0x000194B4
		public bool Contains(T t)
		{
			return this.dictionary_0.ContainsKey(t);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x0001B2C2 File Offset: 0x000194C2
		public void CopyTo(T[] tArray, int num)
		{
			this.dictionary_0.Keys.CopyTo(tArray, num);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00118C20 File Offset: 0x00116E20
		public IEnumerator<T> GetEnumerator()
		{
			return this.dictionary_0.Keys.GetEnumerator();
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x0001B2D6 File Offset: 0x000194D6
		public bool Remove(T t)
		{
			return this.dictionary_0.Remove(t);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00118C44 File Offset: 0x00116E44
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.dictionary_0.Keys.GetEnumerator();
		}

		// Token: 0x04001795 RID: 6037
		private readonly Dictionary<T, T> dictionary_0;
	}
}
