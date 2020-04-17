using System;
using System.Collections;
using ns30;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200036C RID: 876
	[Serializable]
	public sealed class QuaternionFArrayList : IEnumerable, ICloneable, ICollection, IList
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00089F68 File Offset: 0x00088168
		public  int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001C3 RID: 451
		public  QuaternionF this[int int_1]
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x0006A0BC File Offset: 0x000682BC
		public  object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001C8 RID: 456
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (QuaternionF)value;
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0000EAE1 File Offset: 0x0000CCE1
		public QuaternionFArrayList()
		{
			this._array = new QuaternionF[16];
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00089FC4 File Offset: 0x000881C4
		public QuaternionFArrayList(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", int_1, "Argument cannot be negative.");
			}
			this._array = new QuaternionF[int_1];
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0008A018 File Offset: 0x00088218
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
					this._array = new QuaternionF[16];
				}
				else
				{
					QuaternionF[] array = new QuaternionF[int_1];
					Array.Copy(this._array, array, this._count);
					this._array = array;
				}
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0008A094 File Offset: 0x00088294
		public  int Add(QuaternionF quaternionF_0)
		{
			if (this._count == this._array.Length)
			{
				this.method_3(this._count + 1);
			}
			this.int_0++;
			this._array[this._count] = quaternionF_0;
			return this._count++;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0008A0FC File Offset: 0x000882FC
		int IList.Add(object value)
		{
			return this.Add((QuaternionF)value);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0000EB0B File Offset: 0x0000CD0B
		public  void Clear()
		{
			if (this._count != 0)
			{
				this.int_0++;
				Array.Clear(this._array, 0, this._count);
				this._count = 0;
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0008A118 File Offset: 0x00088318
		public  object Clone()
		{
			QuaternionFArrayList quaternionFArrayList = new QuaternionFArrayList(this._count);
			Array.Copy(this._array, 0, quaternionFArrayList._array, 0, this._count);
			quaternionFArrayList._count = this._count;
			quaternionFArrayList.int_0 = this.int_0;
			return quaternionFArrayList;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0000EB42 File Offset: 0x0000CD42
		public bool vmethod_1(QuaternionF quaternionF_0)
		{
			return this.vmethod_4(quaternionF_0) >= 0;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0000EB51 File Offset: 0x0000CD51
		bool IList.Contains(object value)
		{
			return this.vmethod_1((QuaternionF)value);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0000EB5F File Offset: 0x0000CD5F
		public  void vmethod_2(QuaternionF[] quaternionF_0, int int_1)
		{
			this.method_2(quaternionF_0, int_1);
			Array.Copy(this._array, 0, quaternionF_0, int_1, this._count);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0000EB7D File Offset: 0x0000CD7D
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_2(array, index);
			this.vmethod_2((QuaternionF[])array, index);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0008A168 File Offset: 0x00088368
		public  Interface57 vmethod_3()
		{
			return new QuaternionFArrayList.Enumerator(this);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0008A180 File Offset: 0x00088380
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.vmethod_3();
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0008A19C File Offset: 0x0008839C
		public  int vmethod_4(QuaternionF quaternionF_0)
		{
			return Array.IndexOf<QuaternionF>(this._array, quaternionF_0, 0, this._count);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0008A1C0 File Offset: 0x000883C0
		int IList.IndexOf(object value)
		{
			return this.vmethod_4((QuaternionF)value);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0008A1DC File Offset: 0x000883DC
		public  void vmethod_5(int int_1, QuaternionF quaternionF_0)
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
			this._array[int_1] = quaternionF_0;
			this._count++;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0000EB94 File Offset: 0x0000CD94
		void IList.Insert(int index, object value)
		{
			this.vmethod_5(index, (QuaternionF)value);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0008A2A8 File Offset: 0x000884A8
		public  void vmethod_6(QuaternionF quaternionF_0)
		{
			int num = this.vmethod_4(quaternionF_0);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0000EBA3 File Offset: 0x0000CDA3
		void IList.Remove(object value)
		{
			this.vmethod_6((QuaternionF)value);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0008A2CC File Offset: 0x000884CC
		public  void RemoveAt(int index)
		{
			this.method_4(index);
			this.int_0++;
			if (index < --this._count)
			{
				Array.Copy(this._array, index + 1, this._array, index, this._count - index);
			}
			this._array[this._count] = default(QuaternionF);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0000EBB1 File Offset: 0x0000CDB1
		private void method_0(int int_1)
		{
			if (int_1 < 0 || int_1 >= this._count)
			{
				throw new InvalidOperationException("Enumerator is not on a collection element.");
			}
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		private void method_1(int int_1)
		{
			if (int_1 != this.int_0)
			{
				throw new InvalidOperationException("Enumerator invalidated by modification to collection.");
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0008A33C File Offset: 0x0008853C
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

		// Token: 0x060014E8 RID: 5352 RVA: 0x0008A3DC File Offset: 0x000885DC
		private void method_3(int int_1)
		{
			int num = (this._array.Length == 0) ? 16 : (this._array.Length * 2);
			if (num < int_1)
			{
				num = int_1;
			}
			this.vmethod_0(num);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0008A414 File Offset: 0x00088614
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

		// Token: 0x040008CB RID: 2251
		private const int _defaultCapacity = 16;

		// Token: 0x040008CC RID: 2252
		private QuaternionF[] _array = null;

		// Token: 0x040008CD RID: 2253
		private int _count = 0;

		// Token: 0x040008CE RID: 2254
		[NonSerialized]
		private int int_0 = 0;

		// Token: 0x0200036D RID: 877
		[Serializable]
		private sealed class Enumerator : IEnumerator, Interface57
		{
			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x060014EA RID: 5354 RVA: 0x0008A464 File Offset: 0x00088664
			object IEnumerator.Current
			{
				get
				{
					return this.vmethod_0();
				}
			}

			// Token: 0x060014EB RID: 5355 RVA: 0x0000EBE8 File Offset: 0x0000CDE8
			internal Enumerator(QuaternionFArrayList quaternionFArrayList_0)
			{
				this._collection = quaternionFArrayList_0;
				this._version = quaternionFArrayList_0.int_0;
				this._index = -1;
			}

			// Token: 0x060014EC RID: 5356 RVA: 0x0008A480 File Offset: 0x00088680
			public QuaternionF vmethod_0()
			{
				this._collection.method_0(this._index);
				this._collection.method_1(this._version);
				return this._collection[this._index];
			}

			// Token: 0x060014ED RID: 5357 RVA: 0x0008A4C4 File Offset: 0x000886C4
			public bool MoveNext()
			{
				this._collection.method_1(this._version);
				return ++this._index < this._collection.Count;
			}

			// Token: 0x060014EE RID: 5358 RVA: 0x0000EC0A File Offset: 0x0000CE0A
			public void Reset()
			{
				this._collection.method_1(this._version);
				this._index = -1;
			}

			// Token: 0x040008CF RID: 2255
			private readonly QuaternionFArrayList _collection;

			// Token: 0x040008D0 RID: 2256
			private readonly int _version;

			// Token: 0x040008D1 RID: 2257
			private int _index;
		}
	}
}
