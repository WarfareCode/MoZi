using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ns15
{
	// Token: 0x02000591 RID: 1425
	public sealed class Class729 : IEnumerable, ICollection, IList
	{
		// Token: 0x170002A1 RID: 673
		public object this[int index]
		{
			get
			{
				Class729.Class730 @class = new Class729.Class730();
				@class.int_0 = index;
				@class.class729_0 = this;
				return this.method_1<object>(new Func<object>(@class.method_0));
			}
			set
			{
				Class729.Class731 @class = new Class729.Class731();
				@class.int_0 = index;
				@class.value = value;
				@class.class729_0 = this;
				this.method_0(new Action(@class.method_0));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000E2A64 File Offset: 0x000E0C64
		public int Count
		{
			get
			{
				return this.method_1<int>(new Func<int>(this.method_2));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000150B9 File Offset: 0x000132B9
		public bool IsReadOnly
		{
			get
			{
				return this.ilist_0.IsReadOnly;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000E2A88 File Offset: 0x000E0C88
		public object SyncRoot
		{
			get
			{
				return this.ilist_0.SyncRoot;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0000945D File Offset: 0x0000765D
		public bool IsSynchronized
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000150C6 File Offset: 0x000132C6
		public bool IsFixedSize
		{
			get
			{
				return this.ilist_0.IsFixedSize;
			}
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x000E2AA4 File Offset: 0x000E0CA4
		public int Add(object value)
		{
			Class729.Class732 @class = new Class729.Class732();
			@class.value = value;
			@class.class729_0 = this;
			return this.method_1<int>(new Func<int>(@class.method_0));
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x000150D3 File Offset: 0x000132D3
		public void Clear()
		{
			this.method_0(new Action(this.method_3));
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x000E2ADC File Offset: 0x000E0CDC
		public bool Contains(object value)
		{
			Class729.Class733 @class = new Class729.Class733();
			@class.value = value;
			@class.class729_0 = this;
			return this.method_1<bool>(new Func<bool>(@class.method_0));
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000E2B10 File Offset: 0x000E0D10
		public int IndexOf(object value)
		{
			Class729.Class734 @class = new Class729.Class734();
			@class.value = value;
			@class.class729_0 = this;
			return this.method_1<int>(new Func<int>(@class.method_0));
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000E2B48 File Offset: 0x000E0D48
		public void Insert(int index, object value)
		{
			Class729.Class735 @class = new Class729.Class735();
			@class.int_0 = index;
			@class.value = value;
			@class.class729_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000E2B84 File Offset: 0x000E0D84
		public void Remove(object value)
		{
			Class729.Class736 @class = new Class729.Class736();
			@class.value = value;
			@class.class729_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000E2BB8 File Offset: 0x000E0DB8
		public void RemoveAt(int index)
		{
			Class729.Class737 @class = new Class729.Class737();
			@class.int_0 = index;
			@class.class729_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000E2BEC File Offset: 0x000E0DEC
		public void CopyTo(Array array, int index)
		{
			Class729.Class738 @class = new Class729.Class738();
			@class.array_0 = array;
			@class.int_0 = index;
			@class.class729_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000E2C28 File Offset: 0x000E0E28
		public IEnumerator GetEnumerator()
		{
			return this.method_1<IEnumerator>(new Func<IEnumerator>(this.method_4));
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000E2C4C File Offset: 0x000E0E4C
		private void method_0(Action action_0)
		{
			lock (this.ilist_0.SyncRoot)
			{
				action_0();
			}
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000E2C94 File Offset: 0x000E0E94
		private TResult method_1<TResult>(Func<TResult> func_0)
		{
			TResult result;
			lock (this.ilist_0.SyncRoot)
			{
				result = func_0();
			}
			return result;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000E2CE0 File Offset: 0x000E0EE0
		[CompilerGenerated]
		private int method_2()
		{
			return this.ilist_0.Count;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000150E7 File Offset: 0x000132E7
		[CompilerGenerated]
		private void method_3()
		{
			this.ilist_0.Clear();
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000E2CFC File Offset: 0x000E0EFC
		[CompilerGenerated]
		private IEnumerator method_4()
		{
			return this.ilist_0.GetEnumerator();
		}

		// Token: 0x0400119D RID: 4509
		private readonly IList ilist_0;

		// Token: 0x02000592 RID: 1426
		[CompilerGenerated]
		private sealed class Class730
		{
			// Token: 0x060024B5 RID: 9397 RVA: 0x000E2D18 File Offset: 0x000E0F18
			public object method_0()
			{
				return this.class729_0.ilist_0[this.int_0];
			}

			// Token: 0x0400119E RID: 4510
			public Class729 class729_0;

			// Token: 0x0400119F RID: 4511
			public int int_0;
		}

		// Token: 0x02000593 RID: 1427
		[CompilerGenerated]
		private sealed class Class731
		{
			// Token: 0x060024B7 RID: 9399 RVA: 0x000150F4 File Offset: 0x000132F4
			public void method_0()
			{
				this.class729_0.ilist_0[this.int_0] = this.value;
			}

			// Token: 0x040011A0 RID: 4512
			public Class729 class729_0;

			// Token: 0x040011A1 RID: 4513
			public int int_0;

			// Token: 0x040011A2 RID: 4514
			public object value;
		}

		// Token: 0x02000594 RID: 1428
		[CompilerGenerated]
		private sealed class Class732
		{
			// Token: 0x060024B9 RID: 9401 RVA: 0x000E2D40 File Offset: 0x000E0F40
			public int method_0()
			{
				return this.class729_0.ilist_0.Add(this.value);
			}

			// Token: 0x040011A3 RID: 4515
			public Class729 class729_0;

			// Token: 0x040011A4 RID: 4516
			public object value;
		}

		// Token: 0x02000595 RID: 1429
		[CompilerGenerated]
		private sealed class Class733
		{
			// Token: 0x060024BB RID: 9403 RVA: 0x00015112 File Offset: 0x00013312
			public bool method_0()
			{
				return this.class729_0.ilist_0.Contains(this.value);
			}

			// Token: 0x040011A5 RID: 4517
			public Class729 class729_0;

			// Token: 0x040011A6 RID: 4518
			public object value;
		}

		// Token: 0x02000596 RID: 1430
		[CompilerGenerated]
		private sealed class Class734
		{
			// Token: 0x060024BD RID: 9405 RVA: 0x000E2D68 File Offset: 0x000E0F68
			public int method_0()
			{
				return this.class729_0.ilist_0.IndexOf(this.value);
			}

			// Token: 0x040011A7 RID: 4519
			public Class729 class729_0;

			// Token: 0x040011A8 RID: 4520
			public object value;
		}

		// Token: 0x02000597 RID: 1431
		[CompilerGenerated]
		private sealed class Class735
		{
			// Token: 0x060024BF RID: 9407 RVA: 0x0001512A File Offset: 0x0001332A
			public void method_0()
			{
				this.class729_0.ilist_0.Insert(this.int_0, this.value);
			}

			// Token: 0x040011A9 RID: 4521
			public Class729 class729_0;

			// Token: 0x040011AA RID: 4522
			public int int_0;

			// Token: 0x040011AB RID: 4523
			public object value;
		}

		// Token: 0x02000598 RID: 1432
		[CompilerGenerated]
		private sealed class Class736
		{
			// Token: 0x060024C1 RID: 9409 RVA: 0x00015148 File Offset: 0x00013348
			public void method_0()
			{
				this.class729_0.ilist_0.Remove(this.value);
			}

			// Token: 0x040011AC RID: 4524
			public Class729 class729_0;

			// Token: 0x040011AD RID: 4525
			public object value;
		}

		// Token: 0x02000599 RID: 1433
		[CompilerGenerated]
		private sealed class Class737
		{
			// Token: 0x060024C3 RID: 9411 RVA: 0x00015160 File Offset: 0x00013360
			public void method_0()
			{
				this.class729_0.ilist_0.RemoveAt(this.int_0);
			}

			// Token: 0x040011AE RID: 4526
			public Class729 class729_0;

			// Token: 0x040011AF RID: 4527
			public int int_0;
		}

		// Token: 0x0200059A RID: 1434
		[CompilerGenerated]
		private sealed class Class738
		{
			// Token: 0x060024C5 RID: 9413 RVA: 0x00015178 File Offset: 0x00013378
			public void method_0()
			{
				this.class729_0.ilist_0.CopyTo(this.array_0, this.int_0);
			}

			// Token: 0x040011B0 RID: 4528
			public Class729 class729_0;

			// Token: 0x040011B1 RID: 4529
			public Array array_0;

			// Token: 0x040011B2 RID: 4530
			public int int_0;
		}
	}
}
