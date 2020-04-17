using System;

namespace ns16
{
	// Token: 0x020004D3 RID: 1235
	public sealed class Class2049 : IComparable, ICloneable, Interface28
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x000D2BE8 File Offset: 0x000D0DE8
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x0001364C File Offset: 0x0001184C
		public TimeSpan Value
		{
			get
			{
				return this.timeSpan_0;
			}
			set
			{
				this.timeSpan_0 = value;
				this.bool_0 = false;
				this.bool_1 = false;
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00013663 File Offset: 0x00011863
		public Class2049()
		{
			this.bool_1 = false;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000D2C00 File Offset: 0x000D0E00
		public Class2049(Class2049 class2049_0)
		{
			this.timeSpan_0 = class2049_0.timeSpan_0;
			this.int_0 = class2049_0.int_0;
			this.int_1 = class2049_0.int_1;
			this.bool_0 = class2049_0.bool_0;
			this.bool_1 = class2049_0.bool_1;
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x000D2C74 File Offset: 0x000D0E74
		public override string ToString()
		{
			string result;
			if (this.bool_0)
			{
				result = "";
			}
			else
			{
				string text = "";
				if (this.timeSpan_0.Ticks < 0L)
				{
					text += "-";
				}
				text += "P";
				if (this.int_1 != 0)
				{
					text = text + Math.Abs(this.int_1).ToString() + "Y";
				}
				if (this.int_0 != 0)
				{
					text = text + Math.Abs(this.int_0).ToString() + "m";
				}
				if (this.timeSpan_0.Days != 0)
				{
					text = text + Math.Abs(this.timeSpan_0.Days).ToString() + "D";
				}
				double num = (double)Math.Abs(this.timeSpan_0.Ticks) / 10000000.0 % 1.0;
				if (this.timeSpan_0.Hours != 0 || this.timeSpan_0.Minutes != 0 || this.timeSpan_0.Seconds != 0 || num > 0.0)
				{
					text += "T";
					if (this.timeSpan_0.Hours != 0)
					{
						text = text + Math.Abs(this.timeSpan_0.Hours).ToString() + "H";
					}
					if (this.timeSpan_0.Minutes != 0)
					{
						text = text + Math.Abs(this.timeSpan_0.Minutes).ToString() + "m";
					}
					if (this.timeSpan_0.Seconds != 0)
					{
						text += Math.Abs(this.timeSpan_0.Seconds).ToString("#0");
					}
					if (num > 0.0 && num < 1.0)
					{
						string text2 = num.ToString("0.##########");
						text = text + "." + text2.Substring(2, text2.Length - 2);
					}
					if (this.timeSpan_0.Seconds != 0 || (num > 0.0 && num < 1.0))
					{
						text += "S";
					}
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x000D2EF0 File Offset: 0x000D10F0
		public override int GetHashCode()
		{
			return this.timeSpan_0.GetHashCode();
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x000D2F10 File Offset: 0x000D1110
		public override bool Equals(object obj)
		{
			bool result;
			if (obj == null)
			{
				result = false;
			}
			else if (!(obj is Class2049))
			{
				result = false;
			}
			else
			{
				Class2049 @class = (Class2049)obj;
				result = (!(this.timeSpan_0 != @class.timeSpan_0) && this.int_0 == @class.int_0 && this.int_1 == @class.int_1);
			}
			return result;
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x000D2F74 File Offset: 0x000D1174
		public int CompareTo(object target)
		{
			Class2049 @class = (Class2049)target;
			int result;
			if (this.int_1 > @class.int_1)
			{
				result = 1;
			}
			else if (this.int_1 < @class.int_1)
			{
				result = -1;
			}
			else if (this.int_0 > @class.int_0)
			{
				result = 1;
			}
			else if (this.int_0 < @class.int_0)
			{
				result = -1;
			}
			else
			{
				result = this.timeSpan_0.CompareTo(@class.timeSpan_0);
			}
			return result;
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000D2FF8 File Offset: 0x000D11F8
		public object Clone()
		{
			return new Class2049(this);
		}

		// Token: 0x04000F72 RID: 3954
		protected TimeSpan timeSpan_0 = new TimeSpan(0L);

		// Token: 0x04000F73 RID: 3955
		protected int int_0;

		// Token: 0x04000F74 RID: 3956
		protected int int_1;

		// Token: 0x04000F75 RID: 3957
		protected bool bool_0 = true;

		// Token: 0x04000F76 RID: 3958
		protected bool bool_1 = true;
	}
}
