using System;
using System.Collections;
using System.Collections.Generic;

namespace ns15
{
	// Token: 0x020004E8 RID: 1256
	public class BaseCollection<T> : IEnumerable<T>, ICollection<T>, IEnumerable where T : class
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000D4FD8 File Offset: 0x000D31D8
		public int Count
		{
			get
			{
				return this.GetInnerList().Count;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x000D4FF4 File Offset: 0x000D31F4
		protected List<T> GetInnerList()
		{
			return this._innerList;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x000D500C File Offset: 0x000D320C
		protected void SetInnerList(List<T> list_1)
		{
			if (this._innerList != null && this._innerList.Count > 0)
			{
				foreach (T current in this._innerList)
				{
					this.OnExclude(current);
				}
			}
			this._innerList = list_1;
			foreach (T current2 in this._innerList)
			{
				this.OnInclude(current2);
			}
			this.OnInnerListSet();
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00013A96 File Offset: 0x00011C96
		public void Add(T item)
		{
			this.Include(item);
			this.GetInnerList().Add(item);
			this.OnIncludeComplete(item);
			this.OnInsert(this.GetInnerList().IndexOf(item), item);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00013ACA File Offset: 0x00011CCA
		public bool Contains(T item)
		{
			return this.GetInnerList().Contains(item);
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00013AD8 File Offset: 0x00011CD8
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.GetInnerList().CopyTo(array, arrayIndex);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x000D50D0 File Offset: 0x000D32D0
		public bool Remove(T item)
		{
			bool result;
			if (this.GetInnerList().Contains(item))
			{
				int int_ = this.GetInnerList().IndexOf(item);
				this.GetInnerList().Remove(item);
				this.OnRemoveComplete(int_, item);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000D511C File Offset: 0x000D331C
		public IEnumerator<T> GetEnumerator()
		{
			return this.GetInnerList().GetEnumerator();
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00013AE7 File Offset: 0x00011CE7
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000D513C File Offset: 0x000D333C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetInnerList().GetEnumerator();
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void OnInnerListSet()
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x000D515C File Offset: 0x000D335C
		protected virtual void OnClear()
		{
			List<T> list = new List<T>();
			foreach (T current in this.GetInnerList())
			{
				list.Add(current);
			}
			foreach (T current2 in list)
			{
				this.Remove(current2);
			}
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000D51F8 File Offset: 0x000D33F8
		protected virtual void OnInsert(int int_0, object object_0)
		{
			T gparam_ = object_0 as T;
			this.Include(gparam_);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x000D5218 File Offset: 0x000D3418
		protected virtual void OnRemoveComplete(int int_0, object object_0)
		{
			T gparam_ = object_0 as T;
			this.Exclude(gparam_);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void OnInclude(T gparam_0)
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void OnIncludeComplete(T gparam_0)
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void OnExclude(T gparam_0)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00013AEF File Offset: 0x00011CEF
		protected void Include(T gparam_0)
		{
			if (!this.GetInnerList().Contains(gparam_0))
			{
				this.OnInclude(gparam_0);
			}
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00013B06 File Offset: 0x00011D06
		protected void Exclude(T gparam_0)
		{
			if (!this.GetInnerList().Contains(gparam_0))
			{
				this.OnExclude(gparam_0);
			}
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00013B1D File Offset: 0x00011D1D
		public BaseCollection()
		{
			this._innerList = new List<T>();
		}

		// Token: 0x04000FD5 RID: 4053
		private List<T> _innerList;

		// Token: 0x020004E9 RID: 1257
		public sealed class Class834<TE> : IDisposable, IEnumerator<TE>, IEnumerator where TE : class
		{
			// Token: 0x17000258 RID: 600
			// (get) Token: 0x060020C6 RID: 8390 RVA: 0x000D5238 File Offset: 0x000D3438
			public TE Current
			{
				get
				{
					return this.ienumerator_0.Current as TE;
				}
			}

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x060020C7 RID: 8391 RVA: 0x000D525C File Offset: 0x000D345C
			object IEnumerator.Current
			{
				get
				{
					return this.ienumerator_0.Current as TE;
				}
			}

			// Token: 0x060020C8 RID: 8392 RVA: 0x00013B30 File Offset: 0x00011D30
			public Class834(IEnumerator ienumerator_1)
			{
				this.ienumerator_0 = ienumerator_1;
			}

			// Token: 0x060020C9 RID: 8393 RVA: 0x00004BC2 File Offset: 0x00002DC2
			public void Dispose()
			{
			}

			// Token: 0x060020CA RID: 8394 RVA: 0x00013B3F File Offset: 0x00011D3F
			public bool MoveNext()
			{
				return this.ienumerator_0.MoveNext();
			}

			// Token: 0x060020CB RID: 8395 RVA: 0x00013B4C File Offset: 0x00011D4C
			public void Reset()
			{
				this.ienumerator_0.Reset();
			}

			// Token: 0x04000FD6 RID: 4054
			private readonly IEnumerator ienumerator_0;
		}
	}
}
