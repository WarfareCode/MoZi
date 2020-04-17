using System;
using System.Text;
using ns13;

namespace ns14
{
	// Token: 0x02000452 RID: 1106
	public sealed class Class652
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x00011B76 File Offset: 0x0000FD76
		public Class652(Enum143 enum143_0)
		{
			this.class646_0[0] = new Class646(enum143_0);
			this.class646_0[1] = new Class646(enum143_0);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00011BA6 File Offset: 0x0000FDA6
		public Class652(int int_0, Enum143 enum143_0)
		{
			this.class646_0[0] = new Class646(Enum143.const_3);
			this.class646_0[1] = new Class646(Enum143.const_3);
			this.class646_0[int_0].method_10(enum143_0);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00011BE4 File Offset: 0x0000FDE4
		public Class652(Enum143 enum143_0, Enum143 enum143_1, Enum143 enum143_2)
		{
			this.class646_0[0] = new Class646(enum143_0, enum143_1, enum143_2);
			this.class646_0[1] = new Class646(enum143_0, enum143_1, enum143_2);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000B4FE0 File Offset: 0x000B31E0
		public Class652(int int_0, Enum143 enum143_0, Enum143 enum143_1, Enum143 enum143_2)
		{
			this.class646_0[0] = new Class646(Enum143.const_3, Enum143.const_3, Enum143.const_3);
			this.class646_0[1] = new Class646(Enum143.const_3, Enum143.const_3, Enum143.const_3);
			this.class646_0[int_0].method_11(enum143_0, enum143_1, enum143_2);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00011C18 File Offset: 0x0000FE18
		public Class652(Class652 class652_0)
		{
			this.class646_0[0] = new Class646(class652_0.class646_0[0]);
			this.class646_0[1] = new Class646(class652_0.class646_0[1]);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00011C56 File Offset: 0x0000FE56
		public void method_0()
		{
			this.class646_0[0].method_6();
			this.class646_0[1].method_6();
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x000B5030 File Offset: 0x000B3230
		public Enum143 method_1(int int_0, Enum140 enum140_0)
		{
			return this.class646_0[int_0].method_1(enum140_0);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x000B5050 File Offset: 0x000B3250
		public Enum143 method_2(int int_0)
		{
			return this.class646_0[int_0].method_1(Enum140.const_0);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00011C72 File Offset: 0x0000FE72
		public void method_3(int int_0, Enum140 enum140_0, Enum143 enum143_0)
		{
			this.class646_0[int_0].method_9(enum140_0, enum143_0);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00011C83 File Offset: 0x0000FE83
		public void method_4(int int_0, Enum143 enum143_0)
		{
			this.class646_0[int_0].method_9(Enum140.const_0, enum143_0);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00011C94 File Offset: 0x0000FE94
		public void method_5(int int_0, Enum143 enum143_0)
		{
			this.class646_0[int_0].method_7(enum143_0);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		public void method_6(int int_0, Enum143 enum143_0)
		{
			this.class646_0[int_0].method_8(enum143_0);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000B5070 File Offset: 0x000B3270
		public int method_7()
		{
			int num = 0;
			if (!this.class646_0[0].method_2())
			{
				num++;
			}
			if (!this.class646_0[1].method_2())
			{
				num++;
			}
			return num;
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00011CB4 File Offset: 0x0000FEB4
		public bool method_8(int int_0)
		{
			return this.class646_0[int_0].method_2();
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00011CC3 File Offset: 0x0000FEC3
		public bool method_9(int int_0)
		{
			return this.class646_0[int_0].method_3();
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00011CD2 File Offset: 0x0000FED2
		public bool method_10()
		{
			return this.class646_0[0].method_4() || this.class646_0[1].method_4();
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00011CF3 File Offset: 0x0000FEF3
		public bool method_11(int int_0)
		{
			return this.class646_0[int_0].method_4();
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00011D02 File Offset: 0x0000FF02
		public bool method_12(int int_0)
		{
			return this.class646_0[int_0].method_5();
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x000B50A8 File Offset: 0x000B32A8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.class646_0[0] != null)
			{
				stringBuilder.Append("a:");
				stringBuilder.Append(this.class646_0[0].ToString());
			}
			if (this.class646_0[1] != null)
			{
				stringBuilder.Append(" b:");
				stringBuilder.Append(this.class646_0[1].ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000C66 RID: 3174
		private Class646[] class646_0 = new Class646[2];
	}
}
