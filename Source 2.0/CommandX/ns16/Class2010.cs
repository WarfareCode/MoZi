using System;

namespace ns16
{
	// Token: 0x020004C8 RID: 1224
	public class Class2010 : IComparable, ICloneable, Interface28
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x000D142C File Offset: 0x000CF62C
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x000132E1 File Offset: 0x000114E1
		public int Value
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				this.bool_0 = false;
				this.bool_1 = false;
			}
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x000132F8 File Offset: 0x000114F8
		public Class2010()
		{
			this.bool_1 = false;
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00013315 File Offset: 0x00011515
		public Class2010(int int_1)
		{
			this.int_0 = int_1;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00013340 File Offset: 0x00011540
		public Class2010(string string_0)
		{
			this.method_0(string_0);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x000D1444 File Offset: 0x000CF644
		public override string ToString()
		{
			string result;
			if (this.bool_0)
			{
				result = "";
			}
			else
			{
				result = this.int_0.ToString();
			}
			return result;
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000D1474 File Offset: 0x000CF674
		public void method_0(string string_0)
		{
			if (string_0 != null && !(string_0 == ""))
			{
				try
				{
					this.int_0 = Convert.ToInt32(string_0);
					this.bool_0 = false;
					this.bool_1 = false;
					return;
				}
				catch (FormatException exception_)
				{
					throw new Exception15(exception_);
				}
			}
			this.int_0 = 0;
			this.bool_0 = true;
			this.bool_1 = true;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000D14E0 File Offset: 0x000CF6E0
		public override int GetHashCode()
		{
			return this.Value;
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0001335D File Offset: 0x0001155D
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class2010 && this.Value == ((Class2010)obj).Value;
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000D14F8 File Offset: 0x000CF6F8
		public int CompareTo(object target)
		{
			return this.Value.CompareTo(((Class2010)target).Value);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x000D1520 File Offset: 0x000CF720
		public object Clone()
		{
			return new Class2010(this.Value);
		}

		// Token: 0x04000F1E RID: 3870
		protected int int_0;

		// Token: 0x04000F1F RID: 3871
		protected bool bool_0 = true;

		// Token: 0x04000F20 RID: 3872
		protected bool bool_1 = true;
	}
}
