using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x020003AD RID: 941
	[Serializable]
	public sealed class Vector3DArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00091EDC File Offset: 0x000900DC
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001EC RID: 492
		public  Vector3D this[int int_1]
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F1 RID: 497
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (Vector3D)value;
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0000FA65 File Offset: 0x0000DC65
		public Vector3DArrayList()
		{
			this._array = new Vector3D[16];
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00091F38 File Offset: 0x00090138
		public Vector3DArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new Vector3D[int_1];
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00091F8C File Offset: 0x0009018C
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
					this._array = new Vector3D[16];
				}
				else
				{
					Vector3D[] array = new Vector3D[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00092008 File Offset: 0x00090208
		public  int Add(Vector3D vector3D_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = vector3D_0;
			return this._count++;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00092070 File Offset: 0x00090270
		int IList.Add(object value)
		{
			return this.Add((Vector3D)value);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0000FA8F File Offset: 0x0000DC8F
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0009208C File Offset: 0x0009028C
		public  object Clone()
		{
			Vector3DArrayList vector3DArrayList = new Vector3DArrayList(this._count);
			Array.Copy(this._array, 0, vector3DArrayList._array, 0, this._count);
			vector3DArrayList._count = this._count;
			vector3DArrayList.int_0 = this.int_0;
			return vector3DArrayList;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0000FAC6 File Offset: 0x0000DCC6
		public bool vmethod_1(Vector3D vector3D_0)
		{
			return this.vmethod_4(vector3D_0) >= 0;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0000FAD5 File Offset: 0x0000DCD5
		bool IList.Contains(object value)
		{
			return this.vmethod_1((Vector3D)value);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0000FAE3 File Offset: 0x0000DCE3
		public  void vmethod_2(Vector3D[] vector3D_0, int int_1)
		{
			this.method_2(vector3D_0, int_1);
			Array.Copy(this._array, 0, vector3D_0, int_1, this._count);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0000FB01 File Offset: 0x0000DD01
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((Vector3D[])array, index);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000920DC File Offset: 0x000902DC
		public  Interface60 vmethod_3()
		{
			return new Vector3DArrayList.Enumerator(this);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000920F4 File Offset: 0x000902F4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00092110 File Offset: 0x00090310
		public  int vmethod_4(Vector3D vector3D_0)
		{
			return Array.IndexOf<Vector3D>(this._array, vector3D_0, 0, this._count);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00092134 File Offset: 0x00090334
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((Vector3D)value);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00092150 File Offset: 0x00090350
		public  void vmethod_5(int int_1, Vector3D vector3D_0)
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
			this._array[int_1] = vector3D_0;
			this._count++;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0000FB18 File Offset: 0x0000DD18
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (Vector3D)value);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0009221C File Offset: 0x0009041C
		public  void vmethod_6(Vector3D vector3D_0)
		{
			int num = this.vmethod_4(vector3D_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0000FB27 File Offset: 0x0000DD27
		void IList.Remove(object value)
		{
			this.vmethod_6((Vector3D)value);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00092240 File Offset: 0x00090440
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(Vector3D);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0000FB35 File Offset: 0x0000DD35
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0000FB54 File Offset: 0x0000DD54
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000922B0 File Offset: 0x000904B0
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

		// Token: 0x06001745 RID: 5957 RVA: 0x00092350 File Offset: 0x00090550
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00092388 File Offset: 0x00090588
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

		// Token: 0x04000997 RID: 2455
		private const int _defaultCapacity = 16;

		// Token: 0x04000998 RID: 2456
		private Vector3D[] _array = null;

		// Token: 0x04000999 RID: 2457
		private int _count = 0;

		// Token: 0x0400099A RID: 2458
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x020003AE RID: 942
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface60
		{
			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06001747 RID: 5959 RVA: 0x000923D8 File Offset: 0x000905D8
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06001748 RID: 5960 RVA: 0x0000FB6C File Offset: 0x0000DD6C
			internal Enumerator(Vector3DArrayList vector3DArrayList_0)
			{
				this._collection = vector3DArrayList_0;
				this._version = vector3DArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06001749 RID: 5961 RVA: 0x000923F4 File Offset: 0x000905F4
			public Vector3D vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x0600174A RID: 5962 RVA: 0x00092438 File Offset: 0x00090638
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x0600174B RID: 5963 RVA: 0x0000FB8E File Offset: 0x0000DD8E
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x0400099B RID: 2459
			private readonly Vector3DArrayList _collection;

			// Token: 0x0400099C RID: 2460
			private readonly int _version;

			// Token: 0x0400099D RID: 2461
			private int _index;
		}
	}
}
