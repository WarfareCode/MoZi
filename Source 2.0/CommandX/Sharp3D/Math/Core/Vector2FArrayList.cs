using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x020003A9 RID: 937
	[Serializable]
	public sealed class Vector2FArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x000917F4 File Offset: 0x0008F9F4
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001E4 RID: 484
		public  Vector2F this[int int_1]
		{
			get
			{
				this.method_4(int_1);
				return this._array[int_1];
			}
			set
			{
				this.method_4(int_1);
				this.int_0++;
				this._array[int_1] = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E9 RID: 489
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (Vector2F)value;
			}
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0000F8BE File Offset: 0x0000DABE
		public Vector2FArrayList()
		{
			this._array = new Vector2F[16];
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00091850 File Offset: 0x0008FA50
		public Vector2FArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new Vector2F[int_1];
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000918A4 File Offset: 0x0008FAA4
		public  void vmethod_0(int int_1)
		{
			if (int_1 != this._array.Length)
			{
				if (int_1 < this._count)
				{
					throw new ArgumentOutOfRangeException("Capacity", int_1, "Value cannot be less than Count.");
				}
				if (int_1 == 0)
				{
					this._array = new Vector2F[16];
				}
				else
				{
					Vector2F[] array = new Vector2F[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00091920 File Offset: 0x0008FB20
		public  int Add(Vector2F vector2F_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = vector2F_0;
			return this._count++;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00091988 File Offset: 0x0008FB88
		int IList.Add(object value)
		{
			return this.Add((Vector2F)value);
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000919A4 File Offset: 0x0008FBA4
		public  object Clone()
		{
			Vector2FArrayList vector2FArrayList = new Vector2FArrayList(this._count);
			Array.Copy(this._array, 0, vector2FArrayList._array, 0, this._count);
			vector2FArrayList._count = this._count;
			vector2FArrayList.int_0 = this.int_0;
			return vector2FArrayList;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0000F91F File Offset: 0x0000DB1F
		public bool vmethod_1(Vector2F vector2F_0)
		{
			return this.vmethod_4(vector2F_0) >= 0;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0000F92E File Offset: 0x0000DB2E
		bool IList.Contains(object value)
		{
			return this.vmethod_1((Vector2F)value);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0000F93C File Offset: 0x0000DB3C
		public  void vmethod_2(Vector2F[] vector2F_0, int int_1)
		{
			this.method_2(vector2F_0, int_1);
			Array.Copy(this._array, 0, vector2F_0, int_1, this._count);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0000F95A File Offset: 0x0000DB5A
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((Vector2F[])array, index);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x000919F4 File Offset: 0x0008FBF4
		public  Interface59 vmethod_3()
		{
			return new Vector2FArrayList.Enumerator(this);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00091A0C File Offset: 0x0008FC0C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00091A28 File Offset: 0x0008FC28
		public  int vmethod_4(Vector2F vector2F_0)
		{
			return Array.IndexOf<Vector2F>(this._array, vector2F_0, 0, this._count);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00091A4C File Offset: 0x0008FC4C
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((Vector2F)value);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00091A68 File Offset: 0x0008FC68
		public  void vmethod_5(int int_1, Vector2F vector2F_0)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("index", int_1, "Argument cannot be negative.");
			}
			if (int_1 > this._count)
			{
				throw new ArgumentOutOfRangeException("index", int_1, "Argument cannot exceed Count.");
			}
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			if (int_1 < this._count)
			{
				Array.Copy(this._array, int_1, this._array, int_1 + 1, this._count - int_1);
			}
			this._array[int_1] = vector2F_0;
			this._count++;
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0000F971 File Offset: 0x0000DB71
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (Vector2F)value);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00091B34 File Offset: 0x0008FD34
		public  void vmethod_6(Vector2F vector2F_0)
		{
			int num = this.vmethod_4(vector2F_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0000F980 File Offset: 0x0000DB80
		void IList.Remove(object value)
		{
			this.vmethod_6((Vector2F)value);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00091B58 File Offset: 0x0008FD58
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(Vector2F);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0000F98E File Offset: 0x0000DB8E
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0000F9AD File Offset: 0x0000DBAD
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00091BC8 File Offset: 0x0008FDC8
		private void method_2(Array array_0, int int_1)
		{
			if (array_0 == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array_0.Rank > 1)
			{
				throw new ArgumentException("Argument cannot be multidimensional.", "array");
			}
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", int_1, "Argument cannot be negative.");
			}
			if (int_1 >= array_0.Length)
			{
				throw new ArgumentException("Argument must be less than array length.", "arrayIndex");
			}
			if (this._count > array_0.Length - int_1)
			{
				throw new ArgumentException("Argument section must be large enough for collection.", "array");
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00091C68 File Offset: 0x0008FE68
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00091CA0 File Offset: 0x0008FEA0
		private void method_4(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("index", int_1, "Argument cannot be negative.");
			}
			if (int_1 >= this._count)
			{
				throw new ArgumentOutOfRangeException("index", int_1, "Argument must be less than Count.");
			}
		}

		// Token: 0x0400098B RID: 2443
		private const int _defaultCapacity = 16;

		// Token: 0x0400098C RID: 2444
		private Vector2F[] _array = null;

		// Token: 0x0400098D RID: 2445
		private int _count = 0;

		// Token: 0x0400098E RID: 2446
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x020003AA RID: 938
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface59
		{
			// Token: 0x170001EA RID: 490
			// (get) Token: 0x0600171C RID: 5916 RVA: 0x00091CF0 File Offset: 0x0008FEF0
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x0600171D RID: 5917 RVA: 0x0000F9C5 File Offset: 0x0000DBC5
			internal Enumerator(Vector2FArrayList vector2FArrayList_0)
			{
				this._collection = vector2FArrayList_0;
				this._version = vector2FArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x0600171E RID: 5918 RVA: 0x00091D0C File Offset: 0x0008FF0C
			public Vector2F vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x0600171F RID: 5919 RVA: 0x00091D50 File Offset: 0x0008FF50
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06001720 RID: 5920 RVA: 0x0000F9E7 File Offset: 0x0000DBE7
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x0400098F RID: 2447
			private readonly Vector2FArrayList _collection;

			// Token: 0x04000990 RID: 2448
			private readonly int _version;

			// Token: 0x04000991 RID: 2449
			private int _index;
		}
	}
}
