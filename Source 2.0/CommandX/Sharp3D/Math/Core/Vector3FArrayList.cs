using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x020003BD RID: 957
	[Serializable]
	public sealed class Vector3FArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x00092AF8 File Offset: 0x00090CF8
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001FB RID: 507
		public  Vector3F this[int int_1]
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

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000200 RID: 512
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (Vector3F)value;
			}
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0000FD03 File Offset: 0x0000DF03
		public Vector3FArrayList()
		{
			this._array = new Vector3F[16];
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00092B54 File Offset: 0x00090D54
		public Vector3FArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new Vector3F[int_1];
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00092BA8 File Offset: 0x00090DA8
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
					this._array = new Vector3F[16];
				}
				else
				{
					Vector3F[] array = new Vector3F[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00092C24 File Offset: 0x00090E24
		public  int Add(Vector3F vector3F_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = vector3F_0;
			return this._count++;
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00092C8C File Offset: 0x00090E8C
		int IList.Add(object value)
		{
			return this.Add((Vector3F)value);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0000FD2D File Offset: 0x0000DF2D
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00092CA8 File Offset: 0x00090EA8
		public  object Clone()
		{
			Vector3FArrayList vector3FArrayList = new Vector3FArrayList(this._count);
			Array.Copy(this._array, 0, vector3FArrayList._array, 0, this._count);
			vector3FArrayList._count = this._count;
			vector3FArrayList.int_0 = this.int_0;
			return vector3FArrayList;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0000FD64 File Offset: 0x0000DF64
		public bool vmethod_1(Vector3F vector3F_0)
		{
			return this.vmethod_4(vector3F_0) >= 0;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0000FD73 File Offset: 0x0000DF73
		bool IList.Contains(object value)
		{
			return this.vmethod_1((Vector3F)value);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0000FD81 File Offset: 0x0000DF81
		public  void vmethod_2(Vector3F[] vector3F_0, int int_1)
		{
			this.method_2(vector3F_0, int_1);
			Array.Copy(this._array, 0, vector3F_0, int_1, this._count);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0000FD9F File Offset: 0x0000DF9F
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((Vector3F[])array, index);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00092CF8 File Offset: 0x00090EF8
		public  Interface61 vmethod_3()
		{
			return new Vector3FArrayList.Enumerator(this);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00092D10 File Offset: 0x00090F10
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00092D2C File Offset: 0x00090F2C
		public  int vmethod_4(Vector3F vector3F_0)
		{
			return Array.IndexOf<Vector3F>(this._array, vector3F_0, 0, this._count);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00092D50 File Offset: 0x00090F50
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((Vector3F)value);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00092D6C File Offset: 0x00090F6C
		public  void vmethod_5(int int_1, Vector3F vector3F_0)
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
			this._array[int_1] = vector3F_0;
			this._count++;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0000FDB6 File Offset: 0x0000DFB6
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (Vector3F)value);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00092E38 File Offset: 0x00091038
		public  void vmethod_6(Vector3F vector3F_0)
		{
			int num = this.vmethod_4(vector3F_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0000FDC5 File Offset: 0x0000DFC5
		void IList.Remove(object value)
		{
			this.vmethod_6((Vector3F)value);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00092E5C File Offset: 0x0009105C
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(Vector3F);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0000FDD3 File Offset: 0x0000DFD3
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0000FDF2 File Offset: 0x0000DFF2
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00092ECC File Offset: 0x000910CC
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

		// Token: 0x060017AD RID: 6061 RVA: 0x00092F6C File Offset: 0x0009116C
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00092FA4 File Offset: 0x000911A4
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

		// Token: 0x040009B0 RID: 2480
		private const int _defaultCapacity = 16;

		// Token: 0x040009B1 RID: 2481
		private Vector3F[] _array = null;

		// Token: 0x040009B2 RID: 2482
		private int _count = 0;

		// Token: 0x040009B3 RID: 2483
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x020003BE RID: 958
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface61
		{
			// Token: 0x17000201 RID: 513
			// (get) Token: 0x060017AF RID: 6063 RVA: 0x00092FF4 File Offset: 0x000911F4
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x060017B0 RID: 6064 RVA: 0x0000FE0A File Offset: 0x0000E00A
			internal Enumerator(Vector3FArrayList vector3FArrayList_0)
			{
				this._collection = vector3FArrayList_0;
				this._version = vector3FArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x060017B1 RID: 6065 RVA: 0x00093010 File Offset: 0x00091210
			public Vector3F vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x060017B2 RID: 6066 RVA: 0x00093054 File Offset: 0x00091254
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x060017B3 RID: 6067 RVA: 0x0000FE2C File Offset: 0x0000E02C
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x040009B4 RID: 2484
			private readonly Vector3FArrayList _collection;

			// Token: 0x040009B5 RID: 2485
			private readonly int _version;

			// Token: 0x040009B6 RID: 2486
			private int _index;
		}
	}
}
