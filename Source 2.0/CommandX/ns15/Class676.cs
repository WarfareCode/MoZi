using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x02000553 RID: 1363
	public abstract class Class676
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x00014791 File Offset: 0x00012991
		protected Class676(Control control_1)
		{
			if (control_1 == null)
			{
				throw new ArgumentNullException("control");
			}
			this.control_0 = control_1;
			this.class683_0 = new Class676.Class683(this);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x000DFC98 File Offset: 0x000DDE98
		internal Control method_0()
		{
			return this.control_0;
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x000147C0 File Offset: 0x000129C0
		internal void method_1(Action action_0)
		{
			if (this.control_0.InvokeRequired)
			{
				this.control_0.BeginInvoke(action_0);
			}
			else
			{
				action_0();
			}
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x000DFCB0 File Offset: 0x000DDEB0
		internal T method_2<T>(Func<T> func_0)
		{
			T result;
			if (this.control_0.InvokeRequired)
			{
				result = (T)((object)this.control_0.Invoke(func_0));
			}
			else
			{
				result = func_0();
			}
			return result;
		}

		// Token: 0x04001113 RID: 4371
		protected readonly Control control_0;

		// Token: 0x04001114 RID: 4372
		private readonly Class676.Class683 class683_0;

		// Token: 0x02000554 RID: 1364
		public sealed class Class683 : IList<Class676>, ICollection<Class676>, IEnumerable<Class676>, IEnumerable, ICollection, IList
		{
			// Token: 0x17000282 RID: 642
			public Class676 this[int index]
			{
				get
				{
					Class676.Class683.Class684 @class = new Class676.Class683.Class684();
					@class.int_0 = index;
					@class.class683_0 = this;
					return this.class676_0.method_2<Class677<Control>>(new Func<Class677<Control>>(@class.method_0));
				}
				set
				{
					throw new InvalidOperationException();
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x0600234A RID: 9034 RVA: 0x000DFD28 File Offset: 0x000DDF28
			public int Count
			{
				get
				{
					return this.class676_0.method_2<int>(new Func<int>(this.method_2));
				}
			}

			// Token: 0x17000284 RID: 644
			object IList.this[int index]
			{
				get
				{
					Class676.Class683.Class690 @class = new Class676.Class683.Class690();
					@class.int_0 = index;
					@class.class683_0 = this;
					return this.class676_0.method_2<object>(new Func<object>(@class.method_0));
				}
				set
				{
					Class676.Class683.Class691 @class = new Class676.Class683.Class691();
					@class.int_0 = index;
					@class.value = value;
					@class.class683_0 = this;
					this.class676_0.method_1(new Action(@class.method_0));
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x0600234D RID: 9037 RVA: 0x000147EE File Offset: 0x000129EE
			bool IList.IsFixedSize
			{
				get
				{
					return ((IList)this.class676_0.method_0().Controls).IsFixedSize;
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x0600234E RID: 9038 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection<Class676>.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x0600234F RID: 9039 RVA: 0x00014805 File Offset: 0x00012A05
			bool IList.IsReadOnly
			{
				get
				{
					return ((IList)this.class676_0.method_0().Controls).IsReadOnly;
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06002350 RID: 9040 RVA: 0x0001481C File Offset: 0x00012A1C
			bool ICollection.IsSynchronized
			{
				get
				{
					return ((ICollection)this.class676_0.method_0().Controls).IsSynchronized;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06002351 RID: 9041 RVA: 0x000DFDCC File Offset: 0x000DDFCC
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this.class676_0.method_0().Controls).SyncRoot;
				}
			}

			// Token: 0x06002352 RID: 9042 RVA: 0x00014833 File Offset: 0x00012A33
			internal Class683(Class676 class676_1)
			{
				if (class676_1 == null)
				{
					throw new ArgumentNullException("control");
				}
				this.class676_0 = class676_1;
			}

			// Token: 0x06002353 RID: 9043 RVA: 0x000DFDF0 File Offset: 0x000DDFF0
			public void Add(Control control_0)
			{
				Class676.Class683.Class685 @class = new Class676.Class683.Class685();
				@class.control_0 = control_0;
				@class.class683_0 = this;
				this.class676_0.method_1(new Action(@class.method_0));
			}

			// Token: 0x06002354 RID: 9044 RVA: 0x00014856 File Offset: 0x00012A56
			public void Add(Class676 item)
			{
				this.Add(item.method_0());
			}

			// Token: 0x06002355 RID: 9045 RVA: 0x00014864 File Offset: 0x00012A64
			public void Clear()
			{
				this.class676_0.method_1(new Action(this.method_3));
			}

			// Token: 0x06002356 RID: 9046 RVA: 0x000DFE28 File Offset: 0x000DE028
			public bool Contains(Control control_0)
			{
				Class676.Class683.Class686 @class = new Class676.Class683.Class686();
				@class.control_0 = control_0;
				@class.class683_0 = this;
				return this.class676_0.method_2<bool>(new Func<bool>(@class.method_0));
			}

			// Token: 0x06002357 RID: 9047 RVA: 0x0001487D File Offset: 0x00012A7D
			public bool Contains(Class676 item)
			{
				return this.Contains(item.method_0());
			}

			// Token: 0x06002358 RID: 9048 RVA: 0x000DFE60 File Offset: 0x000DE060
			public void CopyTo(Class676[] array, int arrayIndex)
			{
				Class676[] array2 = this.method_1().ToArray<Class676>();
				array2.CopyTo(array, arrayIndex);
			}

			// Token: 0x06002359 RID: 9049 RVA: 0x000DFE84 File Offset: 0x000DE084
			public int IndexOf(Control control_0)
			{
				Class676.Class683.Class687 @class = new Class676.Class683.Class687();
				@class.control_0 = control_0;
				@class.class683_0 = this;
				return this.class676_0.method_2<int>(new Func<int>(@class.method_0));
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x000DFEC0 File Offset: 0x000DE0C0
			public int IndexOf(Class676 item)
			{
				return this.IndexOf(item.method_0());
			}

			// Token: 0x0600235B RID: 9051 RVA: 0x000DFEDC File Offset: 0x000DE0DC
			public void method_0(Control control_0)
			{
				Class676.Class683.Class688 @class = new Class676.Class683.Class688();
				@class.value = control_0;
				@class.class683_0 = this;
				this.class676_0.method_1(new Action(@class.method_0));
			}

			// Token: 0x0600235C RID: 9052 RVA: 0x0001488B File Offset: 0x00012A8B
			public bool Remove(Class676 item)
			{
				this.method_0(item.method_0());
				return true;
			}

			// Token: 0x0600235D RID: 9053 RVA: 0x000DFF14 File Offset: 0x000DE114
			public void RemoveAt(int index)
			{
				Class676.Class683.Class689 @class = new Class676.Class683.Class689();
				@class.int_0 = index;
				@class.class683_0 = this;
				this.class676_0.method_1(new Action(@class.method_0));
			}

			// Token: 0x0600235E RID: 9054 RVA: 0x000DFF4C File Offset: 0x000DE14C
			public IEnumerator<Class676> GetEnumerator()
			{
				return this.method_1().GetEnumerator();
			}

			// Token: 0x0600235F RID: 9055 RVA: 0x000DFF68 File Offset: 0x000DE168
			private IEnumerable<Class676> method_1()
			{
				IEnumerable<Control> source = this.class676_0.method_2<Control.ControlCollection>(new Func<Control.ControlCollection>(this.method_4)).Cast<Control>();
				if (Class676.Class683.func_0 == null)
				{
					Class676.Class683.func_0 = new Func<Control, Class676>(Class676.Class683.smethod_0);
				}
				return source.Select(Class676.Class683.func_0);
			}

			// Token: 0x06002360 RID: 9056 RVA: 0x000DFFC0 File Offset: 0x000DE1C0
			int IList.Add(object value)
			{
				Class676.Class683.Class692 @class = new Class676.Class683.Class692();
				@class.value = value;
				@class.class683_0 = this;
				return this.class676_0.method_2<int>(new Func<int>(@class.method_0));
			}

			// Token: 0x06002361 RID: 9057 RVA: 0x000DFFFC File Offset: 0x000DE1FC
			bool IList.Contains(object value)
			{
				Class676.Class683.Class693 @class = new Class676.Class683.Class693();
				@class.value = value;
				@class.class683_0 = this;
				return this.class676_0.method_2<bool>(new Func<bool>(@class.method_0));
			}

			// Token: 0x06002362 RID: 9058 RVA: 0x000DFE60 File Offset: 0x000DE060
			void ICollection.CopyTo(Array array, int index)
			{
				Class676[] array2 = this.method_1().ToArray<Class676>();
				array2.CopyTo(array, index);
			}

			// Token: 0x06002363 RID: 9059 RVA: 0x000E0034 File Offset: 0x000DE234
			int IList.IndexOf(object value)
			{
				Class676.Class683.Class694 @class = new Class676.Class683.Class694();
				@class.value = value;
				@class.class683_0 = this;
				return this.class676_0.method_2<int>(new Func<int>(@class.method_0));
			}

			// Token: 0x06002364 RID: 9060 RVA: 0x000E0070 File Offset: 0x000DE270
			void IList.Insert(int index, object value)
			{
				Class676.Class683.Class695 @class = new Class676.Class683.Class695();
				@class.int_0 = index;
				@class.value = value;
				@class.class683_0 = this;
				this.class676_0.method_1(new Action(@class.method_0));
			}

			// Token: 0x06002365 RID: 9061 RVA: 0x0001489A File Offset: 0x00012A9A
			void IList<Class676>.Insert(int index, Class676 item)
			{
				((IList)this).Insert(index, item);
			}

			// Token: 0x06002366 RID: 9062 RVA: 0x000E00B0 File Offset: 0x000DE2B0
			void IList.Remove(object value)
			{
				Class676.Class683.Class696 @class = new Class676.Class683.Class696();
				@class.value = value;
				@class.class683_0 = this;
				this.class676_0.method_1(new Action(@class.method_0));
			}

			// Token: 0x06002367 RID: 9063 RVA: 0x000E00E8 File Offset: 0x000DE2E8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x06002368 RID: 9064 RVA: 0x000E0100 File Offset: 0x000DE300
			[CompilerGenerated]
			private int method_2()
			{
				return this.class676_0.method_0().Controls.Count;
			}

			// Token: 0x06002369 RID: 9065 RVA: 0x000148A4 File Offset: 0x00012AA4
			[CompilerGenerated]
			private void method_3()
			{
				this.class676_0.method_0().Controls.Clear();
			}

			// Token: 0x0600236A RID: 9066 RVA: 0x000E0124 File Offset: 0x000DE324
			[CompilerGenerated]
			private Control.ControlCollection method_4()
			{
				return this.class676_0.method_0().Controls;
			}

			// Token: 0x0600236B RID: 9067 RVA: 0x000E0144 File Offset: 0x000DE344
			[CompilerGenerated]
			private static Class676 smethod_0(Control control_0)
			{
				return Class739.smethod_0<Control>(control_0);
			}

			// Token: 0x04001115 RID: 4373
			private readonly Class676 class676_0;

			// Token: 0x04001116 RID: 4374
			[CompilerGenerated]
			private static Func<Control, Class676> func_0;

			// Token: 0x02000555 RID: 1365
			[CompilerGenerated]
			private sealed class Class684
			{
				// Token: 0x0600236C RID: 9068 RVA: 0x000E015C File Offset: 0x000DE35C
				public Class677<Control> method_0()
				{
					return Class739.smethod_0<Control>(this.class683_0.class676_0.method_0().Controls[this.int_0]);
				}

				// Token: 0x04001117 RID: 4375
				public Class676.Class683 class683_0;

				// Token: 0x04001118 RID: 4376
				public int int_0;
			}

			// Token: 0x02000556 RID: 1366
			[CompilerGenerated]
			private sealed class Class685
			{
				// Token: 0x0600236E RID: 9070 RVA: 0x000148BB File Offset: 0x00012ABB
				public void method_0()
				{
					this.class683_0.class676_0.method_0().Controls.Add(this.control_0);
				}

				// Token: 0x04001119 RID: 4377
				public Class676.Class683 class683_0;

				// Token: 0x0400111A RID: 4378
				public Control control_0;
			}

			// Token: 0x02000557 RID: 1367
			[CompilerGenerated]
			private sealed class Class686
			{
				// Token: 0x06002370 RID: 9072 RVA: 0x000148DD File Offset: 0x00012ADD
				public bool method_0()
				{
					return this.class683_0.class676_0.method_0().Controls.Contains(this.control_0);
				}

				// Token: 0x0400111B RID: 4379
				public Class676.Class683 class683_0;

				// Token: 0x0400111C RID: 4380
				public Control control_0;
			}

			// Token: 0x02000558 RID: 1368
			[CompilerGenerated]
			private sealed class Class687
			{
				// Token: 0x06002372 RID: 9074 RVA: 0x000E0190 File Offset: 0x000DE390
				public int method_0()
				{
					return this.class683_0.class676_0.method_0().Controls.IndexOf(this.control_0);
				}

				// Token: 0x0400111D RID: 4381
				public Class676.Class683 class683_0;

				// Token: 0x0400111E RID: 4382
				public Control control_0;
			}

			// Token: 0x02000559 RID: 1369
			[CompilerGenerated]
			private sealed class Class688
			{
				// Token: 0x06002374 RID: 9076 RVA: 0x000148FF File Offset: 0x00012AFF
				public void method_0()
				{
					this.class683_0.class676_0.method_0().Controls.Remove(this.value);
				}

				// Token: 0x0400111F RID: 4383
				public Class676.Class683 class683_0;

				// Token: 0x04001120 RID: 4384
				public Control value;
			}

			// Token: 0x0200055A RID: 1370
			[CompilerGenerated]
			private sealed class Class689
			{
				// Token: 0x06002376 RID: 9078 RVA: 0x00014921 File Offset: 0x00012B21
				public void method_0()
				{
					this.class683_0.class676_0.method_0().Controls.RemoveAt(this.int_0);
				}

				// Token: 0x04001121 RID: 4385
				public Class676.Class683 class683_0;

				// Token: 0x04001122 RID: 4386
				public int int_0;
			}

			// Token: 0x0200055B RID: 1371
			[CompilerGenerated]
			private sealed class Class690
			{
				// Token: 0x06002378 RID: 9080 RVA: 0x000E01C0 File Offset: 0x000DE3C0
				public object method_0()
				{
					return ((IList)this.class683_0.class676_0.method_0().Controls)[this.int_0];
				}

				// Token: 0x04001123 RID: 4387
				public Class676.Class683 class683_0;

				// Token: 0x04001124 RID: 4388
				public int int_0;
			}

			// Token: 0x0200055C RID: 1372
			[CompilerGenerated]
			private sealed class Class691
			{
				// Token: 0x0600237A RID: 9082 RVA: 0x00014943 File Offset: 0x00012B43
				public void method_0()
				{
					((IList)this.class683_0.class676_0.method_0().Controls)[this.int_0] = this.value;
				}

				// Token: 0x04001125 RID: 4389
				public Class676.Class683 class683_0;

				// Token: 0x04001126 RID: 4390
				public int int_0;

				// Token: 0x04001127 RID: 4391
				public object value;
			}

			// Token: 0x0200055D RID: 1373
			[CompilerGenerated]
			private sealed class Class692
			{
				// Token: 0x0600237C RID: 9084 RVA: 0x000E01F0 File Offset: 0x000DE3F0
				public int method_0()
				{
					return ((IList)this.class683_0.class676_0.method_0().Controls).Add(this.value);
				}

				// Token: 0x04001128 RID: 4392
				public Class676.Class683 class683_0;

				// Token: 0x04001129 RID: 4393
				public object value;
			}

			// Token: 0x0200055E RID: 1374
			[CompilerGenerated]
			private sealed class Class693
			{
				// Token: 0x0600237E RID: 9086 RVA: 0x0001496B File Offset: 0x00012B6B
				public bool method_0()
				{
					return ((IList)this.class683_0.class676_0.method_0().Controls).Contains(this.value);
				}

				// Token: 0x0400112A RID: 4394
				public Class676.Class683 class683_0;

				// Token: 0x0400112B RID: 4395
				public object value;
			}

			// Token: 0x0200055F RID: 1375
			[CompilerGenerated]
			private sealed class Class694
			{
				// Token: 0x06002380 RID: 9088 RVA: 0x000E0220 File Offset: 0x000DE420
				public int method_0()
				{
					return ((IList)this.class683_0.class676_0.method_0().Controls).IndexOf(this.value);
				}

				// Token: 0x0400112C RID: 4396
				public Class676.Class683 class683_0;

				// Token: 0x0400112D RID: 4397
				public object value;
			}

			// Token: 0x02000560 RID: 1376
			[CompilerGenerated]
			private sealed class Class695
			{
				// Token: 0x06002382 RID: 9090 RVA: 0x0001498D File Offset: 0x00012B8D
				public void method_0()
				{
					((IList)this.class683_0.class676_0.method_0().Controls).Insert(this.int_0, this.value);
				}

				// Token: 0x0400112E RID: 4398
				public Class676.Class683 class683_0;

				// Token: 0x0400112F RID: 4399
				public int int_0;

				// Token: 0x04001130 RID: 4400
				public object value;
			}

			// Token: 0x02000561 RID: 1377
			[CompilerGenerated]
			private sealed class Class696
			{
				// Token: 0x06002384 RID: 9092 RVA: 0x000149B5 File Offset: 0x00012BB5
				public void method_0()
				{
					((IList)this.class683_0.class676_0.method_0().Controls).Remove(this.value);
				}

				// Token: 0x04001131 RID: 4401
				public Class676.Class683 class683_0;

				// Token: 0x04001132 RID: 4402
				public object value;
			}
		}
	}
}
