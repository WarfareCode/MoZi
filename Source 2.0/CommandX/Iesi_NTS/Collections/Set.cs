using System;
using System.Collections;

namespace Iesi_NTS.Collections
{
	// Token: 0x02000376 RID: 886
	[Serializable]
	public abstract class Set : IEnumerable, ICloneable, ICollection, ISet
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06001544 RID: 5444
		public abstract int Count
		{
			get;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001545 RID: 5445
		public abstract object SyncRoot
		{
			get;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06001546 RID: 5446
		public abstract bool IsSynchronized
		{
			get;
		}

		// Token: 0x06001547 RID: 5447
		public abstract bool Add(object object_0);

		// Token: 0x06001548 RID: 5448
		public abstract bool vmethod_0(ICollection icollection_0);

		// Token: 0x06001549 RID: 5449
		public abstract void Clear();

		// Token: 0x0600154A RID: 5450
		public abstract bool Contains(object object_0);

		// Token: 0x0600154B RID: 5451
		public abstract bool imethod_0(object object_0);

		// Token: 0x0600154C RID: 5452 RVA: 0x0008B420 File Offset: 0x00089620
		public  object Clone()
		{
			Set set = (Set)Activator.CreateInstance(base.GetType());
			set.vmethod_0(this);
			return set;
		}

		// Token: 0x0600154D RID: 5453
		public abstract void CopyTo(Array array, int index);

		// Token: 0x0600154E RID: 5454
		public abstract IEnumerator GetEnumerator();
	}
}
