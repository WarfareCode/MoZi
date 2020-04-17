using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x0200059F RID: 1439
	public sealed class Class679 : Class678<CheckedListBox>
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x00015210 File Offset: 0x00013410
		internal Class679(CheckedListBox gparam_1) : base(gparam_1)
		{
		}

		// Token: 0x020005A0 RID: 1440
		public sealed class Class740 : IEnumerable, ICollection, IList
		{
			// Token: 0x170002A7 RID: 679
			public object this[int int_0]
			{
				get
				{
					Class679.Class740.Class741 @class = new Class679.Class740.Class741();
					@class.int_0 = int_0;
					return this.class679_0.method_5<object>(new Func<CheckedListBox, object>(@class.method_0));
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000E337C File Offset: 0x000E157C
			public int Count
			{
				get
				{
					Class677<CheckedListBox> @class = this.class679_0;
					if (Class679.Class740.func_0 == null)
					{
						Class679.Class740.func_0 = new Func<CheckedListBox, int>(Class679.Class740.smethod_0);
					}
					return @class.method_5<int>(Class679.Class740.func_0);
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x060024E3 RID: 9443 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x060024E5 RID: 9445 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000E33BC File Offset: 0x000E15BC
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this.class679_0.method_3().CheckedItems).SyncRoot;
				}
			}

			// Token: 0x170002AD RID: 685
			object IList.this[int index]
			{
				get
				{
					Class679.Class740.Class749 @class = new Class679.Class740.Class749();
					@class.int_0 = index;
					return this.class679_0.method_5<object>(new Func<CheckedListBox, object>(@class.method_0));
				}
				set
				{
					Class679.Class740.Class750 @class = new Class679.Class740.Class750();
					@class.int_0 = index;
					@class.value = value;
					this.class679_0.method_4(new Action<CheckedListBox>(@class.method_0));
				}
			}

			// Token: 0x060024E9 RID: 9449 RVA: 0x000E344C File Offset: 0x000E164C
			public bool Contains(object value)
			{
				Class679.Class740.Class742 @class = new Class679.Class740.Class742();
				@class.object_0 = value;
				return this.class679_0.method_5<bool>(new Func<CheckedListBox, bool>(@class.method_0));
			}

			// Token: 0x060024EA RID: 9450 RVA: 0x000E3480 File Offset: 0x000E1680
			public void CopyTo(Array array, int index)
			{
				Class679.Class740.Class743 @class = new Class679.Class740.Class743();
				@class.array_0 = array;
				@class.int_0 = index;
				this.class679_0.method_4(new Action<CheckedListBox>(@class.method_0));
			}

			// Token: 0x060024EB RID: 9451 RVA: 0x000E34B8 File Offset: 0x000E16B8
			public int IndexOf(object value)
			{
				Class679.Class740.Class744 @class = new Class679.Class740.Class744();
				@class.object_0 = value;
				return this.class679_0.method_5<int>(new Func<CheckedListBox, int>(@class.method_0));
			}

			// Token: 0x060024EC RID: 9452 RVA: 0x000E34EC File Offset: 0x000E16EC
			public IEnumerator GetEnumerator()
			{
				Class677<CheckedListBox> @class = this.class679_0;
				if (Class679.Class740.func_1 == null)
				{
					Class679.Class740.func_1 = new Func<CheckedListBox, IEnumerator>(Class679.Class740.smethod_1);
				}
				return @class.method_5<IEnumerator>(Class679.Class740.func_1);
			}

			// Token: 0x060024ED RID: 9453 RVA: 0x000E352C File Offset: 0x000E172C
			int IList.Add(object value)
			{
				Class679.Class740.Class745 @class = new Class679.Class740.Class745();
				@class.value = value;
				return this.class679_0.method_5<int>(new Func<CheckedListBox, int>(@class.method_0));
			}

			// Token: 0x060024EE RID: 9454 RVA: 0x000E3560 File Offset: 0x000E1760
			void IList.Insert(int index, object value)
			{
				Class679.Class740.Class746 @class = new Class679.Class740.Class746();
				@class.int_0 = index;
				@class.value = value;
				this.class679_0.method_4(new Action<CheckedListBox>(@class.method_0));
			}

			// Token: 0x060024EF RID: 9455 RVA: 0x000E3598 File Offset: 0x000E1798
			void IList.Remove(object value)
			{
				Class679.Class740.Class747 @class = new Class679.Class740.Class747();
				@class.value = value;
				this.class679_0.method_4(new Action<CheckedListBox>(@class.method_0));
			}

			// Token: 0x060024F0 RID: 9456 RVA: 0x000E35CC File Offset: 0x000E17CC
			void IList.RemoveAt(int index)
			{
				Class679.Class740.Class748 @class = new Class679.Class740.Class748();
				@class.int_0 = index;
				this.class679_0.method_4(new Action<CheckedListBox>(@class.method_0));
			}

			// Token: 0x060024F1 RID: 9457 RVA: 0x000E3600 File Offset: 0x000E1800
			void IList.Clear()
			{
				Class677<CheckedListBox> @class = this.class679_0;
				if (Class679.Class740.action_0 == null)
				{
					Class679.Class740.action_0 = new Action<CheckedListBox>(Class679.Class740.smethod_2);
				}
				@class.method_4(Class679.Class740.action_0);
			}

			// Token: 0x060024F2 RID: 9458 RVA: 0x000E3640 File Offset: 0x000E1840
			[CompilerGenerated]
			private static int smethod_0(CheckedListBox checkedListBox_0)
			{
				return checkedListBox_0.CheckedItems.Count;
			}

			// Token: 0x060024F3 RID: 9459 RVA: 0x000E365C File Offset: 0x000E185C
			[CompilerGenerated]
			private static IEnumerator smethod_1(CheckedListBox checkedListBox_0)
			{
				return checkedListBox_0.CheckedItems.GetEnumerator();
			}

			// Token: 0x060024F4 RID: 9460 RVA: 0x00015219 File Offset: 0x00013419
			[CompilerGenerated]
			private static void smethod_2(CheckedListBox checkedListBox_0)
			{
				((IList)checkedListBox_0.CheckedItems).Clear();
			}

			// Token: 0x040011C2 RID: 4546
			private readonly Class679 class679_0;

			// Token: 0x040011C3 RID: 4547
			[CompilerGenerated]
			private static Func<CheckedListBox, int> func_0;

			// Token: 0x040011C4 RID: 4548
			[CompilerGenerated]
			private static Func<CheckedListBox, IEnumerator> func_1;

			// Token: 0x040011C5 RID: 4549
			[CompilerGenerated]
			private static Action<CheckedListBox> action_0;

			// Token: 0x020005A1 RID: 1441
			[CompilerGenerated]
			private sealed class Class741
			{
				// Token: 0x060024F6 RID: 9462 RVA: 0x000E3678 File Offset: 0x000E1878
				public object method_0(CheckedListBox checkedListBox_0)
				{
					return checkedListBox_0.CheckedItems[this.int_0];
				}

				// Token: 0x040011C6 RID: 4550
				public int int_0;
			}

			// Token: 0x020005A2 RID: 1442
			[CompilerGenerated]
			private sealed class Class742
			{
				// Token: 0x060024F8 RID: 9464 RVA: 0x00015226 File Offset: 0x00013426
				public bool method_0(CheckedListBox checkedListBox_0)
				{
					return checkedListBox_0.CheckedItems.Contains(this.object_0);
				}

				// Token: 0x040011C7 RID: 4551
				public object object_0;
			}

			// Token: 0x020005A3 RID: 1443
			[CompilerGenerated]
			private sealed class Class743
			{
				// Token: 0x060024FA RID: 9466 RVA: 0x00015239 File Offset: 0x00013439
				public void method_0(CheckedListBox checkedListBox_0)
				{
					checkedListBox_0.CheckedItems.CopyTo(this.array_0, this.int_0);
				}

				// Token: 0x040011C8 RID: 4552
				public Array array_0;

				// Token: 0x040011C9 RID: 4553
				public int int_0;
			}

			// Token: 0x020005A4 RID: 1444
			[CompilerGenerated]
			private sealed class Class744
			{
				// Token: 0x060024FC RID: 9468 RVA: 0x000E3698 File Offset: 0x000E1898
				public int method_0(CheckedListBox checkedListBox_0)
				{
					return checkedListBox_0.CheckedItems.IndexOf(this.object_0);
				}

				// Token: 0x040011CA RID: 4554
				public object object_0;
			}

			// Token: 0x020005A5 RID: 1445
			[CompilerGenerated]
			private sealed class Class745
			{
				// Token: 0x060024FE RID: 9470 RVA: 0x000E36B8 File Offset: 0x000E18B8
				public int method_0(CheckedListBox checkedListBox_0)
				{
					return ((IList)checkedListBox_0.CheckedItems).Add(this.value);
				}

				// Token: 0x040011CB RID: 4555
				public object value;
			}

			// Token: 0x020005A6 RID: 1446
			[CompilerGenerated]
			private sealed class Class746
			{
				// Token: 0x06002500 RID: 9472 RVA: 0x00015252 File Offset: 0x00013452
				public void method_0(CheckedListBox checkedListBox_0)
				{
					((IList)checkedListBox_0.CheckedItems).Insert(this.int_0, this.value);
				}

				// Token: 0x040011CC RID: 4556
				public int int_0;

				// Token: 0x040011CD RID: 4557
				public object value;
			}

			// Token: 0x020005A7 RID: 1447
			[CompilerGenerated]
			private sealed class Class747
			{
				// Token: 0x06002502 RID: 9474 RVA: 0x0001526B File Offset: 0x0001346B
				public void method_0(CheckedListBox checkedListBox_0)
				{
					((IList)checkedListBox_0.CheckedItems).Remove(this.value);
				}

				// Token: 0x040011CE RID: 4558
				public object value;
			}

			// Token: 0x020005A8 RID: 1448
			[CompilerGenerated]
			private sealed class Class748
			{
				// Token: 0x06002504 RID: 9476 RVA: 0x0001527E File Offset: 0x0001347E
				public void method_0(CheckedListBox checkedListBox_0)
				{
					((IList)checkedListBox_0.CheckedItems).RemoveAt(this.int_0);
				}

				// Token: 0x040011CF RID: 4559
				public int int_0;
			}

			// Token: 0x020005A9 RID: 1449
			[CompilerGenerated]
			private sealed class Class749
			{
				// Token: 0x06002506 RID: 9478 RVA: 0x000E36D8 File Offset: 0x000E18D8
				public object method_0(CheckedListBox checkedListBox_0)
				{
					return ((IList)checkedListBox_0.CheckedItems)[this.int_0];
				}

				// Token: 0x040011D0 RID: 4560
				public int int_0;
			}

			// Token: 0x020005AA RID: 1450
			[CompilerGenerated]
			private sealed class Class750
			{
				// Token: 0x06002508 RID: 9480 RVA: 0x00015291 File Offset: 0x00013491
				public void method_0(CheckedListBox checkedListBox_0)
				{
					((IList)checkedListBox_0.CheckedItems)[this.int_0] = this.value;
				}

				// Token: 0x040011D1 RID: 4561
				public int int_0;

				// Token: 0x040011D2 RID: 4562
				public object value;
			}
		}
	}
}
