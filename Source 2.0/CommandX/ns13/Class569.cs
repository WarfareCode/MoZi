using System;
using System.Collections;
using System.Collections.Generic;
using ns11;

namespace ns13
{
	// Token: 0x020003E5 RID: 997
	public sealed class Class569<T> : Class567<T>, IEnumerable<T>, ICollection<T>, IEnumerable
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x000993EC File Offset: 0x000975EC
		public int Count
		{
			get
			{
				return this.icollection_0.Count;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0000945D File Offset: 0x0000765D
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0001059F File Offset: 0x0000E79F
		public Class569(ICollection collections) : base(collections)
		{
			this.icollection_0 = collections;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000105AF File Offset: 0x0000E7AF
		public void Add(T t)
		{
			this.method_0();
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000105AF File Offset: 0x0000E7AF
		public void Clear()
		{
			this.method_0();
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00099408 File Offset: 0x00097608
		public bool Contains(T t)
		{
			bool result;
			foreach (object current in this.icollection_0)
			{
                //if ((object)t == current)
                if (current.Equals((object)t) )
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000105B8 File Offset: 0x0000E7B8
		public void CopyTo(T[] tArray, int num)
		{
			this.icollection_0.CopyTo(tArray, num);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000105C7 File Offset: 0x0000E7C7
		private bool method_0()
		{
			throw new NotSupportedException("The ICollection is read-only.");
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000105D3 File Offset: 0x0000E7D3
		public bool Remove(T t)
		{
			return this.method_0();
		}

		// Token: 0x04000A3A RID: 2618
		private ICollection icollection_0;
	}
}
