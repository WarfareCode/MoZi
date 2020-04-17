using System;
using System.Text;
using ns13;

namespace ns14
{
	// Token: 0x02000445 RID: 1093
	public sealed class Class646
	{
		// Token: 0x17000231 RID: 561
		public Enum143 this[Enum140 enum140_0]
		{
			get
			{
				return this.method_1(enum140_0);
			}
			set
			{
				this.method_9(enum140_0, value);
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000117E0 File Offset: 0x0000F9E0
		public Class646(Enum143 enum143_1, Enum143 enum143_2, Enum143 enum143_3)
		{
			this.method_0(3);
			this.enum143_0[0] = enum143_1;
			this.enum143_0[1] = enum143_2;
			this.enum143_0[2] = enum143_3;
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0001180A File Offset: 0x0000FA0A
		public Class646(Enum143 enum143_1)
		{
			this.method_0(1);
			this.enum143_0[0] = enum143_1;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000B369C File Offset: 0x000B189C
		public Class646(Class646 class646_0)
		{
			if (class646_0 == null)
			{
				throw new ArgumentNullException("gl", "null topology location specified");
			}
			this.method_0(class646_0.enum143_0.Length);
			for (int i = 0; i < this.enum143_0.Length; i++)
			{
				this.enum143_0[i] = class646_0.enum143_0[i];
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00011822 File Offset: 0x0000FA22
		private void method_0(int int_0)
		{
			this.enum143_0 = new Enum143[int_0];
			this.method_7(Enum143.const_3);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000B36FC File Offset: 0x000B18FC
		public Enum143 method_1(Enum140 enum140_0)
		{
			Enum143 result;
			if (enum140_0 < (Enum140)this.enum143_0.Length)
			{
				result = this.enum143_0[(int)enum140_0];
			}
			else
			{
				result = Enum143.const_3;
			}
			return result;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x000B372C File Offset: 0x000B192C
		public bool method_2()
		{
			bool result;
			for (int i = 0; i < this.enum143_0.Length; i++)
			{
				if (this.enum143_0[i] != Enum143.const_3)
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x000B3764 File Offset: 0x000B1964
		public bool method_3()
		{
			bool result;
			for (int i = 0; i < this.enum143_0.Length; i++)
			{
				if (this.enum143_0[i] == Enum143.const_3)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00011837 File Offset: 0x0000FA37
		public bool method_4()
		{
			return this.enum143_0.Length > 1;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00011844 File Offset: 0x0000FA44
		public bool method_5()
		{
			return this.enum143_0.Length == 1;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000B37A0 File Offset: 0x000B19A0
		public void method_6()
		{
			if (this.enum143_0.Length > 1)
			{
				Enum143 @enum = this.enum143_0[1];
				this.enum143_0[1] = this.enum143_0[2];
				this.enum143_0[2] = @enum;
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x000B37E0 File Offset: 0x000B19E0
		public void method_7(Enum143 enum143_1)
		{
			for (int i = 0; i < this.enum143_0.Length; i++)
			{
				this.enum143_0[i] = enum143_1;
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000B380C File Offset: 0x000B1A0C
		public void method_8(Enum143 enum143_1)
		{
			for (int i = 0; i < this.enum143_0.Length; i++)
			{
				if (this.enum143_0[i] == Enum143.const_3)
				{
					this.enum143_0[i] = enum143_1;
				}
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00011851 File Offset: 0x0000FA51
		public void method_9(Enum140 enum140_0, Enum143 enum143_1)
		{
			this.enum143_0[(int)enum140_0] = enum143_1;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0001185C File Offset: 0x0000FA5C
		public void method_10(Enum143 enum143_1)
		{
			this.method_9(Enum140.const_0, enum143_1);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00011866 File Offset: 0x0000FA66
		public void method_11(Enum143 enum143_1, Enum143 enum143_2, Enum143 enum143_3)
		{
			this.enum143_0[0] = enum143_1;
			this.enum143_0[1] = enum143_2;
			this.enum143_0[2] = enum143_3;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000B3848 File Offset: 0x000B1A48
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.enum143_0.Length > 1)
			{
				stringBuilder.Append(Class668.smethod_0(this.enum143_0[1]));
			}
			stringBuilder.Append(Class668.smethod_0(this.enum143_0[0]));
			if (this.enum143_0.Length > 1)
			{
				stringBuilder.Append(Class668.smethod_0(this.enum143_0[2]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000C21 RID: 3105
		private Enum143[] enum143_0;
	}
}
