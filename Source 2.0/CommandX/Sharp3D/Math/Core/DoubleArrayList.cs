using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200027F RID: 639
	[Serializable]
	public sealed class DoubleArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0007BBB8 File Offset: 0x00079DB8
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000141 RID: 321
		public  double this[int int_1]
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000146 RID: 326
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (double)value;
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0000BE3A File Offset: 0x0000A03A
		public DoubleArrayList()
		{
			this._array = new double[16];
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0007BC0C File Offset: 0x00079E0C
		public DoubleArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new double[int_1];
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0007BC60 File Offset: 0x00079E60
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
					this._array = new double[16];
				}
				else
				{
					double[] array = new double[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0007BCDC File Offset: 0x00079EDC
		public  int Add(double double_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = double_0;
			return this._count++;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0007BD3C File Offset: 0x00079F3C
		int IList.Add(object value)
		{
			return this.Add((double)value);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0000BE64 File Offset: 0x0000A064
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0007BD58 File Offset: 0x00079F58
		public  object Clone()
		{
			DoubleArrayList doubleArrayList = new DoubleArrayList(this._count);
			Array.Copy(this._array, 0, doubleArrayList._array, 0, this._count);
			doubleArrayList._count = this._count;
			doubleArrayList.int_0 = this.int_0;
			return doubleArrayList;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0000BE9B File Offset: 0x0000A09B
		public bool vmethod_1(double double_0)
		{
			return this.vmethod_4(double_0) >= 0;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0000BEAA File Offset: 0x0000A0AA
		bool IList.Contains(object value)
		{
			return this.vmethod_1((double)value);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		public  void vmethod_2(double[] double_0, int int_1)
		{
			this.method_2(double_0, int_1);
			Array.Copy(this._array, 0, double_0, int_1, this._count);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0000BED6 File Offset: 0x0000A0D6
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((double[])array, index);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0007BDA8 File Offset: 0x00079FA8
		public  Interface53 vmethod_3()
		{
			return new DoubleArrayList.Enumerator(this);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0007BDC0 File Offset: 0x00079FC0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0007BDDC File Offset: 0x00079FDC
		public  int vmethod_4(double double_0)
		{
			return Array.IndexOf<double>(this._array, double_0, 0, this._count);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0007BE00 File Offset: 0x0007A000
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((double)value);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0007BE1C File Offset: 0x0007A01C
		public  void vmethod_5(int int_1, double double_0)
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
			this._array[int_1] = double_0;
			this._count++;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0000BEED File Offset: 0x0000A0ED
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (double)value);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
		public  void vmethod_6(double double_0)
		{
			int num = this.vmethod_4(double_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		void IList.Remove(object value)
		{
			this.vmethod_6((double)value);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0007BF04 File Offset: 0x0007A104
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = 0.0;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0000BF0A File Offset: 0x0000A10A
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0000BF29 File Offset: 0x0000A129
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0007BF74 File Offset: 0x0007A174
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

		// Token: 0x06000EEA RID: 3818 RVA: 0x0007C014 File Offset: 0x0007A214
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0007C04C File Offset: 0x0007A24C
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

		// Token: 0x0400061E RID: 1566
		private const int _defaultCapacity = 16;

		// Token: 0x0400061F RID: 1567
		private double[] _array = null;

		// Token: 0x04000620 RID: 1568
		private int _count = 0;

		// Token: 0x04000621 RID: 1569
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x02000280 RID: 640
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface53
		{
			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0007C09C File Offset: 0x0007A29C
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06000EED RID: 3821 RVA: 0x0000BF41 File Offset: 0x0000A141
			internal Enumerator(DoubleArrayList doubleArrayList_0)
			{
				this._collection = doubleArrayList_0;
				this._version = doubleArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06000EEE RID: 3822 RVA: 0x0007C0B8 File Offset: 0x0007A2B8
			public double vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x06000EEF RID: 3823 RVA: 0x0007C0FC File Offset: 0x0007A2FC
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06000EF0 RID: 3824 RVA: 0x0000BF63 File Offset: 0x0000A163
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x04000622 RID: 1570
			private readonly DoubleArrayList _collection;

			// Token: 0x04000623 RID: 1571
			private readonly int _version;

			// Token: 0x04000624 RID: 1572
			private int _index;
		}
	}
}
