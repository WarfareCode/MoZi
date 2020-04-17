using System;
using ns31;

namespace ns32
{
	// Token: 0x020004D5 RID: 1237
	public sealed class Class2451
	{
		// Token: 0x0600203B RID: 8251 RVA: 0x000136A7 File Offset: 0x000118A7
		public Class2451() : this(false)
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x000136B0 File Offset: 0x000118B0
		public Class2451(bool bool_2)
		{
			this.bool_1 = bool_2;
			this.class2435_0 = new Class2435();
			this.class2454_0 = new Class2454();
			this.class2455_0 = new Class2455();
			this.int_4 = (bool_2 ? 2 : 0);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000D3098 File Offset: 0x000D1298
		public void method_0()
		{
			this.int_4 = (this.bool_1 ? 2 : 0);
			this.int_10 = 0;
			this.int_11 = 0;
			this.class2454_0.method_7();
			this.class2455_0.method_7();
			this.class2445_0 = null;
			this.class2446_0 = null;
			this.class2446_1 = null;
			this.bool_0 = false;
			this.class2435_0.vmethod_0();
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000D3104 File Offset: 0x000D1304
		private bool method_1()
		{
			int num = this.class2454_0.method_0(16);
			bool result;
			if (num < 0)
			{
				result = false;
			}
			else
			{
				this.class2454_0.method_1(16);
				num = ((num << 8 | num >> 8) & 65535);
				if (num % 31 != 0)
				{
					throw new Exception30("Header checksum illegal");
				}
				if ((num & 3840) != Class2452.int_4 << 8)
				{
					throw new Exception30("Compression Method unknown");
				}
				if ((num & 32) == 0)
				{
					this.int_4 = 2;
				}
				else
				{
					this.int_4 = 1;
					this.int_6 = 32;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000D31A0 File Offset: 0x000D13A0
		private bool method_2()
		{
			bool result;
			while (this.int_6 > 0)
			{
				int num = this.class2454_0.method_0(8);
				if (num < 0)
				{
					result = false;
					return result;
				}
				this.class2454_0.method_1(8);
				this.int_5 = (this.int_5 << 8 | num);
				this.int_6 -= 8;
			}
			result = false;
			return result;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000D3204 File Offset: 0x000D1404
		private bool method_3()
		{
			int i = this.class2455_0.method_4();
			bool result;
			while (i >= 258)
			{
				int num;
				switch (this.int_4)
				{
				case 7:
					while (((num = this.class2446_0.method_1(this.class2454_0)) & -256) == 0)
					{
						this.class2455_0.method_0(num);
						if (--i < 258)
						{
							result = true;
							return result;
						}
					}
					if (num >= 257)
					{
						try
						{
							this.int_7 = Class2451.int_0[num - 257];
							this.int_6 = Class2451.int_1[num - 257];
						}
						catch (Exception)
						{
							throw new Exception30("Illegal rep length code");
						}
						goto IL_B7;
					}
					if (num < 0)
					{
						result = false;
						return result;
					}
					this.class2446_1 = null;
					this.class2446_0 = null;
					this.int_4 = 2;
					result = true;
					return result;
				case 8:
					goto IL_B7;
				case 9:
					goto IL_114;
				case 10:
					break;
				default:
					throw new Exception30("Inflater unknown mode");
				}
				IL_158:
				if (this.int_6 > 0)
				{
					this.int_4 = 10;
					int num2 = this.class2454_0.method_0(this.int_6);
					if (num2 < 0)
					{
						result = false;
						return result;
					}
					this.class2454_0.method_1(this.int_6);
					this.int_8 += num2;
				}
				this.class2455_0.method_2(this.int_7, this.int_8);
				i -= this.int_7;
				this.int_4 = 7;
				continue;
				IL_114:
				num = this.class2446_1.method_1(this.class2454_0);
				if (num >= 0)
				{
					try
					{
						this.int_8 = Class2451.int_2[num];
						this.int_6 = Class2451.int_3[num];
					}
					catch (Exception)
					{
						throw new Exception30("Illegal rep dist code");
					}
					goto IL_158;
				}
				result = false;
				return result;
				IL_B7:
				if (this.int_6 > 0)
				{
					this.int_4 = 8;
					int num3 = this.class2454_0.method_0(this.int_6);
					if (num3 < 0)
					{
						result = false;
						return result;
					}
					this.class2454_0.method_1(this.int_6);
					this.int_7 += num3;
				}
				this.int_4 = 9;
				goto IL_114;
			}
			result = true;
			return result;
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000D3458 File Offset: 0x000D1658
		private bool method_4()
		{
			bool result;
			while (this.int_6 > 0)
			{
				int num = this.class2454_0.method_0(8);
				if (num < 0)
				{
					result = false;
					return result;
				}
				this.class2454_0.method_1(8);
				this.int_5 = (this.int_5 << 8 | num);
				this.int_6 -= 8;
			}
			if ((int)this.class2435_0.Value != this.int_5)
			{
				throw new Exception30(string.Concat(new object[]
				{
					"Adler chksum doesn't match: ",
					(int)this.class2435_0.Value,
					" vs. ",
					this.int_5
				}));
			}
			this.int_4 = 12;
			result = false;
			return result;
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000D3520 File Offset: 0x000D1720
		private bool method_5()
		{
			bool result;
			switch (this.int_4)
			{
			case 0:
				result = this.method_1();
				return result;
			case 1:
				result = this.method_2();
				return result;
			case 2:
				if (this.bool_0)
				{
					if (this.bool_1)
					{
						this.int_4 = 12;
						result = false;
						return result;
					}
					this.class2454_0.method_4();
					this.int_6 = 32;
					this.int_4 = 11;
					result = true;
					return result;
				}
				else
				{
					int num = this.class2454_0.method_0(3);
					if (num < 0)
					{
						result = false;
						return result;
					}
					this.class2454_0.method_1(3);
					if ((num & 1) != 0)
					{
						this.bool_0 = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.class2454_0.method_4();
						this.int_4 = 3;
						break;
					case 1:
						this.class2446_0 = Class2446.class2446_0;
						this.class2446_1 = Class2446.class2446_1;
						this.int_4 = 7;
						break;
					case 2:
						this.class2445_0 = new Class2445();
						this.int_4 = 6;
						break;
					default:
						throw new Exception30("Unknown block type " + num);
					}
					result = true;
					return result;
				}
				break;
			case 3:
				if ((this.int_9 = this.class2454_0.method_0(16)) < 0)
				{
					result = false;
					return result;
				}
				this.class2454_0.method_1(16);
				this.int_4 = 4;
				break;
			case 4:
				break;
			case 5:
				goto IL_1E5;
			case 6:
				if (!this.class2445_0.method_0(this.class2454_0))
				{
					result = false;
					return result;
				}
				this.class2446_0 = this.class2445_0.method_1();
				this.class2446_1 = this.class2445_0.method_2();
				this.int_4 = 7;
				goto IL_277;
			case 7:
			case 8:
			case 9:
			case 10:
				goto IL_277;
			case 11:
				result = this.method_4();
				return result;
			case 12:
				result = false;
				return result;
			default:
				throw new Exception30("Inflater.Decode unknown mode");
			}
			int num2 = this.class2454_0.method_0(16);
			if (num2 < 0)
			{
				result = false;
				return result;
			}
			this.class2454_0.method_1(16);
			if (num2 != (this.int_9 ^ 65535))
			{
				throw new Exception30("broken uncompressed block");
			}
			this.int_4 = 5;
			IL_1E5:
			int num3 = this.class2455_0.method_3(this.class2454_0, this.int_9);
			this.int_9 -= num3;
			if (this.int_9 == 0)
			{
				this.int_4 = 2;
				result = true;
				return result;
			}
			result = !this.class2454_0.method_5();
			return result;
			IL_277:
			result = this.method_3();
			return result;
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000136ED File Offset: 0x000118ED
		public void method_6(byte[] byte_0, int int_12, int int_13)
		{
			this.class2454_0.method_8(byte_0, int_12, int_13);
			this.int_11 += int_13;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000D37BC File Offset: 0x000D19BC
		public int method_7(byte[] byte_0, int int_12, int int_13)
		{
			if (int_13 < 0)
			{
				throw new ArgumentOutOfRangeException("len < 0");
			}
			int result;
			if (int_13 == 0)
			{
				if (!this.method_10())
				{
					this.method_5();
				}
				result = 0;
			}
			else
			{
				int num = 0;
				while (true)
				{
					if (this.int_4 != 11)
					{
						int num2 = this.class2455_0.method_6(byte_0, int_12, int_13);
						this.class2435_0.vmethod_1(byte_0, int_12, num2);
						int_12 += num2;
						num += num2;
						this.int_10 += num2;
						int_13 -= num2;
						if (int_13 == 0)
						{
							goto Block_7;
						}
					}
					if (!this.method_5())
					{
						if (this.class2455_0.method_5() <= 0)
						{
							break;
						}
						if (this.int_4 == 11)
						{
							break;
						}
					}
				}
				goto IL_B6;
				Block_7:
				result = num;
				return result;
				IL_B6:
				result = num;
			}
			return result;
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0001370B File Offset: 0x0001190B
		public bool method_8()
		{
			return this.class2454_0.method_5();
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00013718 File Offset: 0x00011918
		public bool method_9()
		{
			return this.int_4 == 1 && this.int_6 == 0;
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0001372F File Offset: 0x0001192F
		public bool method_10()
		{
			return this.int_4 == 12 && this.class2455_0.method_5() == 0;
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000D3884 File Offset: 0x000D1A84
		public int method_11()
		{
			return this.int_10;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000D389C File Offset: 0x000D1A9C
		public int method_12()
		{
			return this.int_11 - this.method_13();
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000D38B8 File Offset: 0x000D1AB8
		public int method_13()
		{
			return this.class2454_0.method_3();
		}

		// Token: 0x04000F7A RID: 3962
		private static int[] int_0 = new int[]
		{
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			13,
			15,
			17,
			19,
			23,
			27,
			31,
			35,
			43,
			51,
			59,
			67,
			83,
			99,
			115,
			131,
			163,
			195,
			227,
			258
		};

		// Token: 0x04000F7B RID: 3963
		private static int[] int_1 = new int[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			3,
			3,
			3,
			3,
			4,
			4,
			4,
			4,
			5,
			5,
			5,
			5,
			0
		};

		// Token: 0x04000F7C RID: 3964
		private static int[] int_2 = new int[]
		{
			1,
			2,
			3,
			4,
			5,
			7,
			9,
			13,
			17,
			25,
			33,
			49,
			65,
			97,
			129,
			193,
			257,
			385,
			513,
			769,
			1025,
			1537,
			2049,
			3073,
			4097,
			6145,
			8193,
			12289,
			16385,
			24577
		};

		// Token: 0x04000F7D RID: 3965
		private static int[] int_3 = new int[]
		{
			0,
			0,
			0,
			0,
			1,
			1,
			2,
			2,
			3,
			3,
			4,
			4,
			5,
			5,
			6,
			6,
			7,
			7,
			8,
			8,
			9,
			9,
			10,
			10,
			11,
			11,
			12,
			12,
			13,
			13
		};

		// Token: 0x04000F7E RID: 3966
		private int int_4;

		// Token: 0x04000F7F RID: 3967
		private int int_5;

		// Token: 0x04000F80 RID: 3968
		private int int_6;

		// Token: 0x04000F81 RID: 3969
		private int int_7;

		// Token: 0x04000F82 RID: 3970
		private int int_8;

		// Token: 0x04000F83 RID: 3971
		private int int_9;

		// Token: 0x04000F84 RID: 3972
		private bool bool_0;

		// Token: 0x04000F85 RID: 3973
		private int int_10;

		// Token: 0x04000F86 RID: 3974
		private int int_11;

		// Token: 0x04000F87 RID: 3975
		private bool bool_1;

		// Token: 0x04000F88 RID: 3976
		private Class2454 class2454_0;

		// Token: 0x04000F89 RID: 3977
		private Class2455 class2455_0;

		// Token: 0x04000F8A RID: 3978
		private Class2445 class2445_0;

		// Token: 0x04000F8B RID: 3979
		private Class2446 class2446_0;

		// Token: 0x04000F8C RID: 3980
		private Class2446 class2446_1;

		// Token: 0x04000F8D RID: 3981
		private Class2435 class2435_0;
	}
}
