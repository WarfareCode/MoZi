using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000270 RID: 624
	[Serializable]
	public sealed class ComplexFArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0007B3B8 File Offset: 0x000795B8
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000134 RID: 308
		public  ComplexF this[int int_1]
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000139 RID: 313
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (ComplexF)value;
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0000BA69 File Offset: 0x00009C69
		public ComplexFArrayList()
		{
			this._array = new ComplexF[16];
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0007B414 File Offset: 0x00079614
		public ComplexFArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new ComplexF[int_1];
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0007B468 File Offset: 0x00079668
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
					this._array = new ComplexF[16];
				}
				else
				{
					ComplexF[] array = new ComplexF[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0007B4E4 File Offset: 0x000796E4
		public  int Add(ComplexF complexF_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = complexF_0;
			return this._count++;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0007B54C File Offset: 0x0007974C
		int IList.Add(object value)
		{
			return this.Add((ComplexF)value);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0000BA93 File Offset: 0x00009C93
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0007B568 File Offset: 0x00079768
		public  object Clone()
		{
			ComplexFArrayList complexFArrayList = new ComplexFArrayList(this._count);
			Array.Copy(this._array, 0, complexFArrayList._array, 0, this._count);
			complexFArrayList._count = this._count;
			complexFArrayList.int_0 = this.int_0;
			return complexFArrayList;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0000BACA File Offset: 0x00009CCA
		public bool vmethod_1(ComplexF complexF_0)
		{
			return this.vmethod_4(complexF_0) >= 0;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0000BAD9 File Offset: 0x00009CD9
		bool IList.Contains(object value)
		{
			return this.vmethod_1((ComplexF)value);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0000BAE7 File Offset: 0x00009CE7
		public  void vmethod_2(ComplexF[] complexF_0, int int_1)
		{
			this.method_2(complexF_0, int_1);
			Array.Copy(this._array, 0, complexF_0, int_1, this._count);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0000BB05 File Offset: 0x00009D05
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((ComplexF[])array, index);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0007B5B8 File Offset: 0x000797B8
		public  Interface52 vmethod_3()
		{
			return new ComplexFArrayList.Enumerator(this);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0007B5D0 File Offset: 0x000797D0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0007B5EC File Offset: 0x000797EC
		public  int vmethod_4(ComplexF complexF_0)
		{
			return Array.IndexOf<ComplexF>(this._array, complexF_0, 0, this._count);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0007B610 File Offset: 0x00079810
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((ComplexF)value);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0007B62C File Offset: 0x0007982C
		public  void vmethod_5(int int_1, ComplexF complexF_0)
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
			this._array[int_1] = complexF_0;
			this._count++;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0000BB1C File Offset: 0x00009D1C
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (ComplexF)value);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0007B6F8 File Offset: 0x000798F8
		public  void vmethod_6(ComplexF complexF_0)
		{
			int num = this.vmethod_4(complexF_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0000BB2B File Offset: 0x00009D2B
		void IList.Remove(object value)
		{
			this.vmethod_6((ComplexF)value);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0007B71C File Offset: 0x0007991C
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(ComplexF);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0000BB39 File Offset: 0x00009D39
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0000BB58 File Offset: 0x00009D58
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0007B78C File Offset: 0x0007998C
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

		// Token: 0x06000E86 RID: 3718 RVA: 0x0007B82C File Offset: 0x00079A2C
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0007B864 File Offset: 0x00079A64
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

		// Token: 0x04000603 RID: 1539
		private const int _defaultCapacity = 16;

		// Token: 0x04000604 RID: 1540
		private ComplexF[] _array = null;

		// Token: 0x04000605 RID: 1541
		private int _count = 0;

		// Token: 0x04000606 RID: 1542
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x02000271 RID: 625
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface52
		{
			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0007B8B4 File Offset: 0x00079AB4
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06000E89 RID: 3721 RVA: 0x0000BB70 File Offset: 0x00009D70
			internal Enumerator(ComplexFArrayList complexFArrayList_0)
			{
				this._collection = complexFArrayList_0;
				this._version = complexFArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06000E8A RID: 3722 RVA: 0x0007B8D0 File Offset: 0x00079AD0
			public ComplexF vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x06000E8B RID: 3723 RVA: 0x0007B914 File Offset: 0x00079B14
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x06000E8C RID: 3724 RVA: 0x0000BB92 File Offset: 0x00009D92
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x04000607 RID: 1543
			private readonly ComplexFArrayList _collection;

			// Token: 0x04000608 RID: 1544
			private readonly int _version;

			// Token: 0x04000609 RID: 1545
			private int _index;
		}
	}
}
