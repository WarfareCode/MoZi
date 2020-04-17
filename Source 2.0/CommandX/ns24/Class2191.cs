using System;
using ns25;

namespace ns24
{
	// Token: 0x02000551 RID: 1361
	public sealed class Class2191
	{
		// Token: 0x17000281 RID: 641
		public  int this[int int_1, Enum158 enum158_0]
		{
			get
			{
				return this.vmethod_0(int_1, enum158_0);
			}
			set
			{
				this.vmethod_1(int_1, enum158_0, value);
			}
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x000DF974 File Offset: 0x000DDB74
		public Class2191()
		{
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					this.int_0[i, j] = -1;
				}
			}
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x000DF9C0 File Offset: 0x000DDBC0
		public  int vmethod_0(int int_1, Enum158 enum158_0)
		{
			return this.int_0[int_1, (int)enum158_0];
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0001473D File Offset: 0x0001293D
		public  void vmethod_1(int int_1, Enum158 enum158_0, int int_2)
		{
			this.int_0[int_1, (int)enum158_0] = int_2;
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x000DF9DC File Offset: 0x000DDBDC
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"A: ",
				this.int_0[0, 1],
				", ",
				this.int_0[0, 2],
				" B: ",
				this.int_0[1, 1],
				", ",
				this.int_0[1, 2]
			});
		}

		// Token: 0x0400110A RID: 4362
		private readonly int[,] int_0 = new int[2, 3];
	}
}
