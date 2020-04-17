using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ThreadSafeControls;

namespace ns15
{
	// Token: 0x020005D1 RID: 1489
	public sealed class Class680 : Class677<ListView>
	{
		// Token: 0x060025F0 RID: 9712 RVA: 0x000158E3 File Offset: 0x00013AE3
		internal Class680(ListView tControl) : base(tControl)
		{
		}

		// Token: 0x020005D2 RID: 1490
		public sealed class Class768 : IEnumerable, ICollection, IList
		{
			// Token: 0x170002BA RID: 698
			public Class791 this[int int_0]
			{
				get
				{
					Class680.Class768.Class769 @class = new Class680.Class768.Class769();
					@class.int_0 = int_0;
					return Class739.smethod_2(this.class680_0.method_5<ColumnHeader>(new Func<ListView, ColumnHeader>(@class.method_0)), this.class680_0);
				}
			}

			// Token: 0x170002BB RID: 699
			public Class791 this[string string_0]
			{
				get
				{
					Class680.Class768.Class770 @class = new Class680.Class768.Class770();
					@class.string_0 = string_0;
					return Class739.smethod_2(this.class680_0.method_5<ColumnHeader>(new Func<ListView, ColumnHeader>(@class.method_0)), this.class680_0);
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x060025F3 RID: 9715 RVA: 0x000E9520 File Offset: 0x000E7720
			public int Count
			{
				get
				{
					Class677<ListView> @class = this.class680_0;
					if (Class680.Class768.func_0 == null)
					{
						Class680.Class768.func_0 = new Func<ListView, int>(Class680.Class768.smethod_0);
					}
					return @class.method_5<int>(Class680.Class768.func_0);
				}
			}

			// Token: 0x170002BD RID: 701
			object IList.this[int index]
			{
				get
				{
					return this[index];
				}
				set
				{
					Class680.Class768.Class772 @class = new Class680.Class768.Class772();
					@class.int_0 = index;
					@class.value = value;
					this.class680_0.method_4(new Action<ListView>(@class.method_0));
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x060025F7 RID: 9719 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x060025F9 RID: 9721 RVA: 0x000E95B0 File Offset: 0x000E77B0
			object ICollection.SyncRoot
			{
				get
				{
					object result;
					if ((result = this.object_0) == null)
					{
						result = (this.object_0 = new object());
					}
					return result;
				}
			}

			// Token: 0x060025FA RID: 9722 RVA: 0x000E95E0 File Offset: 0x000E77E0
			public void Clear()
			{
				Class677<ListView> @class = this.class680_0;
				if (Class680.Class768.action_0 == null)
				{
					Class680.Class768.action_0 = new Action<ListView>(Class680.Class768.smethod_1);
				}
				@class.method_4(Class680.Class768.action_0);
			}

			// Token: 0x060025FB RID: 9723 RVA: 0x000E9620 File Offset: 0x000E7820
			public void RemoveAt(int index)
			{
				Class680.Class768.Class771 @class = new Class680.Class768.Class771();
				@class.int_0 = index;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x060025FC RID: 9724 RVA: 0x000E9654 File Offset: 0x000E7854
			public IEnumerator GetEnumerator()
			{
				Class677<ListView> @class = this.class680_0;
				if (Class680.Class768.func_1 == null)
				{
					Class680.Class768.func_1 = new Func<ListView, IEnumerator>(Class680.Class768.smethod_2);
				}
				return @class.method_5<IEnumerator>(Class680.Class768.func_1);
			}

			// Token: 0x060025FD RID: 9725 RVA: 0x000E9694 File Offset: 0x000E7894
			int IList.Add(object value)
			{
				Class680.Class768.Class773 @class = new Class680.Class768.Class773();
				@class.value = value;
				return this.class680_0.method_5<int>(new Func<ListView, int>(@class.method_0));
			}

			// Token: 0x060025FE RID: 9726 RVA: 0x000E96C8 File Offset: 0x000E78C8
			bool IList.Contains(object value)
			{
				Class680.Class768.Class774 @class = new Class680.Class768.Class774();
				@class.value = value;
				return this.class680_0.method_5<bool>(new Func<ListView, bool>(@class.method_0));
			}

			// Token: 0x060025FF RID: 9727 RVA: 0x000E96FC File Offset: 0x000E78FC
			void ICollection.CopyTo(Array array, int index)
			{
				Class680.Class768.Class775 @class = new Class680.Class768.Class775();
				@class.array_0 = array;
				@class.int_0 = index;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x06002600 RID: 9728 RVA: 0x000E9734 File Offset: 0x000E7934
			int IList.IndexOf(object value)
			{
				Class680.Class768.Class776 @class = new Class680.Class768.Class776();
				@class.value = value;
				return this.class680_0.method_5<int>(new Func<ListView, int>(@class.method_0));
			}

			// Token: 0x06002601 RID: 9729 RVA: 0x000E9768 File Offset: 0x000E7968
			void IList.Insert(int index, object value)
			{
				Class680.Class768.Class777 @class = new Class680.Class768.Class777();
				@class.int_0 = index;
				@class.value = value;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x06002602 RID: 9730 RVA: 0x000E97A0 File Offset: 0x000E79A0
			void IList.Remove(object value)
			{
				Class680.Class768.Class778 @class = new Class680.Class768.Class778();
				@class.value = value;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x06002603 RID: 9731 RVA: 0x000E97D4 File Offset: 0x000E79D4
			[CompilerGenerated]
			private static int smethod_0(ListView listView_0)
			{
				return listView_0.Columns.Count;
			}

			// Token: 0x06002604 RID: 9732 RVA: 0x000158EC File Offset: 0x00013AEC
			[CompilerGenerated]
			private static void smethod_1(ListView listView_0)
			{
				listView_0.Columns.Clear();
			}

			// Token: 0x06002605 RID: 9733 RVA: 0x000E97F0 File Offset: 0x000E79F0
			[CompilerGenerated]
			private static IEnumerator smethod_2(ListView listView_0)
			{
				return listView_0.Columns.GetEnumerator();
			}

			// Token: 0x0400123A RID: 4666
			private readonly Class680 class680_0;

			// Token: 0x0400123B RID: 4667
			private object object_0;

			// Token: 0x0400123C RID: 4668
			[CompilerGenerated]
			private static Func<ListView, int> func_0;

			// Token: 0x0400123D RID: 4669
			[CompilerGenerated]
			private static Action<ListView> action_0;

			// Token: 0x0400123E RID: 4670
			[CompilerGenerated]
			private static Func<ListView, IEnumerator> func_1;

			// Token: 0x020005D3 RID: 1491
			[CompilerGenerated]
			private sealed class Class769
			{
				// Token: 0x06002607 RID: 9735 RVA: 0x000E980C File Offset: 0x000E7A0C
				public ColumnHeader method_0(ListView listView_0)
				{
					return listView_0.Columns[this.int_0];
				}

				// Token: 0x0400123F RID: 4671
				public int int_0;
			}

			// Token: 0x020005D4 RID: 1492
			[CompilerGenerated]
			private sealed class Class770
			{
				// Token: 0x06002609 RID: 9737 RVA: 0x000E982C File Offset: 0x000E7A2C
				public ColumnHeader method_0(ListView listView_0)
				{
					return listView_0.Columns[this.string_0];
				}

				// Token: 0x04001240 RID: 4672
				public string string_0;
			}

			// Token: 0x020005D5 RID: 1493
			[CompilerGenerated]
			private sealed class Class771
			{
				// Token: 0x0600260B RID: 9739 RVA: 0x000158F9 File Offset: 0x00013AF9
				public void method_0(ListView listView_0)
				{
					listView_0.Columns.RemoveAt(this.int_0);
				}

				// Token: 0x04001241 RID: 4673
				public int int_0;
			}

			// Token: 0x020005D6 RID: 1494
			[CompilerGenerated]
			private sealed class Class772
			{
				// Token: 0x0600260D RID: 9741 RVA: 0x0001590C File Offset: 0x00013B0C
				public void method_0(ListView listView_0)
				{
					((IList)listView_0.Columns)[this.int_0] = this.value;
				}

				// Token: 0x04001242 RID: 4674
				public int int_0;

				// Token: 0x04001243 RID: 4675
				public object value;
			}

			// Token: 0x020005D7 RID: 1495
			[CompilerGenerated]
			private sealed class Class773
			{
				// Token: 0x0600260F RID: 9743 RVA: 0x000E984C File Offset: 0x000E7A4C
				public int method_0(ListView listView_0)
				{
					return ((IList)listView_0.Columns).Add(this.value);
				}

				// Token: 0x04001244 RID: 4676
				public object value;
			}

			// Token: 0x020005D8 RID: 1496
			[CompilerGenerated]
			private sealed class Class774
			{
				// Token: 0x06002611 RID: 9745 RVA: 0x00015925 File Offset: 0x00013B25
				public bool method_0(ListView listView_0)
				{
					return ((IList)listView_0.Columns).Contains(this.value);
				}

				// Token: 0x04001245 RID: 4677
				public object value;
			}

			// Token: 0x020005D9 RID: 1497
			[CompilerGenerated]
			private sealed class Class775
			{
				// Token: 0x06002613 RID: 9747 RVA: 0x00015938 File Offset: 0x00013B38
				public void method_0(ListView listView_0)
				{
					((ICollection)listView_0.Columns).CopyTo(this.array_0, this.int_0);
				}

				// Token: 0x04001246 RID: 4678
				public Array array_0;

				// Token: 0x04001247 RID: 4679
				public int int_0;
			}

			// Token: 0x020005DA RID: 1498
			[CompilerGenerated]
			private sealed class Class776
			{
				// Token: 0x06002615 RID: 9749 RVA: 0x000E986C File Offset: 0x000E7A6C
				public int method_0(ListView listView_0)
				{
					return ((IList)listView_0.Columns).IndexOf(this.value);
				}

				// Token: 0x04001248 RID: 4680
				public object value;
			}

			// Token: 0x020005DB RID: 1499
			[CompilerGenerated]
			private sealed class Class777
			{
				// Token: 0x06002617 RID: 9751 RVA: 0x00015951 File Offset: 0x00013B51
				public void method_0(ListView listView_0)
				{
					((IList)listView_0.Columns).Insert(this.int_0, this.value);
				}

				// Token: 0x04001249 RID: 4681
				public int int_0;

				// Token: 0x0400124A RID: 4682
				public object value;
			}

			// Token: 0x020005DC RID: 1500
			[CompilerGenerated]
			private sealed class Class778
			{
				// Token: 0x06002619 RID: 9753 RVA: 0x0001596A File Offset: 0x00013B6A
				public void method_0(ListView listView_0)
				{
					((IList)listView_0.Columns).Remove(this.value);
				}

				// Token: 0x0400124B RID: 4683
				public object value;
			}
		}

		// Token: 0x020005DD RID: 1501
		public sealed class Class779 : IEnumerable, ICollection, IList
		{
			// Token: 0x170002C2 RID: 706
			public ThreadSafeListViewItem this[int int_0]
			{
				get
				{
					Class680.Class779.Class780 @class = new Class680.Class779.Class780();
					@class.int_0 = int_0;
					return Class739.smethod_3(this.class680_0.method_5<ListViewItem>(new Func<ListView, ListViewItem>(@class.method_0)), this.class680_0);
				}
				set
				{
					Class680.Class779.Class781 @class = new Class680.Class779.Class781();
					@class.int_0 = int_0;
					@class.value = value;
					this.class680_0.method_4(new Action<ListView>(@class.method_0));
				}
			}

			// Token: 0x170002C3 RID: 707
			public ThreadSafeListViewItem this[string string_0]
			{
				get
				{
					Class680.Class779.Class782 @class = new Class680.Class779.Class782();
					@class.string_0 = string_0;
					return Class739.smethod_3(this.class680_0.method_5<ListViewItem>(new Func<ListView, ListViewItem>(@class.method_0)), this.class680_0);
				}
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x0600261E RID: 9758 RVA: 0x000E9944 File Offset: 0x000E7B44
			public int Count
			{
				get
				{
					Class677<ListView> @class = this.class680_0;
					if (Class680.Class779.func_0 == null)
					{
						Class680.Class779.func_0 = new Func<ListView, int>(Class680.Class779.smethod_0);
					}
					return @class.method_5<int>(Class680.Class779.func_0);
				}
			}

			// Token: 0x170002C5 RID: 709
			object IList.this[int index]
			{
				get
				{
					return this[index];
				}
				set
				{
					Class680.Class779.Class785 @class = new Class680.Class779.Class785();
					@class.int_0 = index;
					@class.value = value;
					this.class680_0.method_4(new Action<ListView>(@class.method_0));
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x06002621 RID: 9761 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06002622 RID: 9762 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06002623 RID: 9763 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06002624 RID: 9764 RVA: 0x000E99D4 File Offset: 0x000E7BD4
			object ICollection.SyncRoot
			{
				get
				{
					object result;
					if ((result = this.object_0) == null)
					{
						result = (this.object_0 = new object());
					}
					return result;
				}
			}

			// Token: 0x06002625 RID: 9765 RVA: 0x000E9A04 File Offset: 0x000E7C04
			public void Clear()
			{
				Class677<ListView> @class = this.class680_0;
				if (Class680.Class779.action_0 == null)
				{
					Class680.Class779.action_0 = new Action<ListView>(Class680.Class779.smethod_1);
				}
				@class.method_4(Class680.Class779.action_0);
			}

			// Token: 0x06002626 RID: 9766 RVA: 0x000E9A44 File Offset: 0x000E7C44
			public void CopyTo(Array array, int index)
			{
				Class680.Class779.Class783 @class = new Class680.Class779.Class783();
				@class.array_0 = array;
				@class.int_0 = index;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x06002627 RID: 9767 RVA: 0x000E9A7C File Offset: 0x000E7C7C
			public void RemoveAt(int index)
			{
				Class680.Class779.Class784 @class = new Class680.Class779.Class784();
				@class.int_0 = index;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x06002628 RID: 9768 RVA: 0x000E9AB0 File Offset: 0x000E7CB0
			public IEnumerator GetEnumerator()
			{
				Class677<ListView> @class = this.class680_0;
				if (Class680.Class779.func_1 == null)
				{
					Class680.Class779.func_1 = new Func<ListView, IEnumerator>(Class680.Class779.smethod_2);
				}
				return @class.method_5<IEnumerator>(Class680.Class779.func_1);
			}

			// Token: 0x06002629 RID: 9769 RVA: 0x000E9AF0 File Offset: 0x000E7CF0
			int IList.Add(object value)
			{
				Class680.Class779.Class786 @class = new Class680.Class779.Class786();
				@class.value = value;
				return this.class680_0.method_5<int>(new Func<ListView, int>(@class.method_0));
			}

			// Token: 0x0600262A RID: 9770 RVA: 0x000E9B24 File Offset: 0x000E7D24
			bool IList.Contains(object value)
			{
				Class680.Class779.Class787 @class = new Class680.Class779.Class787();
				@class.value = value;
				return this.class680_0.method_5<bool>(new Func<ListView, bool>(@class.method_0));
			}

			// Token: 0x0600262B RID: 9771 RVA: 0x000E9B58 File Offset: 0x000E7D58
			int IList.IndexOf(object value)
			{
				Class680.Class779.Class788 @class = new Class680.Class779.Class788();
				@class.value = value;
				return this.class680_0.method_5<int>(new Func<ListView, int>(@class.method_0));
			}

			// Token: 0x0600262C RID: 9772 RVA: 0x000E9B8C File Offset: 0x000E7D8C
			void IList.Insert(int index, object value)
			{
				Class680.Class779.Class789 @class = new Class680.Class779.Class789();
				@class.int_0 = index;
				@class.value = value;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x0600262D RID: 9773 RVA: 0x000E9BC4 File Offset: 0x000E7DC4
			void IList.Remove(object value)
			{
				Class680.Class779.Class790 @class = new Class680.Class779.Class790();
				@class.value = value;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x0600262E RID: 9774 RVA: 0x000E9BF8 File Offset: 0x000E7DF8
			[CompilerGenerated]
			private static int smethod_0(ListView listView_0)
			{
				return listView_0.Items.Count;
			}

			// Token: 0x0600262F RID: 9775 RVA: 0x0001597D File Offset: 0x00013B7D
			[CompilerGenerated]
			private static void smethod_1(ListView listView_0)
			{
				listView_0.Items.Clear();
			}

			// Token: 0x06002630 RID: 9776 RVA: 0x000E9C14 File Offset: 0x000E7E14
			[CompilerGenerated]
			private static IEnumerator smethod_2(ListView listView_0)
			{
				return listView_0.Items.GetEnumerator();
			}

			// Token: 0x0400124C RID: 4684
			private readonly Class680 class680_0;

			// Token: 0x0400124D RID: 4685
			private object object_0;

			// Token: 0x0400124E RID: 4686
			[CompilerGenerated]
			private static Func<ListView, int> func_0;

			// Token: 0x0400124F RID: 4687
			[CompilerGenerated]
			private static Action<ListView> action_0;

			// Token: 0x04001250 RID: 4688
			[CompilerGenerated]
			private static Func<ListView, IEnumerator> func_1;

			// Token: 0x020005DE RID: 1502
			[CompilerGenerated]
			private sealed class Class780
			{
				// Token: 0x06002632 RID: 9778 RVA: 0x000E9C30 File Offset: 0x000E7E30
				public ListViewItem method_0(ListView listView_0)
				{
					return listView_0.Items[this.int_0];
				}

				// Token: 0x04001251 RID: 4689
				public int int_0;
			}

			// Token: 0x020005DF RID: 1503
			[CompilerGenerated]
			private sealed class Class781
			{
				// Token: 0x06002634 RID: 9780 RVA: 0x0001598A File Offset: 0x00013B8A
				public void method_0(ListView listView_0)
				{
					listView_0.Items[this.int_0] = this.value.method_0();
				}

				// Token: 0x04001252 RID: 4690
				public int int_0;

				// Token: 0x04001253 RID: 4691
				public ThreadSafeListViewItem value;
			}

			// Token: 0x020005E0 RID: 1504
			[CompilerGenerated]
			private sealed class Class782
			{
				// Token: 0x06002636 RID: 9782 RVA: 0x000E9C50 File Offset: 0x000E7E50
				public ListViewItem method_0(ListView listView_0)
				{
					return listView_0.Items[this.string_0];
				}

				// Token: 0x04001254 RID: 4692
				public string string_0;
			}

			// Token: 0x020005E1 RID: 1505
			[CompilerGenerated]
			private sealed class Class783
			{
				// Token: 0x06002638 RID: 9784 RVA: 0x000159A8 File Offset: 0x00013BA8
				public void method_0(ListView listView_0)
				{
					listView_0.Items.CopyTo(this.array_0, this.int_0);
				}

				// Token: 0x04001255 RID: 4693
				public Array array_0;

				// Token: 0x04001256 RID: 4694
				public int int_0;
			}

			// Token: 0x020005E2 RID: 1506
			[CompilerGenerated]
			private sealed class Class784
			{
				// Token: 0x0600263A RID: 9786 RVA: 0x000159C1 File Offset: 0x00013BC1
				public void method_0(ListView listView_0)
				{
					listView_0.Items.RemoveAt(this.int_0);
				}

				// Token: 0x04001257 RID: 4695
				public int int_0;
			}

			// Token: 0x020005E3 RID: 1507
			[CompilerGenerated]
			private sealed class Class785
			{
				// Token: 0x0600263C RID: 9788 RVA: 0x000159D4 File Offset: 0x00013BD4
				public void method_0(ListView listView_0)
				{
					((IList)listView_0.Items)[this.int_0] = this.value;
				}

				// Token: 0x04001258 RID: 4696
				public int int_0;

				// Token: 0x04001259 RID: 4697
				public object value;
			}

			// Token: 0x020005E4 RID: 1508
			[CompilerGenerated]
			private sealed class Class786
			{
				// Token: 0x0600263E RID: 9790 RVA: 0x000E9C70 File Offset: 0x000E7E70
				public int method_0(ListView listView_0)
				{
					return ((IList)listView_0.Items).Add(this.value);
				}

				// Token: 0x0400125A RID: 4698
				public object value;
			}

			// Token: 0x020005E5 RID: 1509
			[CompilerGenerated]
			private sealed class Class787
			{
				// Token: 0x06002640 RID: 9792 RVA: 0x000159ED File Offset: 0x00013BED
				public bool method_0(ListView listView_0)
				{
					return ((IList)listView_0.Items).Contains(this.value);
				}

				// Token: 0x0400125B RID: 4699
				public object value;
			}

			// Token: 0x020005E6 RID: 1510
			[CompilerGenerated]
			private sealed class Class788
			{
				// Token: 0x06002642 RID: 9794 RVA: 0x000E9C90 File Offset: 0x000E7E90
				public int method_0(ListView listView_0)
				{
					return ((IList)listView_0.Items).IndexOf(this.value);
				}

				// Token: 0x0400125C RID: 4700
				public object value;
			}

			// Token: 0x020005E7 RID: 1511
			[CompilerGenerated]
			private sealed class Class789
			{
				// Token: 0x06002644 RID: 9796 RVA: 0x00015A00 File Offset: 0x00013C00
				public void method_0(ListView listView_0)
				{
					((IList)listView_0.Items).Insert(this.int_0, this.value);
				}

				// Token: 0x0400125D RID: 4701
				public int int_0;

				// Token: 0x0400125E RID: 4702
				public object value;
			}

			// Token: 0x020005E8 RID: 1512
			[CompilerGenerated]
			private sealed class Class790
			{
				// Token: 0x06002646 RID: 9798 RVA: 0x00015A19 File Offset: 0x00013C19
				public void method_0(ListView listView_0)
				{
					((IList)listView_0.Items).Remove(this.value);
				}

				// Token: 0x0400125F RID: 4703
				public object value;
			}
		}
	}
}
