using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x020003C7 RID: 967
	[Serializable]
	public sealed class Vector4DArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00095EB8 File Offset: 0x000940B8
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000207 RID: 519
		public  Vector4D this[int int_1]
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

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700020C RID: 524
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (Vector4D)value;
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0000FF66 File Offset: 0x0000E166
		public Vector4DArrayList()
		{
			this._array = new Vector4D[16];
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00095F14 File Offset: 0x00094114
		public Vector4DArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new Vector4D[int_1];
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00095F68 File Offset: 0x00094168
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
					this._array = new Vector4D[16];
				}
				else
				{
					Vector4D[] array = new Vector4D[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00095FE4 File Offset: 0x000941E4
		public  int Add(Vector4D vector4D_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = vector4D_0;
			return this._count++;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0009604C File Offset: 0x0009424C
		int IList.Add(object value)
		{
			return this.Add((Vector4D)value);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0000FF90 File Offset: 0x0000E190
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00096068 File Offset: 0x00094268
		public  object Clone()
		{
			Vector4DArrayList vector4DArrayList = new Vector4DArrayList(this._count);
			Array.Copy(this._array, 0, vector4DArrayList._array, 0, this._count);
			vector4DArrayList._count = this._count;
			vector4DArrayList.int_0 = this.int_0;
			return vector4DArrayList;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0000FFC7 File Offset: 0x0000E1C7
		public bool vmethod_1(Vector4D vector4D_0)
		{
			return this.vmethod_4(vector4D_0) >= 0;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0000FFD6 File Offset: 0x0000E1D6
		bool IList.Contains(object value)
		{
			return this.vmethod_1((Vector4D)value);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		public  void vmethod_2(Vector4D[] vector4D_0, int int_1)
		{
			this.method_2(vector4D_0, int_1);
			Array.Copy(this._array, 0, vector4D_0, int_1, this._count);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00010002 File Offset: 0x0000E202
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((Vector4D[])array, index);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x000960B8 File Offset: 0x000942B8
		public  Interface62 vmethod_3()
		{
			return new Vector4DArrayList.Enumerator(this);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000960D0 File Offset: 0x000942D0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000960EC File Offset: 0x000942EC
		public  int vmethod_4(Vector4D vector4D_0)
		{
			return Array.IndexOf<Vector4D>(this._array, vector4D_0, 0, this._count);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00096110 File Offset: 0x00094310
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((Vector4D)value);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0009612C File Offset: 0x0009432C
		public  void vmethod_5(int int_1, Vector4D vector4D_0)
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
			this._array[int_1] = vector4D_0;
			this._count++;
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00010019 File Offset: 0x0000E219
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (Vector4D)value);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000961F8 File Offset: 0x000943F8
		public  void vmethod_6(Vector4D vector4D_0)
		{
			int num = this.vmethod_4(vector4D_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00010028 File Offset: 0x0000E228
		void IList.Remove(object value)
		{
			this.vmethod_6((Vector4D)value);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0009621C File Offset: 0x0009441C
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(Vector4D);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00010036 File Offset: 0x0000E236
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00010055 File Offset: 0x0000E255
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0009628C File Offset: 0x0009448C
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

		// Token: 0x0600180A RID: 6154 RVA: 0x0009632C File Offset: 0x0009452C
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00096364 File Offset: 0x00094564
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

		// Token: 0x040009DB RID: 2523
		private const int _defaultCapacity = 16;

		// Token: 0x040009DC RID: 2524
		private Vector4D[] _array = null;

		// Token: 0x040009DD RID: 2525
		private int _count = 0;

		// Token: 0x040009DE RID: 2526
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x020003C8 RID: 968
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface62
		{
			// Token: 0x1700020D RID: 525
			// (get) Token: 0x0600180C RID: 6156 RVA: 0x000963B4 File Offset: 0x000945B4
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x0600180D RID: 6157 RVA: 0x0001006D File Offset: 0x0000E26D
			internal Enumerator(Vector4DArrayList vector4DArrayList_0)
			{
				this._collection = vector4DArrayList_0;
				this._version = vector4DArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x0600180E RID: 6158 RVA: 0x000963D0 File Offset: 0x000945D0
			public Vector4D vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x0600180F RID: 6159 RVA: 0x00096414 File Offset: 0x00094614
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06001810 RID: 6160 RVA: 0x0001008F File Offset: 0x0000E28F
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x040009DF RID: 2527
			private readonly Vector4DArrayList _collection;

			// Token: 0x040009E0 RID: 2528
			private readonly int _version;

			// Token: 0x040009E1 RID: 2529
			private int _index;
		}
	}
}
