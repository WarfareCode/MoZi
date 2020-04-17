using System;

namespace ns16
{
	// Token: 0x020004CC RID: 1228
	public sealed class Class2018 : IComparable, ICloneable, Interface28
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x000D16DC File Offset: 0x000CF8DC
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x00013436 File Offset: 0x00011636
		public long Value
		{
			get
			{
				return this.long_0;
			}
			set
			{
				this.long_0 = value;
				this.bool_0 = false;
				this.bool_1 = false;
			}
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0001344D File Offset: 0x0001164D
		public Class2018()
		{
			this.bool_1 = false;
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0001346A File Offset: 0x0001166A
		public Class2018(long long_1)
		{
			this.long_0 = long_1;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00013495 File Offset: 0x00011695
		public Class2018(string string_0)
		{
			this.method_0(string_0);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000D16F4 File Offset: 0x000CF8F4
		public void method_0(string string_0)
		{
			if (string_0 != null && !(string_0 == ""))
			{
				try
				{
					this.long_0 = Convert.ToInt64(string_0);
					this.bool_0 = false;
					this.bool_1 = false;
					return;
				}
				catch (FormatException exception_)
				{
					throw new Exception15(exception_);
				}
			}
			this.long_0 = 0L;
			this.bool_0 = true;
			this.bool_1 = true;
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000D1768 File Offset: 0x000CF968
		public override string ToString()
		{
			string result;
			if (this.bool_0)
			{
				result = "";
			}
			else
			{
				result = this.long_0.ToString();
			}
			return result;
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x000D1798 File Offset: 0x000CF998
		public override int GetHashCode()
		{
			return (int)this.Value;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000134B2 File Offset: 0x000116B2
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class2018 && this.Value == ((Class2018)obj).Value;
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000D17B0 File Offset: 0x000CF9B0
		public int CompareTo(object target)
		{
			return this.Value.CompareTo(((Class2018)target).Value);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000D17D8 File Offset: 0x000CF9D8
		public object Clone()
		{
			return new Class2018(this.Value);
		}

		// Token: 0x04000F30 RID: 3888
		protected long long_0;

		// Token: 0x04000F31 RID: 3889
		protected bool bool_0 = true;

		// Token: 0x04000F32 RID: 3890
		protected bool bool_1 = true;
	}
}
