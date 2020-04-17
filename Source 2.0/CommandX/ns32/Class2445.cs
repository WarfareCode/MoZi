using System;
using ns31;

namespace ns32
{
	// Token: 0x020004B3 RID: 1203
	public sealed class Class2445
	{
		// Token: 0x06001F86 RID: 8070 RVA: 0x000CF754 File Offset: 0x000CD954
		public bool method_0(Class2454 class2454_0)
		{
			while (true)
			{
				switch (this.int_2)
				{
				case 0:
					this.int_3 = class2454_0.method_0(5);
					if (this.int_3 >= 0)
					{
						this.int_3 += 257;
						class2454_0.method_1(5);
						this.int_2 = 1;
						goto IL_20A;
					}
					goto IL_2D1;
				case 1:
					goto IL_20A;
				case 2:
					goto IL_1BA;
				case 3:
					break;
				case 4:
					goto IL_AB;
				case 5:
					goto IL_06;
				default:
					continue;
				}
				IL_17F:
				while (this.int_8 < this.int_5)
				{
					int num = class2454_0.method_0(3);
					if (num < 0)
					{
						goto IL_2DD;
					}
					class2454_0.method_1(3);
					this.byte_0[Class2445.int_9[this.int_8]] = (byte)num;
					this.int_8++;
				}
				this.class2446_0 = new Class2446(this.byte_0);
				this.byte_0 = null;
				this.int_8 = 0;
				this.int_2 = 4;
				goto IL_AB;
				IL_06:
				int num2 = Class2445.int_1[this.int_7];
				int num3 = class2454_0.method_0(num2);
				if (num3 < 0)
				{
					goto IL_2EF;
				}
				class2454_0.method_1(num2);
				num3 += Class2445.int_0[this.int_7];
				if (this.int_8 + num3 > this.int_6)
				{
					break;
				}
				while (num3-- > 0)
				{
					this.byte_1[this.int_8++] = this.byte_2;
				}
				if (this.int_8 != this.int_6)
				{
					this.int_2 = 4;
					continue;
				}
				goto IL_2F9;
				IL_AB:
				int num4;
				while (((num4 = this.class2446_0.method_1(class2454_0)) & -16) == 0)
				{
					this.byte_1[this.int_8++] = (this.byte_2 = (byte)num4);
					if (this.int_8 == this.int_6)
					{
						goto IL_2EB;
					}
				}
				if (num4 >= 0)
				{
					if (num4 >= 17)
					{
						this.byte_2 = 0;
					}
					else if (this.int_8 == 0)
					{
						goto IL_2E1;
					}
					this.int_7 = num4 - 16;
					this.int_2 = 5;
					goto IL_06;
				}
				goto IL_2E7;
				IL_1BA:
				this.int_5 = class2454_0.method_0(4);
				if (this.int_5 >= 0)
				{
					this.int_5 += 4;
					class2454_0.method_1(4);
					this.byte_0 = new byte[19];
					this.int_8 = 0;
					this.int_2 = 3;
					goto IL_17F;
				}
				goto IL_2D9;
				IL_20A:
				this.int_4 = class2454_0.method_0(5);
				if (this.int_4 >= 0)
				{
					this.int_4++;
					class2454_0.method_1(5);
					this.int_6 = this.int_3 + this.int_4;
					this.byte_1 = new byte[this.int_6];
					this.int_2 = 2;
					goto IL_1BA;
				}
				goto IL_2D5;
			}
			throw new Exception30();
			IL_2D1:
			bool result = false;
			return result;
			IL_2D5:
			result = false;
			return result;
			IL_2D9:
			result = false;
			return result;
			IL_2DD:
			result = false;
			return result;
			IL_2E1:
			throw new Exception30();
			IL_2E7:
			result = false;
			return result;
			IL_2EB:
			result = true;
			return result;
			IL_2EF:
			result = false;
			return result;
			IL_2F9:
			result = true;
			return result;
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x000CFA60 File Offset: 0x000CDC60
		public Class2446 method_1()
		{
			byte[] destinationArray = new byte[this.int_3];
			Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_3);
			return new Class2446(destinationArray);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000CFA98 File Offset: 0x000CDC98
		public Class2446 method_2()
		{
			byte[] destinationArray = new byte[this.int_4];
			Array.Copy(this.byte_1, this.int_3, destinationArray, 0, this.int_4);
			return new Class2446(destinationArray);
		}

		// Token: 0x04000EBF RID: 3775
		private static readonly int[] int_0 = new int[]
		{
			3,
			3,
			11
		};

		// Token: 0x04000EC0 RID: 3776
		private static readonly int[] int_1 = new int[]
		{
			2,
			3,
			7
		};

		// Token: 0x04000EC1 RID: 3777
		private byte[] byte_0;

		// Token: 0x04000EC2 RID: 3778
		private byte[] byte_1;

		// Token: 0x04000EC3 RID: 3779
		private Class2446 class2446_0;

		// Token: 0x04000EC4 RID: 3780
		private int int_2 = 0;

		// Token: 0x04000EC5 RID: 3781
		private int int_3 = 0;

		// Token: 0x04000EC6 RID: 3782
		private int int_4;

		// Token: 0x04000EC7 RID: 3783
		private int int_5;

		// Token: 0x04000EC8 RID: 3784
		private int int_6;

		// Token: 0x04000EC9 RID: 3785
		private int int_7;

		// Token: 0x04000ECA RID: 3786
		private byte byte_2;

		// Token: 0x04000ECB RID: 3787
		private int int_8;

		// Token: 0x04000ECC RID: 3788
		private static readonly int[] int_9 = new int[]
		{
			16,
			17,
			18,
			0,
			8,
			7,
			9,
			6,
			10,
			5,
			11,
			4,
			12,
			3,
			13,
			2,
			14,
			1,
			15
		};
	}
}
