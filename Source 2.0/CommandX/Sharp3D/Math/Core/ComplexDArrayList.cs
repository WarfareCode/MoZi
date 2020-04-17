using System;
using System.Collections;
using ns29;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200024F RID: 591
	[Serializable]
	public sealed class ComplexDArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0007A730 File Offset: 0x00078930
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000122 RID: 290
		public  ComplexD this[int int_1]
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000127 RID: 295
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (ComplexD)value;
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0000B340 File Offset: 0x00009540
		public ComplexDArrayList()
		{
			this._array = new ComplexD[16];
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0007A78C File Offset: 0x0007898C
		public ComplexDArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new ComplexD[int_1];
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0007A7E0 File Offset: 0x000789E0
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
					this._array = new ComplexD[16];
				}
				else
				{
					ComplexD[] array = new ComplexD[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0007A85C File Offset: 0x00078A5C
		public  int Add(ComplexD complexD_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = complexD_0;
			return this._count++;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0007A8C4 File Offset: 0x00078AC4
		int IList.Add(object value)
		{
			return this.Add((ComplexD)value);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0000B36A File Offset: 0x0000956A
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0007A8E0 File Offset: 0x00078AE0
		public  object Clone()
		{
			ComplexDArrayList complexDArrayList = new ComplexDArrayList(this._count);
			Array.Copy(this._array, 0, complexDArrayList._array, 0, this._count);
			complexDArrayList._count = this._count;
			complexDArrayList.int_0 = this.int_0;
			return complexDArrayList;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0000B3A1 File Offset: 0x000095A1
		public bool vmethod_1(ComplexD complexD_0)
		{
			return this.vmethod_4(complexD_0) >= 0;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0000B3B0 File Offset: 0x000095B0
		bool IList.Contains(object value)
		{
			return this.vmethod_1((ComplexD)value);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0000B3BE File Offset: 0x000095BE
		public  void vmethod_2(ComplexD[] complexD_0, int int_1)
		{
			this.method_2(complexD_0, int_1);
			Array.Copy(this._array, 0, complexD_0, int_1, this._count);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0000B3DC File Offset: 0x000095DC
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((ComplexD[])array, index);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0007A930 File Offset: 0x00078B30
		public  Interface51 vmethod_3()
		{
			return new ComplexDArrayList.Enumerator(this);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0007A948 File Offset: 0x00078B48
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0007A964 File Offset: 0x00078B64
		public  int vmethod_4(ComplexD complexD_0)
		{
			return Array.IndexOf<ComplexD>(this._array, complexD_0, 0, this._count);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0007A988 File Offset: 0x00078B88
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((ComplexD)value);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0007A9A4 File Offset: 0x00078BA4
		public  void vmethod_5(int int_1, ComplexD complexD_0)
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
			this._array[int_1] = complexD_0;
			this._count++;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0000B3F3 File Offset: 0x000095F3
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (ComplexD)value);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0007AA70 File Offset: 0x00078C70
		public  void vmethod_6(ComplexD complexD_0)
		{
			int num = this.vmethod_4(complexD_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0000B402 File Offset: 0x00009602
		void IList.Remove(object value)
		{
			this.vmethod_6((ComplexD)value);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0007AA94 File Offset: 0x00078C94
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(ComplexD);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0000B410 File Offset: 0x00009610
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0000B42F File Offset: 0x0000962F
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0007AB04 File Offset: 0x00078D04
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

		// Token: 0x06000DCC RID: 3532 RVA: 0x0007ABA4 File Offset: 0x00078DA4
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0007ABDC File Offset: 0x00078DDC
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

		// Token: 0x040005C4 RID: 1476
		private const int _defaultCapacity = 16;

		// Token: 0x040005C5 RID: 1477
		private ComplexD[] _array = null;

		// Token: 0x040005C6 RID: 1478
		private int _count = 0;

		// Token: 0x040005C7 RID: 1479
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x02000250 RID: 592
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface51
		{
			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0007AC2C File Offset: 0x00078E2C
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06000DCF RID: 3535 RVA: 0x0000B447 File Offset: 0x00009647
			internal Enumerator(ComplexDArrayList complexDArrayList_0)
			{
				this._collection = complexDArrayList_0;
				this._version = complexDArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06000DD0 RID: 3536 RVA: 0x0007AC48 File Offset: 0x00078E48
			public ComplexD vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x06000DD1 RID: 3537 RVA: 0x0007AC8C File Offset: 0x00078E8C
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06000DD2 RID: 3538 RVA: 0x0000B469 File Offset: 0x00009669
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x040005C8 RID: 1480
			private readonly ComplexDArrayList _collection;

			// Token: 0x040005C9 RID: 1481
			private readonly int _version;

			// Token: 0x040005CA RID: 1482
			private int _index;
		}
	}
}
