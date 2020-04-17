using System;
using System.Globalization;

namespace ns29
{
	// Token: 0x02000150 RID: 336
	public class Class2373 : IConfig
	{
		// Token: 0x06000740 RID: 1856 RVA: 0x00069ABC File Offset: 0x00067CBC
		public Class2373(string string_1, Interface49 interface49_1)
		{
			this.string_0 = string_1;
			this.interface49_0 = interface49_1;
			this.class2370_0 = new Class2370();
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00069B14 File Offset: 0x00067D14
		public string imethod_0()
		{
			return this.string_0;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00069B2C File Offset: 0x00067D2C
		public Interface49 vmethod_0()
		{
			return this.interface49_0;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00069B44 File Offset: 0x00067D44
		public virtual string GetValue(string string_1)
		{
			string result = null;
			if (this.class2376_0.Contains(string_1))
			{
				result = this.class2376_0[string_1].ToString();
			}
			return result;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00069B7C File Offset: 0x00067D7C
		public bool GetValueString(string string_1)
		{
			string value = this.GetValue(string_1);
			if (value == null)
			{
				throw new ArgumentException("Value not found: " + string_1);
			}
			return this.method_2(value);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00069BB4 File Offset: 0x00067DB4
		public string[] imethod_3()
		{
			string[] array = new string[this.class2376_0.Keys.Count];
			this.class2376_0.Keys.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00007F36 File Offset: 0x00006136
		public void method_0(string string_1, string string_2)
		{
			this.class2376_0.Add(string_1, string_2);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00069BEC File Offset: 0x00067DEC
		public virtual void SetValueString(string string_1, object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentNullException("Value cannot be null");
			}
			if (this.GetValue(string_1) == null)
			{
				this.method_0(string_1, object_0.ToString());
			}
			else
			{
				this.class2376_0[string_1] = object_0.ToString();
			}
			if (this.vmethod_0().imethod_1())
			{
				this.vmethod_0().imethod_3();
			}
			this.method_1(new EventArgs3(string_1, object_0.ToString()));
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00007F45 File Offset: 0x00006145
		protected void method_1(EventArgs3 eventArgs3_0)
		{
			if (this.delegate39_0 != null)
			{
				this.delegate39_0(this, eventArgs3_0);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00069C6C File Offset: 0x00067E6C
		private bool method_2(string string_1)
		{
			bool result;
			if (this.class2370_0.method_1(string_1))
			{
				result = this.class2370_0.method_2(string_1);
			}
			else
			{
				if (!this.vmethod_0().imethod_2().method_1(string_1))
				{
					throw new ArgumentException("Alias value not found: " + string_1 + ". Add it to the Alias property.");
				}
				result = this.vmethod_0().imethod_2().method_2(string_1);
			}
			return result;
		}

		// Token: 0x04000343 RID: 835
		private string string_0 = null;

		// Token: 0x04000344 RID: 836
		private Interface49 interface49_0 = null;

		// Token: 0x04000345 RID: 837
		private Class2370 class2370_0 = null;

		// Token: 0x04000346 RID: 838
		private IFormatProvider iformatProvider_0 = NumberFormatInfo.CurrentInfo;

		// Token: 0x04000347 RID: 839
		protected Class2376 class2376_0 = new Class2376();

		// Token: 0x04000348 RID: 840
		private Delegate39 delegate39_0;
	}
}
