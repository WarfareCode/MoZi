using System;
using System.Text;
using GeoAPI.Geometries;

namespace ns14
{
	// Token: 0x02000481 RID: 1153
	public sealed class Class666
	{
		// Token: 0x1700023E RID: 574
		public Dimensions this[Enum143 enum143_0, Enum143 enum143_1]
		{
			get
			{
				return this.method_5(enum143_0, enum143_1);
			}
			set
			{
				this.method_0(enum143_0, enum143_1, value);
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00012409 File Offset: 0x00010609
		public Class666()
		{
			this.dimensions_0 = new Dimensions[3, 3];
			this.method_4(Dimensions.False);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00012425 File Offset: 0x00010625
		public static bool smethod_0(Dimensions dimensions_1, char char_0)
		{
			return char_0 == '*' || (char_0 == 'T' && (dimensions_1 >= Dimensions.Point || dimensions_1 == Dimensions.True)) || (char_0 == 'F' && dimensions_1 == Dimensions.False) || (char_0 == '0' && dimensions_1 == Dimensions.Point) || (char_0 == '1' && dimensions_1 == Dimensions.Curve) || (char_0 == '2' && dimensions_1 == Dimensions.Surface);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00012463 File Offset: 0x00010663
		public void method_0(Enum143 enum143_0, Enum143 enum143_1, Dimensions dimensions_1)
		{
			this.dimensions_0[(int)enum143_0, (int)enum143_1] = dimensions_1;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00012473 File Offset: 0x00010673
		public void method_1(Enum143 enum143_0, Enum143 enum143_1, Dimensions dimensions_1)
		{
			if (this.dimensions_0[(int)enum143_0, (int)enum143_1] < dimensions_1)
			{
				this.dimensions_0[(int)enum143_0, (int)enum143_1] = dimensions_1;
			}
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00012498 File Offset: 0x00010698
		public void method_2(Enum143 enum143_0, Enum143 enum143_1, Dimensions dimensions_1)
		{
			if (enum143_0 >= Enum143.const_0 && enum143_1 >= Enum143.const_0)
			{
				this.method_1(enum143_0, enum143_1, dimensions_1);
			}
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000C0700 File Offset: 0x000BE900
		public void method_3(string string_0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				int enum143_ = i / 3;
				int enum143_2 = i % 3;
				this.method_1((Enum143)enum143_, (Enum143)enum143_2, Class669.smethod_1(string_0[i]));
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000C073C File Offset: 0x000BE93C
		public void method_4(Dimensions dimensions_1)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					this.dimensions_0[i, j] = dimensions_1;
				}
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000C0774 File Offset: 0x000BE974
		public Dimensions method_5(Enum143 enum143_0, Enum143 enum143_1)
		{
			return this.dimensions_0[(int)enum143_0, (int)enum143_1];
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000C0790 File Offset: 0x000BE990
		public bool method_6(Dimensions dimensions_1, Dimensions dimensions_2)
		{
			return dimensions_1 == dimensions_2 && Class666.smethod_0(this.dimensions_0[0, 0], 'T') && this.dimensions_0[2, 0] == Dimensions.False && this.dimensions_0[0, 2] == Dimensions.False && this.dimensions_0[2, 1] == Dimensions.False && this.dimensions_0[1, 2] == Dimensions.False;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x000C07FC File Offset: 0x000BE9FC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("123456789");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					stringBuilder[3 * i + j] = Class669.smethod_0(this.dimensions_0[i, j]);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000D57 RID: 3415
		private Dimensions[,] dimensions_0;
	}
}
