using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x020003D6 RID: 982
	[Serializable]
	public sealed class Vector4FArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00097164 File Offset: 0x00095364
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000213 RID: 531
		public  Vector4F this[int int_1]
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000218 RID: 536
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (Vector4F)value;
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0001023D File Offset: 0x0000E43D
		public Vector4FArrayList()
		{
			this._array = new Vector4F[16];
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x000971C0 File Offset: 0x000953C0
		public Vector4FArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new Vector4F[int_1];
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00097214 File Offset: 0x00095414
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
					this._array = new Vector4F[16];
				}
				else
				{
					Vector4F[] array = new Vector4F[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00097290 File Offset: 0x00095490
		public  int Add(Vector4F vector4F_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = vector4F_0;
			return this._count++;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x000972F8 File Offset: 0x000954F8
		int IList.Add(object value)
		{
			return this.Add((Vector4F)value);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00010267 File Offset: 0x0000E467
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00097314 File Offset: 0x00095514
		public  object Clone()
		{
			Vector4FArrayList vector4FArrayList = new Vector4FArrayList(this._count);
			Array.Copy(this._array, 0, vector4FArrayList._array, 0, this._count);
			vector4FArrayList._count = this._count;
			vector4FArrayList.int_0 = this.int_0;
			return vector4FArrayList;
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0001029E File Offset: 0x0000E49E
		public bool vmethod_1(Vector4F vector4F_0)
		{
			return this.vmethod_4(vector4F_0) >= 0;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000102AD File Offset: 0x0000E4AD
		bool IList.Contains(object value)
		{
			return this.vmethod_1((Vector4F)value);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000102BB File Offset: 0x0000E4BB
		public  void vmethod_2(Vector4F[] vector4F_0, int int_1)
		{
			this.method_2(vector4F_0, int_1);
			Array.Copy(this._array, 0, vector4F_0, int_1, this._count);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000102D9 File Offset: 0x0000E4D9
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((Vector4F[])array, index);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00097364 File Offset: 0x00095564
		public  Interface63 vmethod_3()
		{
			return new Vector4FArrayList.Enumerator(this);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0009737C File Offset: 0x0009557C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00097398 File Offset: 0x00095598
		public  int vmethod_4(Vector4F vector4F_0)
		{
			return Array.IndexOf<Vector4F>(this._array, vector4F_0, 0, this._count);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000973BC File Offset: 0x000955BC
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((Vector4F)value);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000973D8 File Offset: 0x000955D8
		public  void vmethod_5(int int_1, Vector4F vector4F_0)
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
			this._array[int_1] = vector4F_0;
			this._count++;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000102F0 File Offset: 0x0000E4F0
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (Vector4F)value);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000974A4 File Offset: 0x000956A4
		public  void vmethod_6(Vector4F vector4F_0)
		{
			int num = this.vmethod_4(vector4F_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000102FF File Offset: 0x0000E4FF
		void IList.Remove(object value)
		{
			this.vmethod_6((Vector4F)value);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x000974C8 File Offset: 0x000956C8
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(Vector4F);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0001030D File Offset: 0x0000E50D
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0001032C File Offset: 0x0000E52C
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00097538 File Offset: 0x00095738
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

		// Token: 0x0600186D RID: 6253 RVA: 0x000975D8 File Offset: 0x000957D8
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00097610 File Offset: 0x00095810
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

		// Token: 0x04000A12 RID: 2578
		private const int _defaultCapacity = 16;

		// Token: 0x04000A13 RID: 2579
		private Vector4F[] _array = null;

		// Token: 0x04000A14 RID: 2580
		private int _count = 0;

		// Token: 0x04000A15 RID: 2581
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x020003D7 RID: 983
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface63
		{
			// Token: 0x17000219 RID: 537
			// (get) Token: 0x0600186F RID: 6255 RVA: 0x00097660 File Offset: 0x00095860
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06001870 RID: 6256 RVA: 0x00010344 File Offset: 0x0000E544
			internal Enumerator(Vector4FArrayList vector4FArrayList_0)
			{
				this._collection = vector4FArrayList_0;
				this._version = vector4FArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06001871 RID: 6257 RVA: 0x0009767C File Offset: 0x0009587C
			public Vector4F vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x000976C0 File Offset: 0x000958C0
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06001873 RID: 6259 RVA: 0x00010366 File Offset: 0x0000E566
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x04000A16 RID: 2582
			private readonly Vector4FArrayList _collection;

			// Token: 0x04000A17 RID: 2583
			private readonly int _version;

			// Token: 0x04000A18 RID: 2584
			private int _index;
		}
	}
}
