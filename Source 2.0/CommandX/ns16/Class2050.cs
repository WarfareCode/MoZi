using System;
using System.Globalization;

namespace ns16
{
	// Token: 0x0200015A RID: 346
	public class Class2050 : IComparable, ICloneable, Interface28
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00069E68 File Offset: 0x00068068
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x000080DB File Offset: 0x000062DB
		public string Value
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
				this.bool_0 = (this.string_0.Length == 0);
				this.bool_1 = false;
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000080FF File Offset: 0x000062FF
		public Class2050()
		{
			this.bool_1 = false;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00008127 File Offset: 0x00006327
		public Class2050(string string_1)
		{
			this.string_0 = string_1;
			this.bool_0 = (string_1.Length == 0);
			this.bool_1 = false;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00069E80 File Offset: 0x00068080
		public override string ToString()
		{
			string result;
			if (this.bool_0)
			{
				result = "";
			}
			else
			{
				result = this.string_0;
			}
			return result;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00069EA8 File Offset: 0x000680A8
		public bool method_0()
		{
			bool flag = false;
			bool result;
			try
			{
				Convert.ToDecimal(this.string_0, CultureInfo.InvariantCulture);
				result = true;
				return result;
			}
			catch (FormatException)
			{
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00069EE4 File Offset: 0x000680E4
		public override int GetHashCode()
		{
			return this.string_0.GetHashCode();
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00008165 File Offset: 0x00006365
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class2050 && this.string_0 == ((Class2050)obj).string_0;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00069F00 File Offset: 0x00068100
		public int CompareTo(object target)
		{
			return this.string_0.CompareTo(((Class2050)target).string_0);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00069F28 File Offset: 0x00068128
		public object Clone()
		{
			return new Class2050(this.string_0);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00069F44 File Offset: 0x00068144
		public bool vmethod_0()
		{
			return this.string_0 != null && this.string_0.Length != 0 && this.string_0.ToLower().CompareTo("false") != 0 && (!this.method_0() || this.vmethod_1().CompareTo(0.0m) != 0);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00069FAC File Offset: 0x000681AC
		public decimal vmethod_1()
		{
			decimal result;
			if (this.string_0 == "")
			{
				result = 0m;
			}
			else
			{
				decimal num;
				try
				{
					num = Convert.ToDecimal(this.string_0, CultureInfo.InvariantCulture);
				}
				catch (FormatException)
				{
					throw new Exception16(this, new Class2020());
				}
				result = num;
			}
			return result;
		}

		// Token: 0x04000356 RID: 854
		public string string_0 = "";

		// Token: 0x04000357 RID: 855
		public bool bool_0 = true;

		// Token: 0x04000358 RID: 856
		public bool bool_1 = true;
	}
}
