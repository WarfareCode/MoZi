using System;

namespace ns13
{
	// Token: 0x020003D3 RID: 979
	public sealed class Class623
	{
		// Token: 0x17000211 RID: 529
		public int this[int int_1, Enum140 enum140_0]
		{
			get
			{
				return this.method_0(int_1, enum140_0);
			}
			set
			{
				this.method_1(int_1, enum140_0, value);
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00096D3C File Offset: 0x00094F3C
		public Class623()
		{
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					this.int_0[i, j] = -1;
				}
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00096D88 File Offset: 0x00094F88
		public int method_0(int int_1, Enum140 enum140_0)
		{
			return this.int_0[int_1, (int)enum140_0];
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000101D1 File Offset: 0x0000E3D1
		public void method_1(int int_1, Enum140 enum140_0, int int_2)
		{
			this.int_0[int_1, (int)enum140_0] = int_2;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00096DA4 File Offset: 0x00094FA4
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"A: ",
				this.int_0[0, 1],
				",",
				this.int_0[0, 2],
				" B: ",
				this.int_0[1, 1],
				",",
				this.int_0[1, 2]
			});
		}

		// Token: 0x040009FB RID: 2555
		private int[,] int_0 = new int[2, 3];
	}
}
