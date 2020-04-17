using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x020003A1 RID: 929
	[Serializable]
	public sealed class Vector2DArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x0009070C File Offset: 0x0008E90C
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001DB RID: 475
		public  Vector2D this[int int_1]
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E0 RID: 480
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (Vector2D)value;
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0000F651 File Offset: 0x0000D851
		public Vector2DArrayList()
		{
			this._array = new Vector2D[16];
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00090768 File Offset: 0x0008E968
		public Vector2DArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new Vector2D[int_1];
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000907BC File Offset: 0x0008E9BC
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
					this._array = new Vector2D[16];
				}
				else
				{
					Vector2D[] array = new Vector2D[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00090838 File Offset: 0x0008EA38
		public  int Add(Vector2D vector2D_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = vector2D_0;
			return this._count++;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000908A0 File Offset: 0x0008EAA0
		int IList.Add(object value)
		{
			return this.Add((Vector2D)value);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0000F67B File Offset: 0x0000D87B
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000908BC File Offset: 0x0008EABC
		public  object Clone()
		{
			Vector2DArrayList vector2DArrayList = new Vector2DArrayList(this._count);
			Array.Copy(this._array, 0, vector2DArrayList._array, 0, this._count);
			vector2DArrayList._count = this._count;
			vector2DArrayList.int_0 = this.int_0;
			return vector2DArrayList;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0000F6B2 File Offset: 0x0000D8B2
		public bool vmethod_1(Vector2D vector2D_0)
		{
			return this.vmethod_4(vector2D_0) >= 0;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0000F6C1 File Offset: 0x0000D8C1
		bool IList.Contains(object value)
		{
			return this.vmethod_1((Vector2D)value);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0000F6CF File Offset: 0x0000D8CF
		public  void vmethod_2(Vector2D[] vector2D_0, int int_1)
		{
			this.method_2(vector2D_0, int_1);
			Array.Copy(this._array, 0, vector2D_0, int_1, this._count);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0000F6ED File Offset: 0x0000D8ED
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((Vector2D[])array, index);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0009090C File Offset: 0x0008EB0C
		public  Interface58 vmethod_3()
		{
			return new Vector2DArrayList.Enumerator(this);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00090924 File Offset: 0x0008EB24
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00090940 File Offset: 0x0008EB40
		public  int vmethod_4(Vector2D vector2D_0)
		{
			return Array.IndexOf<Vector2D>(this._array, vector2D_0, 0, this._count);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00090964 File Offset: 0x0008EB64
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((Vector2D)value);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00090980 File Offset: 0x0008EB80
		public  void vmethod_5(int int_1, Vector2D vector2D_0)
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
			this._array[int_1] = vector2D_0;
			this._count++;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0000F704 File Offset: 0x0000D904
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (Vector2D)value);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00090A4C File Offset: 0x0008EC4C
		public  void vmethod_6(Vector2D vector2D_0)
		{
			int num = this.vmethod_4(vector2D_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0000F713 File Offset: 0x0000D913
		void IList.Remove(object value)
		{
			this.vmethod_6((Vector2D)value);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00090A70 File Offset: 0x0008EC70
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(Vector2D);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0000F721 File Offset: 0x0000D921
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0000F740 File Offset: 0x0000D940
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00090AE0 File Offset: 0x0008ECE0
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

		// Token: 0x060016C9 RID: 5833 RVA: 0x00090B80 File Offset: 0x0008ED80
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00090BB8 File Offset: 0x0008EDB8
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

		// Token: 0x0400096C RID: 2412
		private const int _defaultCapacity = 16;

		// Token: 0x0400096D RID: 2413
		private Vector2D[] _array = null;

		// Token: 0x0400096E RID: 2414
		private int _count = 0;

		// Token: 0x0400096F RID: 2415
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x020003A2 RID: 930
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface58
		{
			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x060016CB RID: 5835 RVA: 0x00090C08 File Offset: 0x0008EE08
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x060016CC RID: 5836 RVA: 0x0000F758 File Offset: 0x0000D958
			internal Enumerator(Vector2DArrayList vector2DArrayList_0)
			{
				this._collection = vector2DArrayList_0;
				this._version = vector2DArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x060016CD RID: 5837 RVA: 0x00090C24 File Offset: 0x0008EE24
			public Vector2D vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x060016CE RID: 5838 RVA: 0x00090C68 File Offset: 0x0008EE68
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x060016CF RID: 5839 RVA: 0x0000F77A File Offset: 0x0000D97A
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x04000970 RID: 2416
			private readonly Vector2DArrayList _collection;

			// Token: 0x04000971 RID: 2417
			private readonly int _version;

			// Token: 0x04000972 RID: 2418
			private int _index;
		}
	}
}
