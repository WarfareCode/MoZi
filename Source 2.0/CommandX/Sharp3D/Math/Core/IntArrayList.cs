using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000286 RID: 646
	[Serializable]
	public sealed class IntArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0007C6B4 File Offset: 0x0007A8B4
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000151 RID: 337
		public  int this[int int_1]
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000156 RID: 342
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (int)value;
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0000C11E File Offset: 0x0000A31E
		public IntArrayList()
		{
			this._array = new int[16];
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0007C708 File Offset: 0x0007A908
		public IntArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new int[int_1];
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0007C75C File Offset: 0x0007A95C
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
					this._array = new int[16];
				}
				else
				{
					int[] array = new int[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0007C7D8 File Offset: 0x0007A9D8
		public  int Add(int int_1)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = int_1;
			return this._count++;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0007C838 File Offset: 0x0007AA38
		int IList.Add(object value)
		{
			return this.Add((int)value);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0000C148 File Offset: 0x0000A348
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0007C854 File Offset: 0x0007AA54
		public  object Clone()
		{
			IntArrayList intArrayList = new IntArrayList(this._count);
			Array.Copy(this._array, 0, intArrayList._array, 0, this._count);
			intArrayList._count = this._count;
			intArrayList.int_0 = this.int_0;
			return intArrayList;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0000C17F File Offset: 0x0000A37F
		public bool vmethod_1(int int_1)
		{
			return this.vmethod_4(int_1) >= 0;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0000C18E File Offset: 0x0000A38E
		bool IList.Contains(object value)
		{
			return this.vmethod_1((int)value);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0000C19C File Offset: 0x0000A39C
		public  void vmethod_2(int[] int_1, int int_2)
		{
			this.method_2(int_1, int_2);
			Array.Copy(this._array, 0, int_1, int_2, this._count);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0000C1BA File Offset: 0x0000A3BA
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((int[])array, index);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0007C8A4 File Offset: 0x0007AAA4
		public  Interface55 vmethod_3()
		{
			return new IntArrayList.Enumerator(this);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0007C8BC File Offset: 0x0007AABC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0007C8D8 File Offset: 0x0007AAD8
		public  int vmethod_4(int int_1)
		{
			return Array.IndexOf<int>(this._array, int_1, 0, this._count);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0007C8FC File Offset: 0x0007AAFC
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((int)value);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0007C918 File Offset: 0x0007AB18
		public  void vmethod_5(int int_1, int int_2)
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
			this._array[int_1] = int_2;
			this._count++;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0000C1D1 File Offset: 0x0000A3D1
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (int)value);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0007C9DC File Offset: 0x0007ABDC
		public  void vmethod_6(int int_1)
		{
			int num = this.vmethod_4(int_1);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		void IList.Remove(object value)
		{
			this.vmethod_6((int)value);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0007CA00 File Offset: 0x0007AC00
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = 0;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0000C1EE File Offset: 0x0000A3EE
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0000C20D File Offset: 0x0000A40D
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0007CA68 File Offset: 0x0007AC68
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

		// Token: 0x06000F3C RID: 3900 RVA: 0x0007CB08 File Offset: 0x0007AD08
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0007CB40 File Offset: 0x0007AD40
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

		// Token: 0x0400062C RID: 1580
		private const int _defaultCapacity = 16;

		// Token: 0x0400062D RID: 1581
		private int[] _array = null;

		// Token: 0x0400062E RID: 1582
		private int _count = 0;

		// Token: 0x0400062F RID: 1583
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x02000287 RID: 647
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface55
		{
			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0007CB90 File Offset: 0x0007AD90
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x0000C225 File Offset: 0x0000A425
			internal Enumerator(IntArrayList intArrayList_0)
			{
				this._collection = intArrayList_0;
				this._version = intArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06000F40 RID: 3904 RVA: 0x0007CBAC File Offset: 0x0007ADAC
			public int vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x06000F41 RID: 3905 RVA: 0x0007CBF0 File Offset: 0x0007ADF0
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06000F42 RID: 3906 RVA: 0x0000C247 File Offset: 0x0000A447
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x04000630 RID: 1584
			private readonly IntArrayList _collection;

			// Token: 0x04000631 RID: 1585
			private readonly int _version;

			// Token: 0x04000632 RID: 1586
			private int _index;
		}
	}
}
