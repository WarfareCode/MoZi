using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns15
{
	// Token: 0x02000607 RID: 1543
	public sealed class Class802<T, TList> : IEnumerable<T>, IList<T>, ICollection<T>, IEnumerable where TList : ICollection, IList<T>
	{
		// Token: 0x170002D4 RID: 724
		public T this[int index]
		{
			get
			{
				Class802<T, TList>.Class803 @class = new Class802<T, TList>.Class803();
				@class.int_0 = index;
				@class.class802_0 = this;
				return this.method_1<T>(new Func<T>(@class.method_0));
			}
			set
			{
				Class802<T, TList>.Class804 @class = new Class802<T, TList>.Class804();
				@class.int_0 = index;
				@class.value = value;
				@class.class802_0 = this;
				this.method_0(new Action(@class.method_0));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x000F0518 File Offset: 0x000EE718
		public int Count
		{
			get
			{
				return this.method_1<int>(new Func<int>(this.method_2));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000F053C File Offset: 0x000EE73C
		public bool IsReadOnly
		{
			get
			{
				TList tList = this.gparam_0;
				return tList.IsReadOnly;
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x00015FD8 File Offset: 0x000141D8
		public Class802(TList gparam_1)
		{
			if (gparam_1 == null)
			{
				throw new ArgumentNullException("list");
			}
			this.gparam_0 = gparam_1;
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000F0560 File Offset: 0x000EE760
		public void Add(T item)
		{
			Class802<T, TList>.Class805 @class = new Class802<T, TList>.Class805();
			@class.gparam_0 = item;
			@class.class802_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00016000 File Offset: 0x00014200
		public void Clear()
		{
			this.method_0(new Action(this.method_3));
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000F0594 File Offset: 0x000EE794
		public bool Contains(T item)
		{
			Class802<T, TList>.Class806 @class = new Class802<T, TList>.Class806();
			@class.gparam_0 = item;
			@class.class802_0 = this;
			return this.method_1<bool>(new Func<bool>(@class.method_0));
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000F05C8 File Offset: 0x000EE7C8
		public int IndexOf(T item)
		{
			Class802<T, TList>.Class807 @class = new Class802<T, TList>.Class807();
			@class.gparam_0 = item;
			@class.class802_0 = this;
			return this.method_1<int>(new Func<int>(@class.method_0));
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000F0600 File Offset: 0x000EE800
		public void Insert(int index, T item)
		{
			Class802<T, TList>.Class808 @class = new Class802<T, TList>.Class808();
			@class.int_0 = index;
			@class.gparam_0 = item;
			@class.class802_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000F063C File Offset: 0x000EE83C
		public bool Remove(T item)
		{
			Class802<T, TList>.Class809 @class = new Class802<T, TList>.Class809();
			@class.gparam_0 = item;
			@class.class802_0 = this;
			return this.method_1<bool>(new Func<bool>(@class.method_0));
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000F0670 File Offset: 0x000EE870
		public void RemoveAt(int index)
		{
			Class802<T, TList>.Class810 @class = new Class802<T, TList>.Class810();
			@class.int_0 = index;
			@class.class802_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000F06A4 File Offset: 0x000EE8A4
		public void CopyTo(T[] array, int arrayIndex)
		{
			Class802<T, TList>.Class811 @class = new Class802<T, TList>.Class811();
			@class.gparam_0 = array;
			@class.int_0 = arrayIndex;
			@class.class802_0 = this;
			this.method_0(new Action(@class.method_0));
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000F06E0 File Offset: 0x000EE8E0
		public IEnumerator<T> GetEnumerator()
		{
			Class802<T, TList>.Class812 @class = new Class802<T, TList>.Class812();
			@class.class802_0 = this;
			@class.gparam_0 = null;
			this.method_0(new Action(@class.method_0));
			return ((IEnumerable<T>)@class.gparam_0).GetEnumerator();
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000F0728 File Offset: 0x000EE928
		private void method_0(Action action_0)
		{
			bool flag = false;
			object obj = null;
			try
			{
				TList tList = this.gparam_0;
				Monitor.Enter(obj = tList.SyncRoot, ref flag);
				action_0();
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(obj);
				}
			}
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000F077C File Offset: 0x000EE97C
		private TResult method_1<TResult>(Func<TResult> func_0)
		{
			bool flag = false;
			object obj = null;
			TResult result;
			try
			{
				TList tList = this.gparam_0;
				Monitor.Enter(obj = tList.SyncRoot, ref flag);
				result = func_0();
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(obj);
				}
			}
			return result;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000F07D8 File Offset: 0x000EE9D8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000F07F0 File Offset: 0x000EE9F0
		[CompilerGenerated]
		private int method_2()
		{
			//ZSP ERR return this.gparam_0.Count;

            return ((ICollection)this.gparam_0).Count;
        }

		// Token: 0x06002769 RID: 10089 RVA: 0x000F0810 File Offset: 0x000EEA10
		[CompilerGenerated]
		private void method_3()
		{
			TList tList = this.gparam_0;
			tList.Clear();
		}

		// Token: 0x040012F0 RID: 4848
		private readonly TList gparam_0;

		// Token: 0x02000608 RID: 1544
		[CompilerGenerated]
		private sealed class Class803
		{
			// Token: 0x0600276A RID: 10090 RVA: 0x000F0834 File Offset: 0x000EEA34
			public T method_0()
			{
				TList gparam_ = this.class802_0.gparam_0;
				return gparam_[this.int_0];
			}

			// Token: 0x040012F1 RID: 4849
			public Class802<T, TList> class802_0;

			// Token: 0x040012F2 RID: 4850
			public int int_0;
		}

		// Token: 0x02000609 RID: 1545
		[CompilerGenerated]
		private sealed class Class804
		{
			// Token: 0x0600276C RID: 10092 RVA: 0x000F0864 File Offset: 0x000EEA64
			public void method_0()
			{
				TList gparam_ = this.class802_0.gparam_0;
				gparam_[this.int_0] = this.value;
			}

			// Token: 0x040012F3 RID: 4851
			public Class802<T, TList> class802_0;

			// Token: 0x040012F4 RID: 4852
			public int int_0;

			// Token: 0x040012F5 RID: 4853
			public T value;
		}

		// Token: 0x0200060A RID: 1546
		[CompilerGenerated]
		private sealed class Class805
		{
			// Token: 0x0600276E RID: 10094 RVA: 0x000F0898 File Offset: 0x000EEA98
			public void method_0()
			{
				TList tList = this.class802_0.gparam_0;
				tList.Add(this.gparam_0);
			}

			// Token: 0x040012F6 RID: 4854
			public Class802<T, TList> class802_0;

			// Token: 0x040012F7 RID: 4855
			public T gparam_0;
		}

		// Token: 0x0200060B RID: 1547
		[CompilerGenerated]
		private sealed class Class806
		{
			// Token: 0x06002770 RID: 10096 RVA: 0x000F08C4 File Offset: 0x000EEAC4
			public bool method_0()
			{
				TList tList = this.class802_0.gparam_0;
				return tList.Contains(this.gparam_0);
			}

			// Token: 0x040012F8 RID: 4856
			public Class802<T, TList> class802_0;

			// Token: 0x040012F9 RID: 4857
			public T gparam_0;
		}

		// Token: 0x0200060C RID: 1548
		[CompilerGenerated]
		private sealed class Class807
		{
			// Token: 0x06002772 RID: 10098 RVA: 0x000F08F0 File Offset: 0x000EEAF0
			public int method_0()
			{
				TList tList = this.class802_0.gparam_0;
				return tList.IndexOf(this.gparam_0);
			}

			// Token: 0x040012FA RID: 4858
			public Class802<T, TList> class802_0;

			// Token: 0x040012FB RID: 4859
			public T gparam_0;
		}

		// Token: 0x0200060D RID: 1549
		[CompilerGenerated]
		private sealed class Class808
		{
			// Token: 0x06002774 RID: 10100 RVA: 0x000F0920 File Offset: 0x000EEB20
			public void method_0()
			{
				TList tList = this.class802_0.gparam_0;
				tList.Insert(this.int_0, this.gparam_0);
			}

			// Token: 0x040012FC RID: 4860
			public Class802<T, TList> class802_0;

			// Token: 0x040012FD RID: 4861
			public int int_0;

			// Token: 0x040012FE RID: 4862
			public T gparam_0;
		}

		// Token: 0x0200060E RID: 1550
		[CompilerGenerated]
		private sealed class Class809
		{
			// Token: 0x06002776 RID: 10102 RVA: 0x000F0954 File Offset: 0x000EEB54
			public bool method_0()
			{
				TList tList = this.class802_0.gparam_0;
				return tList.Remove(this.gparam_0);
			}

			// Token: 0x040012FF RID: 4863
			public Class802<T, TList> class802_0;

			// Token: 0x04001300 RID: 4864
			public T gparam_0;
		}

		// Token: 0x0200060F RID: 1551
		[CompilerGenerated]
		private sealed class Class810
		{
			// Token: 0x06002778 RID: 10104 RVA: 0x000F0980 File Offset: 0x000EEB80
			public void method_0()
			{
				TList gparam_ = this.class802_0.gparam_0;
				gparam_.RemoveAt(this.int_0);
			}

			// Token: 0x04001301 RID: 4865
			public Class802<T, TList> class802_0;

			// Token: 0x04001302 RID: 4866
			public int int_0;
		}

		// Token: 0x02000610 RID: 1552
		[CompilerGenerated]
		private sealed class Class811
		{
			// Token: 0x0600277A RID: 10106 RVA: 0x000F09AC File Offset: 0x000EEBAC
			public void method_0()
			{
				TList tList = this.class802_0.gparam_0;
				tList.CopyTo(this.gparam_0, this.int_0);
			}

			// Token: 0x04001303 RID: 4867
			public Class802<T, TList> class802_0;

			// Token: 0x04001304 RID: 4868
			public T[] gparam_0;

			// Token: 0x04001305 RID: 4869
			public int int_0;
		}

		// Token: 0x02000611 RID: 1553
		[CompilerGenerated]
		private sealed class Class812
		{
			// Token: 0x0600277C RID: 10108 RVA: 0x000F09E0 File Offset: 0x000EEBE0
			public void method_0()
			{
                //ZSP ERR this.gparam_0 = new T[this.class802_0.gparam_0.Count];
                
                this.gparam_0 = new T[((ICollection)this.class802_0.gparam_0).Count];
                TList tList = this.class802_0.gparam_0;
				tList.CopyTo(this.gparam_0, 0);
			}

			// Token: 0x04001306 RID: 4870
			public T[] gparam_0;

			// Token: 0x04001307 RID: 4871
			public Class802<T, TList> class802_0;
		}
	}
}
