using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x020005EC RID: 1516
	public sealed class Class681 : Class677<ComboBox>
	{
		// Token: 0x06002663 RID: 9827 RVA: 0x00015B77 File Offset: 0x00013D77
		internal Class681(ComboBox comboBox_0) : base(comboBox_0)
		{
			this.class792_0 = new Class681.Class792(this);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000EA188 File Offset: 0x000E8388
		public void method_6(int int_0)
		{
			Class681.Class801 @class = new Class681.Class801();
			@class.value = int_0;
			base.method_4(new Action<ComboBox>(@class.method_0));
		}

		// Token: 0x04001264 RID: 4708
		private readonly Class681.Class792 class792_0;

		// Token: 0x020005ED RID: 1517
		public sealed class Class792 : IEnumerable, ICollection, IList
		{
			// Token: 0x170002CB RID: 715
			public object this[int index]
			{
				get
				{
					Class681.Class792.Class793 @class = new Class681.Class792.Class793();
					@class.int_0 = index;
					return this.class681_0.method_5<object>(new Func<ComboBox, object>(@class.method_0));
				}
				set
				{
					Class681.Class792.Class794 @class = new Class681.Class792.Class794();
					@class.int_0 = index;
					@class.value = value;
					this.class681_0.method_4(new Action<ComboBox>(@class.method_0));
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x06002667 RID: 9831 RVA: 0x000EA220 File Offset: 0x000E8420
			public int Count
			{
				get
				{
					Class677<ComboBox> @class = this.class681_0;
					if (Class681.Class792.func_0 == null)
					{
						Class681.Class792.func_0 = new Func<ComboBox, int>(Class681.Class792.smethod_0);
					}
					return @class.method_5<int>(Class681.Class792.func_0);
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06002668 RID: 9832 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06002669 RID: 9833 RVA: 0x000EA260 File Offset: 0x000E8460
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this.class681_0.method_3().Items).SyncRoot;
				}
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x0600266A RID: 9834 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x0600266B RID: 9835 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x0600266C RID: 9836 RVA: 0x00015B8C File Offset: 0x00013D8C
			internal Class792(Class681 class681_1)
			{
				if (class681_1 == null)
				{
					throw new ArgumentNullException("comboBox");
				}
				this.class681_0 = class681_1;
			}

			// Token: 0x0600266D RID: 9837 RVA: 0x000EA284 File Offset: 0x000E8484
			public int Add(object value)
			{
				Class681.Class792.Class795 @class = new Class681.Class792.Class795();
				@class.object_0 = value;
				return this.class681_0.method_5<int>(new Func<ComboBox, int>(@class.method_0));
			}

			// Token: 0x0600266E RID: 9838 RVA: 0x000EA2B8 File Offset: 0x000E84B8
			public void Clear()
			{
				Class677<ComboBox> @class = this.class681_0;
				if (Class681.Class792.action_0 == null)
				{
					Class681.Class792.action_0 = new Action<ComboBox>(Class681.Class792.smethod_1);
				}
				@class.method_4(Class681.Class792.action_0);
			}

			// Token: 0x0600266F RID: 9839 RVA: 0x000EA2F8 File Offset: 0x000E84F8
			public bool Contains(object value)
			{
				Class681.Class792.Class796 @class = new Class681.Class792.Class796();
				@class.value = value;
				return this.class681_0.method_5<bool>(new Func<ComboBox, bool>(@class.method_0));
			}

			// Token: 0x06002670 RID: 9840 RVA: 0x000EA32C File Offset: 0x000E852C
			public int IndexOf(object value)
			{
				Class681.Class792.Class797 @class = new Class681.Class792.Class797();
				@class.value = value;
				return this.class681_0.method_5<int>(new Func<ComboBox, int>(@class.method_0));
			}

			// Token: 0x06002671 RID: 9841 RVA: 0x000EA360 File Offset: 0x000E8560
			public void Insert(int index, object value)
			{
				Class681.Class792.Class798 @class = new Class681.Class792.Class798();
				@class.int_0 = index;
				@class.object_0 = value;
				this.class681_0.method_4(new Action<ComboBox>(@class.method_0));
			}

			// Token: 0x06002672 RID: 9842 RVA: 0x000EA398 File Offset: 0x000E8598
			public void Remove(object value)
			{
				Class681.Class792.Class799 @class = new Class681.Class792.Class799();
				@class.value = value;
				this.class681_0.method_4(new Action<ComboBox>(@class.method_0));
			}

			// Token: 0x06002673 RID: 9843 RVA: 0x000EA3CC File Offset: 0x000E85CC
			public void RemoveAt(int index)
			{
				Class681.Class792.Class800 @class = new Class681.Class792.Class800();
				@class.int_0 = index;
				this.class681_0.method_4(new Action<ComboBox>(@class.method_0));
			}

			// Token: 0x06002674 RID: 9844 RVA: 0x000EA400 File Offset: 0x000E8600
			public IEnumerator GetEnumerator()
			{
				Class677<ComboBox> @class = this.class681_0;
				if (Class681.Class792.func_1 == null)
				{
					Class681.Class792.func_1 = new Func<ComboBox, IEnumerator>(Class681.Class792.smethod_2);
				}
				return @class.method_5<IEnumerator>(Class681.Class792.func_1);
			}

			// Token: 0x06002675 RID: 9845 RVA: 0x000EA440 File Offset: 0x000E8640
			void ICollection.CopyTo(Array array, int index)
			{
				for (int i = 0; i < this.Count; i++)
				{
					array.SetValue(this[i], index + i);
				}
			}

			// Token: 0x06002676 RID: 9846 RVA: 0x000EA470 File Offset: 0x000E8670
			[CompilerGenerated]
			private static int smethod_0(ComboBox comboBox_0)
			{
				return comboBox_0.Items.Count;
			}

			// Token: 0x06002677 RID: 9847 RVA: 0x00015BAF File Offset: 0x00013DAF
			[CompilerGenerated]
			private static void smethod_1(ComboBox comboBox_0)
			{
				comboBox_0.Items.Clear();
			}

			// Token: 0x06002678 RID: 9848 RVA: 0x000EA48C File Offset: 0x000E868C
			[CompilerGenerated]
			private static IEnumerator smethod_2(ComboBox comboBox_0)
			{
				return comboBox_0.Items.GetEnumerator();
			}

			// Token: 0x04001265 RID: 4709
			private readonly Class681 class681_0;

			// Token: 0x04001266 RID: 4710
			[CompilerGenerated]
			private static Func<ComboBox, int> func_0;

			// Token: 0x04001267 RID: 4711
			[CompilerGenerated]
			private static Action<ComboBox> action_0;

			// Token: 0x04001268 RID: 4712
			[CompilerGenerated]
			private static Func<ComboBox, IEnumerator> func_1;

			// Token: 0x020005EE RID: 1518
			[CompilerGenerated]
			private sealed class Class793
			{
				// Token: 0x06002679 RID: 9849 RVA: 0x000EA4A8 File Offset: 0x000E86A8
				public object method_0(ComboBox comboBox_0)
				{
					return comboBox_0.Items[this.int_0];
				}

				// Token: 0x04001269 RID: 4713
				public int int_0;
			}

			// Token: 0x020005EF RID: 1519
			[CompilerGenerated]
			private sealed class Class794
			{
				// Token: 0x0600267B RID: 9851 RVA: 0x00015BBC File Offset: 0x00013DBC
				public void method_0(ComboBox comboBox_0)
				{
					comboBox_0.Items[this.int_0] = this.value;
				}

				// Token: 0x0400126A RID: 4714
				public int int_0;

				// Token: 0x0400126B RID: 4715
				public object value;
			}

			// Token: 0x020005F0 RID: 1520
			[CompilerGenerated]
			private sealed class Class795
			{
				// Token: 0x0600267D RID: 9853 RVA: 0x000EA4C8 File Offset: 0x000E86C8
				public int method_0(ComboBox comboBox_0)
				{
					return comboBox_0.Items.Add(this.object_0);
				}

				// Token: 0x0400126C RID: 4716
				public object object_0;
			}

			// Token: 0x020005F1 RID: 1521
			[CompilerGenerated]
			private sealed class Class796
			{
				// Token: 0x0600267F RID: 9855 RVA: 0x00015BD5 File Offset: 0x00013DD5
				public bool method_0(ComboBox comboBox_0)
				{
					return comboBox_0.Items.Contains(this.value);
				}

				// Token: 0x0400126D RID: 4717
				public object value;
			}

			// Token: 0x020005F2 RID: 1522
			[CompilerGenerated]
			private sealed class Class797
			{
				// Token: 0x06002681 RID: 9857 RVA: 0x000EA4E8 File Offset: 0x000E86E8
				public int method_0(ComboBox comboBox_0)
				{
					return comboBox_0.Items.IndexOf(this.value);
				}

				// Token: 0x0400126E RID: 4718
				public object value;
			}

			// Token: 0x020005F3 RID: 1523
			[CompilerGenerated]
			private sealed class Class798
			{
				// Token: 0x06002683 RID: 9859 RVA: 0x00015BE8 File Offset: 0x00013DE8
				public void method_0(ComboBox comboBox_0)
				{
					comboBox_0.Items.Insert(this.int_0, this.object_0);
				}

				// Token: 0x0400126F RID: 4719
				public int int_0;

				// Token: 0x04001270 RID: 4720
				public object object_0;
			}

			// Token: 0x020005F4 RID: 1524
			[CompilerGenerated]
			private sealed class Class799
			{
				// Token: 0x06002685 RID: 9861 RVA: 0x00015C01 File Offset: 0x00013E01
				public void method_0(ComboBox comboBox_0)
				{
					comboBox_0.Items.Remove(this.value);
				}

				// Token: 0x04001271 RID: 4721
				public object value;
			}

			// Token: 0x020005F5 RID: 1525
			[CompilerGenerated]
			private sealed class Class800
			{
				// Token: 0x06002687 RID: 9863 RVA: 0x00015C14 File Offset: 0x00013E14
				public void method_0(ComboBox comboBox_0)
				{
					comboBox_0.Items.RemoveAt(this.int_0);
				}

				// Token: 0x04001272 RID: 4722
				public int int_0;
			}
		}

		// Token: 0x020005F6 RID: 1526
		[CompilerGenerated]
		private sealed class Class801
		{
			// Token: 0x06002689 RID: 9865 RVA: 0x00015C27 File Offset: 0x00013E27
			public void method_0(ComboBox comboBox_0)
			{
				comboBox_0.SelectedIndex = this.value;
			}

			// Token: 0x04001273 RID: 4723
			public int value = 0;
		}
	}
}
