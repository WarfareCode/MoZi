using System;
using System.Collections;
using System.Collections.Generic;
using ns15;

namespace DotSpatial.Serialization
{
	// Token: 0x020004EA RID: 1258
	[Serializable]
	public class BaseList<T> : BaseCollection<T>, IEnumerable<T>, IList<T>, ICollection<T>, IEnumerable where T : class
	{
		// Token: 0x1700025A RID: 602
		public T this[int index]
		{
			get
			{
				return base.GetInnerList()[index];
			}
			set
			{
				base.Exclude(base.GetInnerList()[index]);
				base.Include(value);
				base.GetInnerList()[index] = value;
				this.OnIncludeComplete(value);
			}
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000D52A4 File Offset: 0x000D34A4
		public int IndexOf(T item)
		{
			return base.GetInnerList().IndexOf(item);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00013B88 File Offset: 0x00011D88
		public virtual void Insert(int index, T item)
		{
			this.DoInsert(index, item);
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void OnInsert(int int_0, T gparam_0)
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00013B92 File Offset: 0x00011D92
		private void DoInsert(int int_0, T gparam_0)
		{
			if (base.IsReadOnly)
			{
				throw new Exception12();
			}
			base.Include(gparam_0);
			base.GetInnerList().Insert(int_0, gparam_0);
			this.OnInsert(int_0, gparam_0);
			this.OnIncludeComplete(gparam_0);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000D52C0 File Offset: 0x000D34C0
		public void RemoveAt(int index)
		{
			T gparam_ = base.GetInnerList()[index];
			base.GetInnerList().RemoveAt(index);
			this.OnExclude(gparam_);
		}
	}
}
