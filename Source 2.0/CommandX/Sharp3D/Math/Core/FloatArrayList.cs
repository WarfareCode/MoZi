using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000283 RID: 643
	[Serializable]
	public sealed class FloatArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0007C138 File Offset: 0x0007A338
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000149 RID: 329
		public  float this[int int_1]
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700014E RID: 334
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (float)value;
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0000BFAC File Offset: 0x0000A1AC
		public FloatArrayList()
		{
			this._array = new float[16];
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0007C18C File Offset: 0x0007A38C
		public FloatArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new float[int_1];
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0007C1E0 File Offset: 0x0007A3E0
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
					this._array = new float[16];
				}
				else
				{
					float[] array = new float[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0007C25C File Offset: 0x0007A45C
		public  int Add(float float_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = float_0;
			return this._count++;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0007C2BC File Offset: 0x0007A4BC
		int IList.Add(object value)
		{
			return this.Add((float)value);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0000BFD6 File Offset: 0x0000A1D6
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0007C2D8 File Offset: 0x0007A4D8
		public  object Clone()
		{
			FloatArrayList floatArrayList = new FloatArrayList(this._count);
			Array.Copy(this._array, 0, floatArrayList._array, 0, this._count);
			floatArrayList._count = this._count;
			floatArrayList.int_0 = this.int_0;
			return floatArrayList;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0000C00D File Offset: 0x0000A20D
		public bool vmethod_1(float float_0)
		{
			return this.vmethod_4(float_0) >= 0;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0000C01C File Offset: 0x0000A21C
		bool IList.Contains(object value)
		{
			return this.vmethod_1((float)value);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0000C02A File Offset: 0x0000A22A
		public  void vmethod_2(float[] float_0, int int_1)
		{
			this.method_2(float_0, int_1);
			Array.Copy(this._array, 0, float_0, int_1, this._count);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0000C048 File Offset: 0x0000A248
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((float[])array, index);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0007C328 File Offset: 0x0007A528
		public  Interface54 vmethod_3()
		{
			return new FloatArrayList.Enumerator(this);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0007C340 File Offset: 0x0007A540
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0007C35C File Offset: 0x0007A55C
		public  int vmethod_4(float float_0)
		{
			return Array.IndexOf<float>(this._array, float_0, 0, this._count);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0007C380 File Offset: 0x0007A580
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((float)value);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0007C39C File Offset: 0x0007A59C
		public  void vmethod_5(int int_1, float float_0)
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
			this._array[int_1] = float_0;
			this._count++;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0000C05F File Offset: 0x0000A25F
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (float)value);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0007C460 File Offset: 0x0007A660
		public  void vmethod_6(float float_0)
		{
			int num = this.vmethod_4(float_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0000C06E File Offset: 0x0000A26E
		void IList.Remove(object value)
		{
			this.vmethod_6((float)value);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0007C484 File Offset: 0x0007A684
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = 0f;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0000C07C File Offset: 0x0000A27C
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0000C09B File Offset: 0x0000A29B
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0007C4F0 File Offset: 0x0007A6F0
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

		// Token: 0x06000F15 RID: 3861 RVA: 0x0007C590 File Offset: 0x0007A790
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0007C5C8 File Offset: 0x0007A7C8
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

		// Token: 0x04000625 RID: 1573
		private const int _defaultCapacity = 16;

		// Token: 0x04000626 RID: 1574
		private float[] _array = null;

		// Token: 0x04000627 RID: 1575
		private int _count = 0;

		// Token: 0x04000628 RID: 1576
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x02000284 RID: 644
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface54
		{
			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0007C618 File Offset: 0x0007A818
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06000F18 RID: 3864 RVA: 0x0000C0B3 File Offset: 0x0000A2B3
			internal Enumerator(FloatArrayList floatArrayList_0)
			{
				this._collection = floatArrayList_0;
				this._version = floatArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06000F19 RID: 3865 RVA: 0x0007C634 File Offset: 0x0007A834
			public float vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x06000F1A RID: 3866 RVA: 0x0007C678 File Offset: 0x0007A878
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06000F1B RID: 3867 RVA: 0x0000C0D5 File Offset: 0x0000A2D5
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x04000629 RID: 1577
			private readonly FloatArrayList _collection;

			// Token: 0x0400062A RID: 1578
			private readonly int _version;

			// Token: 0x0400062B RID: 1579
			private int _index;
		}
	}
}
