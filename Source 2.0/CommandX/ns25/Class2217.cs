using System;
using System.Text;
using ns16;

namespace ns25
{
	// Token: 0x020005B6 RID: 1462
	public sealed class Class2217
	{
		// Token: 0x06002574 RID: 9588 RVA: 0x0001544B File Offset: 0x0001364B
		public Class2217(LocationType enum157_0)
		{
			this.class2224_0[0] = new Class2224(enum157_0);
			this.class2224_0[1] = new Class2224(enum157_0);
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0001547B File Offset: 0x0001367B
		public Class2217(int int_0, LocationType enum157_0)
		{
			this.class2224_0[0] = new Class2224(LocationType.Null);
			this.class2224_0[1] = new Class2224(LocationType.Null);
			this.class2224_0[int_0].vmethod_6(enum157_0);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x000154B9 File Offset: 0x000136B9
		public Class2217(LocationType enum157_0, LocationType enum157_1, LocationType enum157_2)
		{
			this.class2224_0[0] = new Class2224(enum157_0, enum157_1, enum157_2);
			this.class2224_0[1] = new Class2224(enum157_0, enum157_1, enum157_2);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000E87B8 File Offset: 0x000E69B8
		public Class2217(int int_0, LocationType enum157_0, LocationType enum157_1, LocationType enum157_2)
		{
			this.class2224_0[0] = new Class2224(LocationType.Null, LocationType.Null, LocationType.Null);
			this.class2224_0[1] = new Class2224(LocationType.Null, LocationType.Null, LocationType.Null);
			this.class2224_0[int_0].vmethod_7(enum157_0, enum157_1, enum157_2);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x000154ED File Offset: 0x000136ED
		public Class2217(Class2217 class2217_0)
		{
			this.class2224_0[0] = new Class2224(class2217_0.class2224_0[0]);
			this.class2224_0[1] = new Class2224(class2217_0.class2224_0[1]);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0001552B File Offset: 0x0001372B
		public  void vmethod_0()
		{
			this.class2224_0[0].vmethod_3();
			this.class2224_0[1].vmethod_3();
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000E8808 File Offset: 0x000E6A08
		public  LocationType vmethod_1(int int_0, Enum158 enum158_0)
		{
			return this.class2224_0[int_0].vmethod_2(enum158_0);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000E8828 File Offset: 0x000E6A28
		public  LocationType vmethod_2(int int_0)
		{
			return this.class2224_0[int_0].vmethod_2(Enum158.const_0);
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00015547 File Offset: 0x00013747
		public  void vmethod_3(int int_0, Enum158 enum158_0, LocationType enum157_0)
		{
			this.class2224_0[int_0].vmethod_5(enum158_0, enum157_0);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00015558 File Offset: 0x00013758
		public  void vmethod_4(int int_0, LocationType enum157_0)
		{
			this.class2224_0[int_0].vmethod_5(Enum158.const_0, enum157_0);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000E8848 File Offset: 0x000E6A48
		public  void vmethod_5(Class2217 class2217_0)
		{
			for (int i = 0; i < 2; i++)
			{
				if (this.class2224_0[i] == null && class2217_0.class2224_0[i] != null)
				{
					this.class2224_0[i] = new Class2224(class2217_0.class2224_0[i]);
				}
				else
				{
					this.class2224_0[i].vmethod_8(class2217_0.class2224_0[i]);
				}
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00015569 File Offset: 0x00013769
		public   bool vmethod_6(int int_0)
		{
			return this.class2224_0[int_0].vmethod_0();
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00015578 File Offset: 0x00013778
		public   bool vmethod_7()
		{
			return this.class2224_0[0].vmethod_1() || this.class2224_0[1].vmethod_1();
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00015599 File Offset: 0x00013799
		public   bool vmethod_8(int int_0)
		{
			return this.class2224_0[int_0].vmethod_1();
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000E88AC File Offset: 0x000E6AAC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.class2224_0[0] != null)
			{
				stringBuilder.Append("a:");
				stringBuilder.Append(this.class2224_0[0].ToString());
			}
			if (this.class2224_0[1] != null)
			{
				stringBuilder.Append(" b:");
				stringBuilder.Append(this.class2224_0[1].ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001206 RID: 4614
		private readonly Class2224[] class2224_0 = new Class2224[2];
	}
}
