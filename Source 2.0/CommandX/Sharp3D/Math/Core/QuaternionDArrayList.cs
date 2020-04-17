using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000359 RID: 857
	[Serializable]
	public sealed class QuaternionDArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x000882F0 File Offset: 0x000864F0
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001BA RID: 442
		public  QuaternionD this[int int_1]
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001BF RID: 447
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (QuaternionD)value;
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0000E614 File Offset: 0x0000C814
		public QuaternionDArrayList()
		{
			this._array = new QuaternionD[16];
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0008834C File Offset: 0x0008654C
		public QuaternionDArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new QuaternionD[int_1];
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000883A0 File Offset: 0x000865A0
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
					this._array = new QuaternionD[16];
				}
				else
				{
					QuaternionD[] array = new QuaternionD[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0008841C File Offset: 0x0008661C
		public  int Add(QuaternionD quaternionD_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = quaternionD_0;
			return this._count++;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00088484 File Offset: 0x00086684
		int IList.Add(object value)
		{
			return this.Add((QuaternionD)value);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0000E63E File Offset: 0x0000C83E
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000884A0 File Offset: 0x000866A0
		public  object Clone()
		{
			QuaternionDArrayList quaternionDArrayList = new QuaternionDArrayList(this._count);
			Array.Copy(this._array, 0, quaternionDArrayList._array, 0, this._count);
			quaternionDArrayList._count = this._count;
			quaternionDArrayList.int_0 = this.int_0;
			return quaternionDArrayList;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0000E675 File Offset: 0x0000C875
		public bool vmethod_1(QuaternionD quaternionD_0)
		{
			return this.vmethod_4(quaternionD_0) >= 0;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0000E684 File Offset: 0x0000C884
		bool IList.Contains(object value)
		{
			return this.vmethod_1((QuaternionD)value);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0000E692 File Offset: 0x0000C892
		public  void vmethod_2(QuaternionD[] quaternionD_0, int int_1)
		{
			this.method_2(quaternionD_0, int_1);
			Array.Copy(this._array, 0, quaternionD_0, int_1, this._count);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((QuaternionD[])array, index);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000884F0 File Offset: 0x000866F0
		public  Interface56 vmethod_3()
		{
			return new QuaternionDArrayList.Enumerator(this);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00088508 File Offset: 0x00086708
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00088524 File Offset: 0x00086724
		public  int vmethod_4(QuaternionD quaternionD_0)
		{
			return Array.IndexOf<QuaternionD>(this._array, quaternionD_0, 0, this._count);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00088548 File Offset: 0x00086748
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((QuaternionD)value);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00088564 File Offset: 0x00086764
		public  void vmethod_5(int int_1, QuaternionD quaternionD_0)
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
			this._array[int_1] = quaternionD_0;
			this._count++;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0000E6C7 File Offset: 0x0000C8C7
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (QuaternionD)value);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00088630 File Offset: 0x00086830
		public  void vmethod_6(QuaternionD quaternionD_0)
		{
			int num = this.vmethod_4(quaternionD_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0000E6D6 File Offset: 0x0000C8D6
		void IList.Remove(object value)
		{
			this.vmethod_6((QuaternionD)value);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00088654 File Offset: 0x00086854
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(QuaternionD);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0000E703 File Offset: 0x0000C903
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x000886C4 File Offset: 0x000868C4
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

		// Token: 0x06001454 RID: 5204 RVA: 0x00088764 File Offset: 0x00086964
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0008879C File Offset: 0x0008699C
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

		// Token: 0x0400086A RID: 2154
		private const int _defaultCapacity = 16;

		// Token: 0x0400086B RID: 2155
		private QuaternionD[] _array = null;

		// Token: 0x0400086C RID: 2156
		private int _count = 0;

		// Token: 0x0400086D RID: 2157
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x0200035A RID: 858
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface56
		{
			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06001456 RID: 5206 RVA: 0x000887EC File Offset: 0x000869EC
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x06001457 RID: 5207 RVA: 0x0000E71B File Offset: 0x0000C91B
			internal Enumerator(QuaternionDArrayList quaternionDArrayList_0)
			{
				this._collection = quaternionDArrayList_0;
				this._version = quaternionDArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x06001458 RID: 5208 RVA: 0x00088808 File Offset: 0x00086A08
			public QuaternionD vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x06001459 RID: 5209 RVA: 0x0008884C File Offset: 0x00086A4C
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x0600145A RID: 5210 RVA: 0x0000E73D File Offset: 0x0000C93D
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x0400086E RID: 2158
			private readonly QuaternionDArrayList _collection;

			// Token: 0x0400086F RID: 2159
			private readonly int _version;

			// Token: 0x04000870 RID: 2160
			private int _index;
		}
	}
}
