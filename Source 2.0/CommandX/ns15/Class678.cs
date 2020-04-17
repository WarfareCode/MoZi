using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x0200056D RID: 1389
	public abstract class Class678<TListBox> : Class677<TListBox> where TListBox : ListBox
	{
		// Token: 0x060023FF RID: 9215 RVA: 0x00014CA6 File Offset: 0x00012EA6
		internal Class678(TListBox gparam_1) : base(gparam_1)
		{
			this.class709_0 = new Class678<TListBox>.Class709(this);
			this.class698_0 = new Class678<TListBox>.Class698(this);
		}

		// Token: 0x0400115F RID: 4447
		protected readonly Class678<TListBox>.Class709 class709_0;

		// Token: 0x04001160 RID: 4448
		protected readonly Class678<TListBox>.Class698 class698_0;

		// Token: 0x0200056E RID: 1390
		public sealed class Class698 : IEnumerable, ICollection, IList
		{
			// Token: 0x1700028C RID: 652
			public int this[int int_0]
			{
				get
				{
					Class678<TListBox>.Class698.Class699 @class = new Class678<TListBox>.Class698.Class699();
					@class.int_0 = int_0;
					return this.class678_0.method_5<int>(new Func<TListBox, int>(@class.method_0));
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06002401 RID: 9217 RVA: 0x000E17D4 File Offset: 0x000DF9D4
			public int Count
			{
				get
				{
					Class677<TListBox> @class = this.class678_0;
					if (Class678<TListBox>.Class698.func_0 == null)
					{
						Class678<TListBox>.Class698.func_0 = new Func<TListBox, int>(Class678<TListBox>.Class698.smethod_0);
					}
					return @class.method_5<int>(Class678<TListBox>.Class698.func_0);
				}
			}

			// Token: 0x1700028E RID: 654
			object IList.this[int index]
			{
				get
				{
					Class678<TListBox>.Class698.Class701 @class = new Class678<TListBox>.Class698.Class701();
					@class.int_0 = index;
					return this.class678_0.method_5<object>(new Func<TListBox, object>(@class.method_0));
				}
				set
				{
					Class678<TListBox>.Class698.Class702 @class = new Class678<TListBox>.Class698.Class702();
					@class.int_0 = index;
					@class.value = value;
					this.class678_0.method_4(new Action<TListBox>(@class.method_0));
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06002404 RID: 9220 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06002405 RID: 9221 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06002406 RID: 9222 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06002407 RID: 9223 RVA: 0x000E1880 File Offset: 0x000DFA80
			object ICollection.SyncRoot
			{
				get
				{
					TListBox tListBox = this.class678_0.method_3();
					return ((ICollection)tListBox.SelectedIndices).SyncRoot;
				}
			}

			// Token: 0x06002408 RID: 9224 RVA: 0x00014CC7 File Offset: 0x00012EC7
			internal Class698(Class678<TListBox> class678_1)
			{
				if (class678_1 == null)
				{
					throw new ArgumentNullException("listBox");
				}
				this.class678_0 = class678_1;
			}

			// Token: 0x06002409 RID: 9225 RVA: 0x000E18B0 File Offset: 0x000DFAB0
			public void Clear()
			{
				Class677<TListBox> @class = this.class678_0;
				if (Class678<TListBox>.Class698.action_0 == null)
				{
					Class678<TListBox>.Class698.action_0 = new Action<TListBox>(Class678<TListBox>.Class698.smethod_1);
				}
				@class.method_4(Class678<TListBox>.Class698.action_0);
			}

			// Token: 0x0600240A RID: 9226 RVA: 0x000E18F0 File Offset: 0x000DFAF0
			public void CopyTo(Array array, int index)
			{
				Class678<TListBox>.Class698.Class700 @class = new Class678<TListBox>.Class698.Class700();
				@class.array_0 = array;
				@class.int_0 = index;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x0600240B RID: 9227 RVA: 0x000E1928 File Offset: 0x000DFB28
			public IEnumerator GetEnumerator()
			{
				Class677<TListBox> @class = this.class678_0;
				if (Class678<TListBox>.Class698.func_1 == null)
				{
					Class678<TListBox>.Class698.func_1 = new Func<TListBox, IEnumerator>(Class678<TListBox>.Class698.smethod_2);
				}
				return @class.method_5<IEnumerator>(Class678<TListBox>.Class698.func_1);
			}

			// Token: 0x0600240C RID: 9228 RVA: 0x000E1968 File Offset: 0x000DFB68
			int IList.Add(object value)
			{
				Class678<TListBox>.Class698.Class703 @class = new Class678<TListBox>.Class698.Class703();
				@class.value = value;
				return this.class678_0.method_5<int>(new Func<TListBox, int>(@class.method_0));
			}

			// Token: 0x0600240D RID: 9229 RVA: 0x000E199C File Offset: 0x000DFB9C
			bool IList.Contains(object value)
			{
				Class678<TListBox>.Class698.Class704 @class = new Class678<TListBox>.Class698.Class704();
				@class.value = value;
				return this.class678_0.method_5<bool>(new Func<TListBox, bool>(@class.method_0));
			}

			// Token: 0x0600240E RID: 9230 RVA: 0x000E19D0 File Offset: 0x000DFBD0
			int IList.IndexOf(object value)
			{
				Class678<TListBox>.Class698.Class705 @class = new Class678<TListBox>.Class698.Class705();
				@class.value = value;
				return this.class678_0.method_5<int>(new Func<TListBox, int>(@class.method_0));
			}

			// Token: 0x0600240F RID: 9231 RVA: 0x000E1A04 File Offset: 0x000DFC04
			void IList.Insert(int index, object value)
			{
				Class678<TListBox>.Class698.Class706 @class = new Class678<TListBox>.Class698.Class706();
				@class.int_0 = index;
				@class.value = value;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x06002410 RID: 9232 RVA: 0x000E1A3C File Offset: 0x000DFC3C
			void IList.Remove(object value)
			{
				Class678<TListBox>.Class698.Class707 @class = new Class678<TListBox>.Class698.Class707();
				@class.value = value;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x06002411 RID: 9233 RVA: 0x000E1A70 File Offset: 0x000DFC70
			void IList.RemoveAt(int index)
			{
				Class678<TListBox>.Class698.Class708 @class = new Class678<TListBox>.Class698.Class708();
				@class.int_0 = index;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x06002412 RID: 9234 RVA: 0x000E1AA4 File Offset: 0x000DFCA4
			[CompilerGenerated]
			private static int smethod_0(TListBox gparam_0)
			{
				return gparam_0.SelectedIndices.Count;
			}

			// Token: 0x06002413 RID: 9235 RVA: 0x00014CEA File Offset: 0x00012EEA
			[CompilerGenerated]
			private static void smethod_1(TListBox gparam_0)
			{
				gparam_0.SelectedIndices.Clear();
			}

			// Token: 0x06002414 RID: 9236 RVA: 0x000E1AC8 File Offset: 0x000DFCC8
			[CompilerGenerated]
			private static IEnumerator smethod_2(TListBox gparam_0)
			{
				return gparam_0.SelectedIndices.GetEnumerator();
			}

			// Token: 0x04001161 RID: 4449
			private readonly Class678<TListBox> class678_0;

			// Token: 0x04001162 RID: 4450
			[CompilerGenerated]
			private static Func<TListBox, int> func_0;

			// Token: 0x04001163 RID: 4451
			[CompilerGenerated]
			private static Action<TListBox> action_0;

			// Token: 0x04001164 RID: 4452
			[CompilerGenerated]
			private static Func<TListBox, IEnumerator> func_1;

			// Token: 0x0200056F RID: 1391
			[CompilerGenerated]
			private sealed class Class699
			{
				// Token: 0x06002415 RID: 9237 RVA: 0x000E1AEC File Offset: 0x000DFCEC
				public int method_0(TListBox gparam_0)
				{
					return gparam_0.SelectedIndices[this.int_0];
				}

				// Token: 0x04001165 RID: 4453
				public int int_0;
			}

			// Token: 0x02000570 RID: 1392
			[CompilerGenerated]
			private sealed class Class700
			{
				// Token: 0x06002417 RID: 9239 RVA: 0x00014CFE File Offset: 0x00012EFE
				public void method_0(TListBox gparam_0)
				{
					gparam_0.SelectedIndices.CopyTo(this.array_0, this.int_0);
				}

				// Token: 0x04001166 RID: 4454
				public Array array_0;

				// Token: 0x04001167 RID: 4455
				public int int_0;
			}

			// Token: 0x02000571 RID: 1393
			[CompilerGenerated]
			private sealed class Class701
			{
				// Token: 0x06002419 RID: 9241 RVA: 0x000E1B14 File Offset: 0x000DFD14
				public object method_0(TListBox gparam_0)
				{
					return ((IList)gparam_0.SelectedIndices)[this.int_0];
				}

				// Token: 0x04001168 RID: 4456
				public int int_0;
			}

			// Token: 0x02000572 RID: 1394
			[CompilerGenerated]
			private sealed class Class702
			{
				// Token: 0x0600241B RID: 9243 RVA: 0x00014D1E File Offset: 0x00012F1E
				public void method_0(TListBox gparam_0)
				{
					((IList)gparam_0.SelectedIndices)[this.int_0] = this.value;
				}

				// Token: 0x04001169 RID: 4457
				public int int_0;

				// Token: 0x0400116A RID: 4458
				public object value;
			}

			// Token: 0x02000573 RID: 1395
			[CompilerGenerated]
			private sealed class Class703
			{
				// Token: 0x0600241D RID: 9245 RVA: 0x000E1B3C File Offset: 0x000DFD3C
				public int method_0(TListBox gparam_0)
				{
					return ((IList)gparam_0.SelectedIndices).Add(this.value);
				}

				// Token: 0x0400116B RID: 4459
				public object value;
			}

			// Token: 0x02000574 RID: 1396
			[CompilerGenerated]
			private sealed class Class704
			{
				// Token: 0x0600241F RID: 9247 RVA: 0x00014D3E File Offset: 0x00012F3E
				public bool method_0(TListBox gparam_0)
				{
					return ((IList)gparam_0.SelectedIndices).Contains(this.value);
				}

				// Token: 0x0400116C RID: 4460
				public object value;
			}

			// Token: 0x02000575 RID: 1397
			[CompilerGenerated]
			private sealed class Class705
			{
				// Token: 0x06002421 RID: 9249 RVA: 0x000E1B64 File Offset: 0x000DFD64
				public int method_0(TListBox gparam_0)
				{
					return ((IList)gparam_0.SelectedIndices).IndexOf(this.value);
				}

				// Token: 0x0400116D RID: 4461
				public object value;
			}

			// Token: 0x02000576 RID: 1398
			[CompilerGenerated]
			private sealed class Class706
			{
				// Token: 0x06002423 RID: 9251 RVA: 0x00014D58 File Offset: 0x00012F58
				public void method_0(TListBox gparam_0)
				{
					((IList)gparam_0.SelectedIndices).Insert(this.int_0, this.value);
				}

				// Token: 0x0400116E RID: 4462
				public int int_0;

				// Token: 0x0400116F RID: 4463
				public object value;
			}

			// Token: 0x02000577 RID: 1399
			[CompilerGenerated]
			private sealed class Class707
			{
				// Token: 0x06002425 RID: 9253 RVA: 0x00014D78 File Offset: 0x00012F78
				public void method_0(TListBox gparam_0)
				{
					((IList)gparam_0.SelectedIndices).Remove(this.value);
				}

				// Token: 0x04001170 RID: 4464
				public object value;
			}

			// Token: 0x02000578 RID: 1400
			[CompilerGenerated]
			private sealed class Class708
			{
				// Token: 0x06002427 RID: 9255 RVA: 0x00014D92 File Offset: 0x00012F92
				public void method_0(TListBox gparam_0)
				{
					((IList)gparam_0.SelectedIndices).RemoveAt(this.int_0);
				}

				// Token: 0x04001171 RID: 4465
				public int int_0;
			}
		}

		// Token: 0x02000579 RID: 1401
		public sealed class Class709 : IEnumerable, ICollection, IList
		{
			// Token: 0x17000293 RID: 659
			public object this[int int_0]
			{
				get
				{
					Class678<TListBox>.Class709.Class710 @class = new Class678<TListBox>.Class709.Class710();
					@class.int_0 = int_0;
					return this.class678_0.method_5<object>(new Func<TListBox, object>(@class.method_0));
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x0600242A RID: 9258 RVA: 0x000E1BC0 File Offset: 0x000DFDC0
			public int Count
			{
				get
				{
					Class677<TListBox> @class = this.class678_0;
					if (Class678<TListBox>.Class709.func_0 == null)
					{
						Class678<TListBox>.Class709.func_0 = new Func<TListBox, int>(Class678<TListBox>.Class709.smethod_0);
					}
					return @class.method_5<int>(Class678<TListBox>.Class709.func_0);
				}
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x0600242B RID: 9259 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x0600242C RID: 9260 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x0600242D RID: 9261 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x0600242E RID: 9262 RVA: 0x000E1C00 File Offset: 0x000DFE00
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

			// Token: 0x17000299 RID: 665
			object IList.this[int index]
			{
				get
				{
					Class678<TListBox>.Class709.Class718 @class = new Class678<TListBox>.Class709.Class718();
					@class.int_0 = index;
					return this.class678_0.method_5<object>(new Func<TListBox, object>(@class.method_0));
				}
				set
				{
					Class678<TListBox>.Class709.Class719 @class = new Class678<TListBox>.Class709.Class719();
					@class.int_0 = index;
					@class.value = value;
					this.class678_0.method_4(new Action<TListBox>(@class.method_0));
				}
			}

			// Token: 0x06002431 RID: 9265 RVA: 0x00014DAC File Offset: 0x00012FAC
			internal Class709(Class678<TListBox> class678_1)
			{
				if (class678_1 == null)
				{
					throw new ArgumentNullException("listBox");
				}
				this.class678_0 = class678_1;
			}

			// Token: 0x06002432 RID: 9266 RVA: 0x000E1C9C File Offset: 0x000DFE9C
			public void Clear()
			{
				Class677<TListBox> @class = this.class678_0;
				if (Class678<TListBox>.Class709.action_0 == null)
				{
					Class678<TListBox>.Class709.action_0 = new Action<TListBox>(Class678<TListBox>.Class709.smethod_1);
				}
				@class.method_4(Class678<TListBox>.Class709.action_0);
			}

			// Token: 0x06002433 RID: 9267 RVA: 0x000E1CDC File Offset: 0x000DFEDC
			public bool Contains(object value)
			{
				Class678<TListBox>.Class709.Class711 @class = new Class678<TListBox>.Class709.Class711();
				@class.object_0 = value;
				return this.class678_0.method_5<bool>(new Func<TListBox, bool>(@class.method_0));
			}

			// Token: 0x06002434 RID: 9268 RVA: 0x000E1D10 File Offset: 0x000DFF10
			public void CopyTo(Array array, int index)
			{
				Class678<TListBox>.Class709.Class712 @class = new Class678<TListBox>.Class709.Class712();
				@class.array_0 = array;
				@class.int_0 = index;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x06002435 RID: 9269 RVA: 0x000E1D48 File Offset: 0x000DFF48
			public int IndexOf(object value)
			{
				Class678<TListBox>.Class709.Class713 @class = new Class678<TListBox>.Class709.Class713();
				@class.object_0 = value;
				return this.class678_0.method_5<int>(new Func<TListBox, int>(@class.method_0));
			}

			// Token: 0x06002436 RID: 9270 RVA: 0x000E1D7C File Offset: 0x000DFF7C
			public void Remove(object value)
			{
				Class678<TListBox>.Class709.Class714 @class = new Class678<TListBox>.Class709.Class714();
				@class.value = value;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x06002437 RID: 9271 RVA: 0x000E1DB0 File Offset: 0x000DFFB0
			public IEnumerator GetEnumerator()
			{
				Class677<TListBox> @class = this.class678_0;
				if (Class678<TListBox>.Class709.func_1 == null)
				{
					Class678<TListBox>.Class709.func_1 = new Func<TListBox, IEnumerator>(Class678<TListBox>.Class709.smethod_2);
				}
				return @class.method_5<IEnumerator>(Class678<TListBox>.Class709.func_1);
			}

			// Token: 0x06002438 RID: 9272 RVA: 0x000E1DF0 File Offset: 0x000DFFF0
			int IList.Add(object value)
			{
				Class678<TListBox>.Class709.Class715 @class = new Class678<TListBox>.Class709.Class715();
				@class.value = value;
				return this.class678_0.method_5<int>(new Func<TListBox, int>(@class.method_0));
			}

			// Token: 0x06002439 RID: 9273 RVA: 0x000E1E24 File Offset: 0x000E0024
			void IList.Insert(int index, object value)
			{
				Class678<TListBox>.Class709.Class716 @class = new Class678<TListBox>.Class709.Class716();
				@class.int_0 = index;
				@class.value = value;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x0600243A RID: 9274 RVA: 0x000E1E5C File Offset: 0x000E005C
			void IList.RemoveAt(int index)
			{
				Class678<TListBox>.Class709.Class717 @class = new Class678<TListBox>.Class709.Class717();
				@class.int_0 = index;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x0600243B RID: 9275 RVA: 0x000E1E90 File Offset: 0x000E0090
			[CompilerGenerated]
			private static int smethod_0(TListBox gparam_0)
			{
				return gparam_0.SelectedItems.Count;
			}

			// Token: 0x0600243C RID: 9276 RVA: 0x00014DCF File Offset: 0x00012FCF
			[CompilerGenerated]
			private static void smethod_1(TListBox gparam_0)
			{
				gparam_0.SelectedItems.Clear();
			}

			// Token: 0x0600243D RID: 9277 RVA: 0x000E1EB4 File Offset: 0x000E00B4
			[CompilerGenerated]
			private static IEnumerator smethod_2(TListBox gparam_0)
			{
				return gparam_0.SelectedItems.GetEnumerator();
			}

			// Token: 0x04001172 RID: 4466
			private readonly Class678<TListBox> class678_0;

			// Token: 0x04001173 RID: 4467
			private object object_0;

			// Token: 0x04001174 RID: 4468
			[CompilerGenerated]
			private static Func<TListBox, int> func_0;

			// Token: 0x04001175 RID: 4469
			[CompilerGenerated]
			private static Action<TListBox> action_0;

			// Token: 0x04001176 RID: 4470
			[CompilerGenerated]
			private static Func<TListBox, IEnumerator> func_1;

			// Token: 0x0200057A RID: 1402
			[CompilerGenerated]
			private sealed class Class710
			{
				// Token: 0x0600243E RID: 9278 RVA: 0x000E1ED8 File Offset: 0x000E00D8
				public object method_0(TListBox gparam_0)
				{
					return gparam_0.SelectedItems[this.int_0];
				}

				// Token: 0x04001177 RID: 4471
				public int int_0;
			}

			// Token: 0x0200057B RID: 1403
			[CompilerGenerated]
			private sealed class Class711
			{
				// Token: 0x06002440 RID: 9280 RVA: 0x00014DE3 File Offset: 0x00012FE3
				public bool method_0(TListBox gparam_0)
				{
					return gparam_0.SelectedItems.Contains(this.object_0);
				}

				// Token: 0x04001178 RID: 4472
				public object object_0;
			}

			// Token: 0x0200057C RID: 1404
			[CompilerGenerated]
			private sealed class Class712
			{
				// Token: 0x06002442 RID: 9282 RVA: 0x00014DFD File Offset: 0x00012FFD
				public void method_0(TListBox gparam_0)
				{
					gparam_0.SelectedItems.CopyTo(this.array_0, this.int_0);
				}

				// Token: 0x04001179 RID: 4473
				public Array array_0;

				// Token: 0x0400117A RID: 4474
				public int int_0;
			}

			// Token: 0x0200057D RID: 1405
			[CompilerGenerated]
			private sealed class Class713
			{
				// Token: 0x06002444 RID: 9284 RVA: 0x000E1F00 File Offset: 0x000E0100
				public int method_0(TListBox gparam_0)
				{
					return gparam_0.SelectedItems.IndexOf(this.object_0);
				}

				// Token: 0x0400117B RID: 4475
				public object object_0;
			}

			// Token: 0x0200057E RID: 1406
			[CompilerGenerated]
			private sealed class Class714
			{
				// Token: 0x06002446 RID: 9286 RVA: 0x00014E1D File Offset: 0x0001301D
				public void method_0(TListBox gparam_0)
				{
					gparam_0.SelectedItems.Remove(this.value);
				}

				// Token: 0x0400117C RID: 4476
				public object value;
			}

			// Token: 0x0200057F RID: 1407
			[CompilerGenerated]
			private sealed class Class715
			{
				// Token: 0x06002448 RID: 9288 RVA: 0x000E1F28 File Offset: 0x000E0128
				public int method_0(TListBox gparam_0)
				{
					return ((IList)gparam_0.SelectedItems).Add(this.value);
				}

				// Token: 0x0400117D RID: 4477
				public object value;
			}

			// Token: 0x02000580 RID: 1408
			[CompilerGenerated]
			private sealed class Class716
			{
				// Token: 0x0600244A RID: 9290 RVA: 0x00014E37 File Offset: 0x00013037
				public void method_0(TListBox gparam_0)
				{
					((IList)gparam_0.SelectedItems).Insert(this.int_0, this.value);
				}

				// Token: 0x0400117E RID: 4478
				public int int_0;

				// Token: 0x0400117F RID: 4479
				public object value;
			}

			// Token: 0x02000581 RID: 1409
			[CompilerGenerated]
			private sealed class Class717
			{
				// Token: 0x0600244C RID: 9292 RVA: 0x00014E57 File Offset: 0x00013057
				public void method_0(TListBox gparam_0)
				{
					((IList)gparam_0.SelectedItems).RemoveAt(this.int_0);
				}

				// Token: 0x04001180 RID: 4480
				public int int_0;
			}

			// Token: 0x02000582 RID: 1410
			[CompilerGenerated]
			private sealed class Class718
			{
				// Token: 0x0600244E RID: 9294 RVA: 0x000E1F50 File Offset: 0x000E0150
				public object method_0(TListBox gparam_0)
				{
					return ((IList)gparam_0.SelectedItems)[this.int_0];
				}

				// Token: 0x04001181 RID: 4481
				public int int_0;
			}

			// Token: 0x02000583 RID: 1411
			[CompilerGenerated]
			private sealed class Class719
			{
				// Token: 0x06002450 RID: 9296 RVA: 0x00014E71 File Offset: 0x00013071
				public void method_0(TListBox gparam_0)
				{
					((IList)gparam_0.SelectedItems)[this.int_0] = this.value;
				}

				// Token: 0x04001182 RID: 4482
				public int int_0;

				// Token: 0x04001183 RID: 4483
				public object value;
			}
		}

		// Token: 0x02000584 RID: 1412
		public abstract class Class720 : IEnumerable, ICollection, IList
		{
			// Token: 0x1700029A RID: 666
			public object this[int index]
			{
				get
				{
					Class678<TListBox>.Class720.Class721 @class = new Class678<TListBox>.Class720.Class721();
					@class.int_0 = index;
					return this.class678_0.method_5<object>(new Func<TListBox, object>(@class.method_0));
				}
				set
				{
					Class678<TListBox>.Class720.Class722 @class = new Class678<TListBox>.Class720.Class722();
					@class.int_0 = index;
					@class.value = value;
					this.class678_0.method_4(new Action<TListBox>(@class.method_0));
				}
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06002454 RID: 9300 RVA: 0x000E1FE4 File Offset: 0x000E01E4
			public int Count
			{
				get
				{
					Class677<TListBox> @class = this.class678_0;
					if (Class678<TListBox>.Class720.func_0 == null)
					{
						Class678<TListBox>.Class720.func_0 = new Func<TListBox, int>(Class678<TListBox>.Class720.smethod_0);
					}
					return @class.method_5<int>(Class678<TListBox>.Class720.func_0);
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06002455 RID: 9301 RVA: 0x000081A2 File Offset: 0x000063A2
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06002456 RID: 9302 RVA: 0x000E2024 File Offset: 0x000E0224
			object ICollection.SyncRoot
			{
				get
				{
					TListBox tListBox = this.class678_0.method_3();
					return ((ICollection)tListBox.Items).SyncRoot;
				}
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06002457 RID: 9303 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06002458 RID: 9304 RVA: 0x000081A2 File Offset: 0x000063A2
			bool IList.IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06002459 RID: 9305 RVA: 0x00014E91 File Offset: 0x00013091
			protected Class720(Class678<TListBox> class678_1)
			{
				if (class678_1 == null)
				{
					throw new ArgumentNullException("listBox");
				}
				this.class678_0 = class678_1;
			}

			// Token: 0x0600245A RID: 9306 RVA: 0x000E2054 File Offset: 0x000E0254
			public int Add(object value)
			{
				Class678<TListBox>.Class720.Class723 @class = new Class678<TListBox>.Class720.Class723();
				@class.object_0 = value;
				return this.class678_0.method_5<int>(new Func<TListBox, int>(@class.method_0));
			}

			// Token: 0x0600245B RID: 9307 RVA: 0x000E2088 File Offset: 0x000E0288
			public void Clear()
			{
				Class677<TListBox> @class = this.class678_0;
				if (Class678<TListBox>.Class720.action_0 == null)
				{
					Class678<TListBox>.Class720.action_0 = new Action<TListBox>(Class678<TListBox>.Class720.smethod_1);
				}
				@class.method_4(Class678<TListBox>.Class720.action_0);
			}

			// Token: 0x0600245C RID: 9308 RVA: 0x000E20C8 File Offset: 0x000E02C8
			public bool Contains(object value)
			{
				Class678<TListBox>.Class720.Class724 @class = new Class678<TListBox>.Class720.Class724();
				@class.value = value;
				return this.class678_0.method_5<bool>(new Func<TListBox, bool>(@class.method_0));
			}

			// Token: 0x0600245D RID: 9309 RVA: 0x000E20FC File Offset: 0x000E02FC
			public int IndexOf(object value)
			{
				Class678<TListBox>.Class720.Class725 @class = new Class678<TListBox>.Class720.Class725();
				@class.value = value;
				return this.class678_0.method_5<int>(new Func<TListBox, int>(@class.method_0));
			}

			// Token: 0x0600245E RID: 9310 RVA: 0x000E2130 File Offset: 0x000E0330
			public void Insert(int index, object value)
			{
				Class678<TListBox>.Class720.Class726 @class = new Class678<TListBox>.Class720.Class726();
				@class.int_0 = index;
				@class.object_0 = value;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x0600245F RID: 9311 RVA: 0x000E2168 File Offset: 0x000E0368
			public void Remove(object value)
			{
				Class678<TListBox>.Class720.Class727 @class = new Class678<TListBox>.Class720.Class727();
				@class.value = value;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x06002460 RID: 9312 RVA: 0x000E219C File Offset: 0x000E039C
			public void RemoveAt(int index)
			{
				Class678<TListBox>.Class720.Class728 @class = new Class678<TListBox>.Class720.Class728();
				@class.int_0 = index;
				this.class678_0.method_4(new Action<TListBox>(@class.method_0));
			}

			// Token: 0x06002461 RID: 9313 RVA: 0x000E21D0 File Offset: 0x000E03D0
			public IEnumerator GetEnumerator()
			{
				Class677<TListBox> @class = this.class678_0;
				if (Class678<TListBox>.Class720.func_1 == null)
				{
					Class678<TListBox>.Class720.func_1 = new Func<TListBox, IEnumerator>(Class678<TListBox>.Class720.smethod_2);
				}
				return @class.method_5<IEnumerator>(Class678<TListBox>.Class720.func_1);
			}

			// Token: 0x06002462 RID: 9314 RVA: 0x000E2210 File Offset: 0x000E0410
			void ICollection.CopyTo(Array array, int index)
			{
				for (int i = 0; i < this.Count; i++)
				{
					array.SetValue(this[i], index + i);
				}
			}

			// Token: 0x06002463 RID: 9315 RVA: 0x000E2240 File Offset: 0x000E0440
			[CompilerGenerated]
			private static int smethod_0(TListBox gparam_0)
			{
				return gparam_0.Items.Count;
			}

			// Token: 0x06002464 RID: 9316 RVA: 0x00014EB4 File Offset: 0x000130B4
			[CompilerGenerated]
			private static void smethod_1(TListBox gparam_0)
			{
				gparam_0.Items.Clear();
			}

			// Token: 0x06002465 RID: 9317 RVA: 0x000E2264 File Offset: 0x000E0464
			[CompilerGenerated]
			private static IEnumerator smethod_2(TListBox gparam_0)
			{
				return gparam_0.Items.GetEnumerator();
			}

			// Token: 0x04001184 RID: 4484
			protected readonly Class678<TListBox> class678_0;

			// Token: 0x04001185 RID: 4485
			[CompilerGenerated]
			private static Func<TListBox, int> func_0;

			// Token: 0x04001186 RID: 4486
			[CompilerGenerated]
			private static Action<TListBox> action_0;

			// Token: 0x04001187 RID: 4487
			[CompilerGenerated]
			private static Func<TListBox, IEnumerator> func_1;

			// Token: 0x02000585 RID: 1413
			[CompilerGenerated]
			private sealed class Class721
			{
				// Token: 0x06002466 RID: 9318 RVA: 0x000E2288 File Offset: 0x000E0488
				public object method_0(TListBox gparam_0)
				{
					return gparam_0.Items[this.int_0];
				}

				// Token: 0x04001188 RID: 4488
				public int int_0;
			}

			// Token: 0x02000586 RID: 1414
			[CompilerGenerated]
			private sealed class Class722
			{
				// Token: 0x06002468 RID: 9320 RVA: 0x00014EC8 File Offset: 0x000130C8
				public void method_0(TListBox gparam_0)
				{
					gparam_0.Items[this.int_0] = this.value;
				}

				// Token: 0x04001189 RID: 4489
				public int int_0;

				// Token: 0x0400118A RID: 4490
				public object value;
			}

			// Token: 0x02000587 RID: 1415
			[CompilerGenerated]
			private sealed class Class723
			{
				// Token: 0x0600246A RID: 9322 RVA: 0x000E22B0 File Offset: 0x000E04B0
				public int method_0(TListBox gparam_0)
				{
					return gparam_0.Items.Add(this.object_0);
				}

				// Token: 0x0400118B RID: 4491
				public object object_0;
			}

			// Token: 0x02000588 RID: 1416
			[CompilerGenerated]
			private sealed class Class724
			{
				// Token: 0x0600246C RID: 9324 RVA: 0x00014EE8 File Offset: 0x000130E8
				public bool method_0(TListBox gparam_0)
				{
					return gparam_0.Items.Contains(this.value);
				}

				// Token: 0x0400118C RID: 4492
				public object value;
			}

			// Token: 0x02000589 RID: 1417
			[CompilerGenerated]
			private sealed class Class725
			{
				// Token: 0x0600246E RID: 9326 RVA: 0x000E22D8 File Offset: 0x000E04D8
				public int method_0(TListBox gparam_0)
				{
					return gparam_0.Items.IndexOf(this.value);
				}

				// Token: 0x0400118D RID: 4493
				public object value;
			}

			// Token: 0x0200058A RID: 1418
			[CompilerGenerated]
			private sealed class Class726
			{
				// Token: 0x06002470 RID: 9328 RVA: 0x00014F02 File Offset: 0x00013102
				public void method_0(TListBox gparam_0)
				{
					gparam_0.Items.Insert(this.int_0, this.object_0);
				}

				// Token: 0x0400118E RID: 4494
				public int int_0;

				// Token: 0x0400118F RID: 4495
				public object object_0;
			}

			// Token: 0x0200058B RID: 1419
			[CompilerGenerated]
			private sealed class Class727
			{
				// Token: 0x06002472 RID: 9330 RVA: 0x00014F22 File Offset: 0x00013122
				public void method_0(TListBox gparam_0)
				{
					gparam_0.Items.Remove(this.value);
				}

				// Token: 0x04001190 RID: 4496
				public object value;
			}

			// Token: 0x0200058C RID: 1420
			[CompilerGenerated]
			private sealed class Class728
			{
				// Token: 0x06002474 RID: 9332 RVA: 0x00014F3C File Offset: 0x0001313C
				public void method_0(TListBox gparam_0)
				{
					gparam_0.Items.RemoveAt(this.int_0);
				}

				// Token: 0x04001191 RID: 4497
				public int int_0;
			}
		}
	}
}
