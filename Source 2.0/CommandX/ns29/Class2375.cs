using System;
using System.Collections;

namespace ns29
{
	// Token: 0x0200015C RID: 348
	public sealed class Class2375 : IEnumerable, ICollection, IList
	{
		// Token: 0x170000A8 RID: 168
		public IConfig this[int int_0]
		{
			get
			{
				return (IConfig)this.arrayList_0[int_0];
			}
		}

		// Token: 0x170000A9 RID: 169
		public IConfig this[string string_0]
		{
			get
			{
				IConfig result = null;
				foreach (IConfig config in this.arrayList_0)
				{
					if (config.imethod_0() == string_0)
					{
						result = config;
						break;
					}
				}
				return result;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0006A0A0 File Offset: 0x000682A0
		public int Count
		{
			get
			{
				return this.arrayList_0.Count;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0006A0BC File Offset: 0x000682BC
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AF RID: 175
		object IList.this[int index]
		{
			get
			{
				return this.arrayList_0[index];
			}
			set
			{
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000081A5 File Offset: 0x000063A5
		public Class2375(Class2371 class2371_1)
		{
			this.class2371_0 = class2371_1;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0006A0E8 File Offset: 0x000682E8
		public void method_0(IConfig interface50_0)
		{
			if (this.arrayList_0.Contains(interface50_0))
			{
				throw new ArgumentException("IConfig already exists");
			}
			IConfig config = this[interface50_0.imethod_0()];
			if (config != null)
			{
				string[] array = interface50_0.imethod_3();
				for (int i = 0; i < array.Length; i++)
				{
					config.SetValueString(array[i], interface50_0.GetValue(array[i]));
				}
			}
			else
			{
				this.arrayList_0.Add(interface50_0);
				this.method_2(new EventArgs4(interface50_0));
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0006A168 File Offset: 0x00068368
		int IList.Add(object value)
		{
			IConfig config = value as IConfig;
			if (config == null)
			{
				throw new Exception("Must be an IConfig");
			}
			this.method_0(config);
			return this.IndexOf(config);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0006A1A0 File Offset: 0x000683A0
		public IConfig method_1(string string_0)
		{
			if (this[string_0] != null)
			{
				throw new ArgumentException("An IConfig of that name already exists");
			}
			Class2373 @class = new Class2373(string_0, this.class2371_0);
			this.arrayList_0.Add(@class);
			this.method_2(new EventArgs4(@class));
			return @class;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000081C6 File Offset: 0x000063C6
		public void Remove(object value)
		{
			this.arrayList_0.Remove(value);
			this.method_3(new EventArgs4((IConfig)value));
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0006A1F0 File Offset: 0x000683F0
		public void RemoveAt(int index)
		{
			IConfig interface50_ = (IConfig)this.arrayList_0[index];
			this.arrayList_0.RemoveAt(index);
			this.method_3(new EventArgs4(interface50_));
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000081E5 File Offset: 0x000063E5
		public void Clear()
		{
			this.arrayList_0.Clear();
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0006A228 File Offset: 0x00068428
		public IEnumerator GetEnumerator()
		{
			return this.arrayList_0.GetEnumerator();
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000081F2 File Offset: 0x000063F2
		public void CopyTo(Array array, int index)
		{
			this.arrayList_0.CopyTo(array, index);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00008201 File Offset: 0x00006401
		public bool Contains(object value)
		{
			return this.arrayList_0.Contains(value);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0006A244 File Offset: 0x00068444
		public int IndexOf(object value)
		{
			return this.arrayList_0.IndexOf(value);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000820F File Offset: 0x0000640F
		public void Insert(int index, object value)
		{
			this.arrayList_0.Insert(index, value);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0000821E File Offset: 0x0000641E
		protected void method_2(EventArgs4 eventArgs4_0)
		{
			if (this.delegate40_0 != null)
			{
				this.delegate40_0(this, eventArgs4_0);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00008238 File Offset: 0x00006438
		protected void method_3(EventArgs4 eventArgs4_0)
		{
			if (this.delegate40_1 != null)
			{
				this.delegate40_1(this, eventArgs4_0);
			}
		}

		// Token: 0x04000359 RID: 857
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x0400035A RID: 858
		private Class2371 class2371_0 = null;

		// Token: 0x0400035B RID: 859
		private Delegate40 delegate40_0;

		// Token: 0x0400035C RID: 860
		private Delegate40 delegate40_1;
	}
}
