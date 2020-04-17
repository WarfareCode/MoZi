using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns15;

namespace ThreadSafeControls
{
	// Token: 0x020005BC RID: 1468
	public sealed class ThreadSafeListViewItem
	{
		// Token: 0x06002593 RID: 9619 RVA: 0x000E8AB8 File Offset: 0x000E6CB8
		internal ThreadSafeListViewItem(ListViewItem listViewItem_1, Class680 class680_1)
		{
			if (listViewItem_1 == null)
			{
				throw new ArgumentNullException("listViewItem");
			}
			if (class680_1 == null)
			{
				throw new ArgumentNullException("listView");
			}
			this.listViewItem_0 = listViewItem_1;
			this.class680_0 = class680_1;
			this.class752_0 = new ThreadSafeListViewItem.Class752(this.listViewItem_0, this.class680_0);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000E8B18 File Offset: 0x000E6D18
		internal ListViewItem method_0()
		{
			return this.listViewItem_0;
		}

		// Token: 0x04001210 RID: 4624
		private readonly ListViewItem listViewItem_0;

		// Token: 0x04001211 RID: 4625
		private readonly Class680 class680_0;

		// Token: 0x04001212 RID: 4626
		private readonly ThreadSafeListViewItem.Class752 class752_0;

		// Token: 0x020005BD RID: 1469
		public sealed class ListViewSubItem
		{
			// Token: 0x06002595 RID: 9621 RVA: 0x00015626 File Offset: 0x00013826
			internal ListViewSubItem(ListViewItem.ListViewSubItem listViewSubItem_1, Class680 class680_1)
			{
				if (listViewSubItem_1 == null)
				{
					throw new ArgumentNullException("listViewSubItem");
				}
				if (class680_1 == null)
				{
					throw new ArgumentNullException("listView");
				}
				this.listViewSubItem_0 = listViewSubItem_1;
				this.class680_0 = class680_1;
			}

			// Token: 0x06002596 RID: 9622 RVA: 0x000E8B30 File Offset: 0x000E6D30
			internal ListViewItem.ListViewSubItem method_0()
			{
				return this.listViewSubItem_0;
			}

			// Token: 0x04001213 RID: 4627
			private readonly ListViewItem.ListViewSubItem listViewSubItem_0;

			// Token: 0x04001214 RID: 4628
			private readonly Class680 class680_0;
		}

		// Token: 0x020005BE RID: 1470
		public sealed class Class752 : IList<ThreadSafeListViewItem.ListViewSubItem>, ICollection<ThreadSafeListViewItem.ListViewSubItem>, IEnumerable<ThreadSafeListViewItem.ListViewSubItem>, IEnumerable, ICollection, IList
		{
			// Token: 0x170002B0 RID: 688
			public ThreadSafeListViewItem.ListViewSubItem this[int index]
			{
				get
				{
					ThreadSafeListViewItem.Class752.Class753 @class = new ThreadSafeListViewItem.Class752.Class753();
					@class.int_0 = index;
					@class.class752_0 = this;
					return Class739.smethod_4(this.class680_0.method_5<ListViewItem.ListViewSubItem>(new Func<ListView, ListViewItem.ListViewSubItem>(@class.method_0)), this.class680_0);
				}
				set
				{
					ThreadSafeListViewItem.Class752.Class754 @class = new ThreadSafeListViewItem.Class752.Class754();
					@class.int_0 = index;
					@class.value = value;
					@class.class752_0 = this;
					this.class680_0.method_4(new Action<ListView>(@class.method_0));
				}
			}

			// Token: 0x170002B1 RID: 689
			public ThreadSafeListViewItem.ListViewSubItem this[string string_0]
			{
				get
				{
					ThreadSafeListViewItem.Class752.Class755 @class = new ThreadSafeListViewItem.Class752.Class755();
					@class.string_0 = string_0;
					@class.class752_0 = this;
					return Class739.smethod_4(this.class680_0.method_5<ListViewItem.ListViewSubItem>(new Func<ListView, ListViewItem.ListViewSubItem>(@class.method_0)), this.class680_0);
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x0600259A RID: 9626 RVA: 0x000E8C18 File Offset: 0x000E6E18
			public int Count
			{
				get
				{
					return this.class680_0.method_5<int>(new Func<ListView, int>(this.method_3));
				}
			}

			// Token: 0x170002B3 RID: 691
			object IList.this[int index]
			{
				get
				{
					return this[index];
				}
				set
				{
					ThreadSafeListViewItem.Class752.Class762 @class = new ThreadSafeListViewItem.Class752.Class762();
					@class.int_0 = index;
					@class.value = value;
					@class.class752_0 = this;
					this.class680_0.method_4(new Action<ListView>(@class.method_0));
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x0600259D RID: 9629 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x0600259E RID: 9630 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x0600259F RID: 9631 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection<ThreadSafeListViewItem.ListViewSubItem>.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x060025A1 RID: 9633 RVA: 0x000E8C98 File Offset: 0x000E6E98
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this.listViewItem_0.SubItems).SyncRoot;
				}
			}

			// Token: 0x060025A2 RID: 9634 RVA: 0x00015664 File Offset: 0x00013864
			internal Class752(ListViewItem listViewItem_1, Class680 class680_1)
			{
				if (listViewItem_1 == null)
				{
					throw new ArgumentNullException("listViewItem");
				}
				if (class680_1 == null)
				{
					throw new ArgumentNullException("listView");
				}
				this.listViewItem_0 = listViewItem_1;
				this.class680_0 = class680_1;
			}

			// Token: 0x060025A3 RID: 9635 RVA: 0x000E8CB8 File Offset: 0x000E6EB8
			public ThreadSafeListViewItem.ListViewSubItem method_0(ListViewItem.ListViewSubItem listViewSubItem_0)
			{
				ThreadSafeListViewItem.Class752.Class756 @class = new ThreadSafeListViewItem.Class752.Class756();
				@class.listViewSubItem_0 = listViewSubItem_0;
				@class.class752_0 = this;
				return Class739.smethod_4(this.class680_0.method_5<ListViewItem.ListViewSubItem>(new Func<ListView, ListViewItem.ListViewSubItem>(@class.method_0)), this.class680_0);
			}

			// Token: 0x060025A4 RID: 9636 RVA: 0x000156A2 File Offset: 0x000138A2
			public void Add(ThreadSafeListViewItem.ListViewSubItem item)
			{
				this.method_0(item.method_0());
			}

			// Token: 0x060025A5 RID: 9637 RVA: 0x000E8D00 File Offset: 0x000E6F00
			public bool Contains(ListViewItem.ListViewSubItem listViewSubItem_0)
			{
				ThreadSafeListViewItem.Class752.Class757 @class = new ThreadSafeListViewItem.Class752.Class757();
				@class.listViewSubItem_0 = listViewSubItem_0;
				@class.class752_0 = this;
				return this.class680_0.method_5<bool>(new Func<ListView, bool>(@class.method_0));
			}

			// Token: 0x060025A6 RID: 9638 RVA: 0x000156B1 File Offset: 0x000138B1
			public bool Contains(ThreadSafeListViewItem.ListViewSubItem item)
			{
				return this.Contains(item.method_0());
			}

			// Token: 0x060025A7 RID: 9639 RVA: 0x000E8D38 File Offset: 0x000E6F38
			public void CopyTo(ThreadSafeListViewItem.ListViewSubItem[] array, int arrayIndex)
			{
				ThreadSafeListViewItem.ListViewSubItem[] array2 = this.method_2().ToArray<ThreadSafeListViewItem.ListViewSubItem>();
				array2.CopyTo(array2, arrayIndex);
			}

			// Token: 0x060025A8 RID: 9640 RVA: 0x000156BF File Offset: 0x000138BF
			public void Clear()
			{
				this.class680_0.method_4(new Action<ListView>(this.method_4));
			}

			// Token: 0x060025A9 RID: 9641 RVA: 0x000E8D5C File Offset: 0x000E6F5C
			public int IndexOf(ListViewItem.ListViewSubItem listViewSubItem_0)
			{
				ThreadSafeListViewItem.Class752.Class758 @class = new ThreadSafeListViewItem.Class752.Class758();
				@class.listViewSubItem_0 = listViewSubItem_0;
				@class.class752_0 = this;
				return this.class680_0.method_5<int>(new Func<ListView, int>(@class.method_0));
			}

			// Token: 0x060025AA RID: 9642 RVA: 0x000E8D98 File Offset: 0x000E6F98
			public int IndexOf(ThreadSafeListViewItem.ListViewSubItem item)
			{
				return this.IndexOf(item.method_0());
			}

			// Token: 0x060025AB RID: 9643 RVA: 0x000E8DB4 File Offset: 0x000E6FB4
			public void Insert(int int_0, ListViewItem.ListViewSubItem listViewSubItem_0)
			{
				ThreadSafeListViewItem.Class752.Class759 @class = new ThreadSafeListViewItem.Class752.Class759();
				@class.int_0 = int_0;
				@class.listViewSubItem_0 = listViewSubItem_0;
				@class.class752_0 = this;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x060025AC RID: 9644 RVA: 0x000156D8 File Offset: 0x000138D8
			public void Insert(int index, ThreadSafeListViewItem.ListViewSubItem item)
			{
				this.Insert(index, item.method_0());
			}

			// Token: 0x060025AD RID: 9645 RVA: 0x000E8DF4 File Offset: 0x000E6FF4
			public void RemoveAt(int index)
			{
				ThreadSafeListViewItem.Class752.Class760 @class = new ThreadSafeListViewItem.Class752.Class760();
				@class.int_0 = index;
				@class.class752_0 = this;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x060025AE RID: 9646 RVA: 0x000E8E2C File Offset: 0x000E702C
			public void method_1(ListViewItem.ListViewSubItem listViewSubItem_0)
			{
				ThreadSafeListViewItem.Class752.Class761 @class = new ThreadSafeListViewItem.Class752.Class761();
				@class.listViewSubItem_0 = listViewSubItem_0;
				@class.class752_0 = this;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x060025AF RID: 9647 RVA: 0x000156E7 File Offset: 0x000138E7
			public bool Remove(ThreadSafeListViewItem.ListViewSubItem item)
			{
				this.method_1(item.method_0());
				return true;
			}

			// Token: 0x060025B0 RID: 9648 RVA: 0x000E8E64 File Offset: 0x000E7064
			public IEnumerator<ThreadSafeListViewItem.ListViewSubItem> GetEnumerator()
			{
				return this.method_2().GetEnumerator();
			}

			// Token: 0x060025B1 RID: 9649 RVA: 0x000E8E80 File Offset: 0x000E7080
			private IEnumerable<ThreadSafeListViewItem.ListViewSubItem> method_2()
			{
				return this.class680_0.method_5<ListViewItem.ListViewSubItemCollection>(new Func<ListView, ListViewItem.ListViewSubItemCollection>(this.method_5)).Cast<ListViewItem.ListViewSubItem>().Select(new Func<ListViewItem.ListViewSubItem, ThreadSafeListViewItem.ListViewSubItem>(this.method_6));
			}

			// Token: 0x060025B2 RID: 9650 RVA: 0x000E8EBC File Offset: 0x000E70BC
			int IList.Add(object value)
			{
				ThreadSafeListViewItem.Class752.Class763 @class = new ThreadSafeListViewItem.Class752.Class763();
				@class.value = value;
				@class.class752_0 = this;
				return this.class680_0.method_5<int>(new Func<ListView, int>(@class.method_0));
			}

			// Token: 0x060025B3 RID: 9651 RVA: 0x000E8EF8 File Offset: 0x000E70F8
			bool IList.Contains(object value)
			{
				ThreadSafeListViewItem.Class752.Class764 @class = new ThreadSafeListViewItem.Class752.Class764();
				@class.value = value;
				@class.class752_0 = this;
				return this.class680_0.method_5<bool>(new Func<ListView, bool>(@class.method_0));
			}

			// Token: 0x060025B4 RID: 9652 RVA: 0x000E8D38 File Offset: 0x000E6F38
			void ICollection.CopyTo(Array array, int index)
			{
				ThreadSafeListViewItem.ListViewSubItem[] array2 = this.method_2().ToArray<ThreadSafeListViewItem.ListViewSubItem>();
				array2.CopyTo(array2, index);
			}

			// Token: 0x060025B5 RID: 9653 RVA: 0x000E8F30 File Offset: 0x000E7130
			int IList.IndexOf(object value)
			{
				ThreadSafeListViewItem.Class752.Class765 @class = new ThreadSafeListViewItem.Class752.Class765();
				@class.value = value;
				@class.class752_0 = this;
				return this.class680_0.method_5<int>(new Func<ListView, int>(@class.method_0));
			}

			// Token: 0x060025B6 RID: 9654 RVA: 0x000E8F6C File Offset: 0x000E716C
			void IList.Insert(int index, object value)
			{
				ThreadSafeListViewItem.Class752.Class766 @class = new ThreadSafeListViewItem.Class752.Class766();
				@class.int_0 = index;
				@class.value = value;
				@class.class752_0 = this;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x060025B7 RID: 9655 RVA: 0x000E8FAC File Offset: 0x000E71AC
			void IList.Remove(object value)
			{
				ThreadSafeListViewItem.Class752.Class767 @class = new ThreadSafeListViewItem.Class752.Class767();
				@class.value = value;
				@class.class752_0 = this;
				this.class680_0.method_4(new Action<ListView>(@class.method_0));
			}

			// Token: 0x060025B8 RID: 9656 RVA: 0x000E8FE4 File Offset: 0x000E71E4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060025B9 RID: 9657 RVA: 0x000E8FFC File Offset: 0x000E71FC
			[CompilerGenerated]
			private int method_3(ListView listView_0)
			{
				return this.listViewItem_0.SubItems.Count;
			}

			// Token: 0x060025BA RID: 9658 RVA: 0x000156F6 File Offset: 0x000138F6
			[CompilerGenerated]
			private void method_4(ListView listView_0)
			{
				this.listViewItem_0.SubItems.Clear();
			}

			// Token: 0x060025BB RID: 9659 RVA: 0x000E901C File Offset: 0x000E721C
			[CompilerGenerated]
			private ListViewItem.ListViewSubItemCollection method_5(ListView listView_0)
			{
				return this.listViewItem_0.SubItems;
			}

			// Token: 0x060025BC RID: 9660 RVA: 0x000E9038 File Offset: 0x000E7238
			[CompilerGenerated]
			private ThreadSafeListViewItem.ListViewSubItem method_6(ListViewItem.ListViewSubItem listViewSubItem_0)
			{
				return Class739.smethod_4(listViewSubItem_0, this.class680_0);
			}

			// Token: 0x04001215 RID: 4629
			private readonly ListViewItem listViewItem_0;

			// Token: 0x04001216 RID: 4630
			private readonly Class680 class680_0;

			// Token: 0x020005BF RID: 1471
			[CompilerGenerated]
			private sealed class Class753
			{
				// Token: 0x060025BD RID: 9661 RVA: 0x000E9054 File Offset: 0x000E7254
				public ListViewItem.ListViewSubItem method_0(ListView listView_0)
				{
					return this.class752_0.listViewItem_0.SubItems[this.int_0];
				}

				// Token: 0x04001217 RID: 4631
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001218 RID: 4632
				public int int_0;
			}

			// Token: 0x020005C0 RID: 1472
			[CompilerGenerated]
			private sealed class Class754
			{
				// Token: 0x060025BF RID: 9663 RVA: 0x00015708 File Offset: 0x00013908
				public void method_0(ListView listView_0)
				{
					this.class752_0.listViewItem_0.SubItems[this.int_0] = this.value.method_0();
				}

				// Token: 0x04001219 RID: 4633
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x0400121A RID: 4634
				public int int_0;

				// Token: 0x0400121B RID: 4635
				public ThreadSafeListViewItem.ListViewSubItem value;
			}

			// Token: 0x020005C1 RID: 1473
			[CompilerGenerated]
			private sealed class Class755
			{
				// Token: 0x060025C1 RID: 9665 RVA: 0x000E9080 File Offset: 0x000E7280
				public ListViewItem.ListViewSubItem method_0(ListView listView_0)
				{
					return this.class752_0.listViewItem_0.SubItems[this.string_0];
				}

				// Token: 0x0400121C RID: 4636
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x0400121D RID: 4637
				public string string_0;
			}

			// Token: 0x020005C2 RID: 1474
			[CompilerGenerated]
			private sealed class Class756
			{
				// Token: 0x060025C3 RID: 9667 RVA: 0x000E90AC File Offset: 0x000E72AC
				public ListViewItem.ListViewSubItem method_0(ListView listView_0)
				{
					return this.class752_0.listViewItem_0.SubItems.Add(this.listViewSubItem_0);
				}

				// Token: 0x0400121E RID: 4638
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x0400121F RID: 4639
				public ListViewItem.ListViewSubItem listViewSubItem_0;
			}

			// Token: 0x020005C3 RID: 1475
			[CompilerGenerated]
			private sealed class Class757
			{
				// Token: 0x060025C5 RID: 9669 RVA: 0x00015730 File Offset: 0x00013930
				public bool method_0(ListView listView_0)
				{
					return this.class752_0.listViewItem_0.SubItems.Contains(this.listViewSubItem_0);
				}

				// Token: 0x04001220 RID: 4640
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001221 RID: 4641
				public ListViewItem.ListViewSubItem listViewSubItem_0;
			}

			// Token: 0x020005C4 RID: 1476
			[CompilerGenerated]
			private sealed class Class758
			{
				// Token: 0x060025C7 RID: 9671 RVA: 0x000E90D8 File Offset: 0x000E72D8
				public int method_0(ListView listView_0)
				{
					return this.class752_0.listViewItem_0.SubItems.IndexOf(this.listViewSubItem_0);
				}

				// Token: 0x04001222 RID: 4642
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001223 RID: 4643
				public ListViewItem.ListViewSubItem listViewSubItem_0;
			}

			// Token: 0x020005C5 RID: 1477
			[CompilerGenerated]
			private sealed class Class759
			{
				// Token: 0x060025C9 RID: 9673 RVA: 0x0001574D File Offset: 0x0001394D
				public void method_0(ListView listView_0)
				{
					this.class752_0.listViewItem_0.SubItems.Insert(this.int_0, this.listViewSubItem_0);
				}

				// Token: 0x04001224 RID: 4644
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001225 RID: 4645
				public int int_0;

				// Token: 0x04001226 RID: 4646
				public ListViewItem.ListViewSubItem listViewSubItem_0;
			}

			// Token: 0x020005C6 RID: 1478
			[CompilerGenerated]
			private sealed class Class760
			{
				// Token: 0x060025CB RID: 9675 RVA: 0x00015770 File Offset: 0x00013970
				public void method_0(ListView listView_0)
				{
					this.class752_0.listViewItem_0.SubItems.RemoveAt(this.int_0);
				}

				// Token: 0x04001227 RID: 4647
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001228 RID: 4648
				public int int_0;
			}

			// Token: 0x020005C7 RID: 1479
			[CompilerGenerated]
			private sealed class Class761
			{
				// Token: 0x060025CD RID: 9677 RVA: 0x0001578D File Offset: 0x0001398D
				public void method_0(ListView listView_0)
				{
					this.class752_0.listViewItem_0.SubItems.Remove(this.listViewSubItem_0);
				}

				// Token: 0x04001229 RID: 4649
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x0400122A RID: 4650
				public ListViewItem.ListViewSubItem listViewSubItem_0;
			}

			// Token: 0x020005C8 RID: 1480
			[CompilerGenerated]
			private sealed class Class762
			{
				// Token: 0x060025CF RID: 9679 RVA: 0x000157AA File Offset: 0x000139AA
				public void method_0(ListView listView_0)
				{
					((IList)this.class752_0.listViewItem_0.SubItems)[this.int_0] = this.value;
				}

				// Token: 0x0400122B RID: 4651
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x0400122C RID: 4652
				public int int_0;

				// Token: 0x0400122D RID: 4653
				public object value;
			}

			// Token: 0x020005C9 RID: 1481
			[CompilerGenerated]
			private sealed class Class763
			{
				// Token: 0x060025D1 RID: 9681 RVA: 0x000E9104 File Offset: 0x000E7304
				public int method_0(ListView listView_0)
				{
					return ((IList)this.class752_0.listViewItem_0.SubItems).Add(this.value);
				}

				// Token: 0x0400122E RID: 4654
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x0400122F RID: 4655
				public object value;
			}

			// Token: 0x020005CA RID: 1482
			[CompilerGenerated]
			private sealed class Class764
			{
				// Token: 0x060025D3 RID: 9683 RVA: 0x000157CD File Offset: 0x000139CD
				public bool method_0(ListView listView_0)
				{
					return ((IList)this.class752_0.listViewItem_0.SubItems).Contains(this.value);
				}

				// Token: 0x04001230 RID: 4656
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001231 RID: 4657
				public object value;
			}

			// Token: 0x020005CB RID: 1483
			[CompilerGenerated]
			private sealed class Class765
			{
				// Token: 0x060025D5 RID: 9685 RVA: 0x000E9130 File Offset: 0x000E7330
				public int method_0(ListView listView_0)
				{
					return ((IList)this.class752_0.listViewItem_0.SubItems).IndexOf(this.value);
				}

				// Token: 0x04001232 RID: 4658
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001233 RID: 4659
				public object value;
			}

			// Token: 0x020005CC RID: 1484
			[CompilerGenerated]
			private sealed class Class766
			{
				// Token: 0x060025D7 RID: 9687 RVA: 0x000157EA File Offset: 0x000139EA
				public void method_0(ListView listView_0)
				{
					((IList)this.class752_0.listViewItem_0.SubItems).Insert(this.int_0, this.value);
				}

				// Token: 0x04001234 RID: 4660
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001235 RID: 4661
				public int int_0;

				// Token: 0x04001236 RID: 4662
				public object value;
			}

			// Token: 0x020005CD RID: 1485
			[CompilerGenerated]
			private sealed class Class767
			{
				// Token: 0x060025D9 RID: 9689 RVA: 0x0001580D File Offset: 0x00013A0D
				public void method_0(ListView listView_0)
				{
					((IList)this.class752_0.listViewItem_0.SubItems).Remove(this.value);
				}

				// Token: 0x04001237 RID: 4663
				public ThreadSafeListViewItem.Class752 class752_0;

				// Token: 0x04001238 RID: 4664
				public object value;
			}
		}
	}
}
