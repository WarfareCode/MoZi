using System;
using System.Collections;
using System.Collections.Generic;

namespace Iesi_NTS.Collections.Generic
{
	// Token: 0x020003C0 RID: 960
	[Serializable]
	public abstract class Set<T> : IEnumerable<T>, ICollection<T>, ISet<T>, IEnumerable, ICloneable, ICollection, ISet
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060017B4 RID: 6068
		public abstract int Count
		{
			get;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060017B6 RID: 6070
		public abstract object SyncRoot
		{
			get;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060017B7 RID: 6071
		public abstract bool IsSynchronized
		{
			get;
		}

		// Token: 0x060017B8 RID: 6072
		public abstract bool Add(T gparam_0);

		// Token: 0x060017B9 RID: 6073
		public abstract bool vmethod_0(ICollection<T> icollection_0);

		// Token: 0x060017BA RID: 6074
		public abstract bool Remove(T item);

		// Token: 0x060017BB RID: 6075
		public abstract void Clear();

		// Token: 0x060017BC RID: 6076
		public abstract bool Contains(T item);

		// Token: 0x060017BD RID: 6077 RVA: 0x0000FE46 File Offset: 0x0000E046
		bool ISet.Add(object object_0)
		{
			return this.Add((T)((object)object_0));
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0000FE54 File Offset: 0x0000E054
		bool ISet.Contains(object object_0)
		{
			return this.Contains((T)((object)object_0));
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0000FE62 File Offset: 0x0000E062
		bool ISet.imethod_0(object object_0)
		{
			return this.Remove((T)((object)object_0));
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00093090 File Offset: 0x00091290
		public virtual ISet<T> vmethod_1()
		{
			Set<T> set = (Set<T>)Activator.CreateInstance(base.GetType());
			set.vmethod_0(this);
			return set;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000930BC File Offset: 0x000912BC
		object ICloneable.Clone()
		{
			return this.vmethod_1();
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000930D4 File Offset: 0x000912D4
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_0(array, index);
			T[] array2 = new T[this.Count];
			this.CopyTo(array2, index);
			Array.Copy(array2, 0, array, index, this.Count);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0000FE70 File Offset: 0x0000E070
		void ICollection<T>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x060017C4 RID: 6084
		public abstract void CopyTo(T[] array, int arrayIndex);

		// Token: 0x060017C5 RID: 6085
		public abstract IEnumerator<T> GetEnumerator();

		// Token: 0x060017C6 RID: 6086 RVA: 0x0009310C File Offset: 0x0009130C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00093124 File Offset: 0x00091324
		private void method_0(Array array_0, int int_0)
		{
			if (array_0 == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array_0.Rank > 1)
			{
				throw new ArgumentException("Argument cannot be multidimensional.", "array");
			}
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", int_0, "Argument cannot be negative.");
			}
			if (int_0 >= array_0.Length)
			{
				throw new ArgumentException("Argument must be less than array length.", "arrayIndex");
			}
			if (this.Count > array_0.Length - int_0)
			{
				throw new ArgumentException("Argument section must be large enough for collection.", "array");
			}
		}
	}
}
