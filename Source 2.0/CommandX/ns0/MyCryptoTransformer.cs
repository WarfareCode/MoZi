using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x0200007A RID: 122
	public sealed class MyCryptoTransformer
	{
		// Token: 0x0600026D RID: 621 RVA: 0x0005B5E8 File Offset: 0x000597E8
		public static byte[] Transform(byte[] byte_0)
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] result;
			if (callingAssembly != Assembly.GetExecutingAssembly())
			{
				byte[] publicKey = executingAssembly.GetName().GetPublicKey();
				byte[] publicKey2 = callingAssembly.GetName().GetPublicKey();
				if (publicKey2 == null != (publicKey == null))
				{
					result = null;
					return result;
				}
				if (publicKey2 != null)
				{
					for (int i = 0; i < publicKey2.Length; i++)
					{
						if (publicKey2[i] != publicKey[i])
						{
							result = null;
							return result;
						}
					}
				}
			}
			MyCryptoTransformer.Stream0 stream = new MyCryptoTransformer.Stream0(byte_0);
			byte[] array = new byte[0];
			int num = stream.method_1();
			if (num == 67324752)
			{
				short num2 = (short)stream.method_0();
				int num3 = stream.method_0();
				int num4 = stream.method_0();
				if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
				{
					throw new FormatException("Wrong Header Signature");
				}
				stream.method_1();
				stream.method_1();
				stream.method_1();
				int num5 = stream.method_1();
				int num6 = stream.method_0();
				int num7 = stream.method_0();
				checked
				{
					if (num6 > 0)
					{
						byte[] buffer = new byte[(uint)num6];
						stream.Read(buffer, 0, num6);
					}
					if (num7 > 0)
					{
						byte[] buffer2 = new byte[(uint)num7];
						stream.Read(buffer2, 0, num7);
					}
					byte[] array2 = new byte[(uint)(unchecked(stream.Length - stream.Position))];
					stream.Read(array2, 0, array2.Length);
					MyCryptoTransformer.Class3 @class = new MyCryptoTransformer.Class3(array2);
					array = new byte[(uint)num5];
					@class.method_2(array, 0, array.Length);
				}
			}
			else
			{
				int num8 = num >> 24;
				num -= num8 << 24;
				if (num != 8223355)
				{
					throw new FormatException("Unknown Header");
				}
				if (num8 == 1)
				{
					int num9 = stream.method_1();
					array = new byte[checked((uint)num9)];
					int num11;
					for (int j = 0; j < num9; j += num11)
					{
						int num10 = stream.method_1();
						num11 = stream.method_1();
						byte[] array3 = new byte[checked((uint)num10)];
						stream.Read(array3, 0, array3.Length);
						MyCryptoTransformer.Class3 class2 = new MyCryptoTransformer.Class3(array3);
						class2.method_2(array, j, num11);
					}
				}
				if (num8 == 2)
				{
					MyDESCryptoServiceProvider myDESCryptoServiceProvider = new MyDESCryptoServiceProvider();
					byte[] byte_ = new byte[]
					{
						218,
						32,
						42,
						92,
						234,
						19,
						77,
						235
					};
					byte[] byte_2 = new byte[]
					{
						38,
						210,
						92,
						128,
						217,
						62,
						93,
						110
					};
					ICryptoTransform cryptoTransform = myDESCryptoServiceProvider.CreateCryptoTransform(byte_, byte_2, true);
					byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
					myDESCryptoServiceProvider.Clear();
					array = MyCryptoTransformer.Transform(byte_3);
				}
				if (num8 == 3)
				{
					MyCryptography myCryptography = new MyCryptography();
					byte[] byte_4 = new byte[]
					{
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1,
						1
					};
					byte[] byte_5 = new byte[]
					{
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2,
						2
					};
					ICryptoTransform cryptoTransform2 = myCryptography.CreateCryptoTransform(byte_4, byte_5, true);
					byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
					myCryptography.Clear();
					array = MyCryptoTransformer.Transform(byte_6);
				}
			}
			stream.Close();
			result = array;
			return result;
		}

		// Token: 0x0200007B RID: 123
		public sealed class Class3
		{
			// Token: 0x0600026F RID: 623 RVA: 0x00005A23 File Offset: 0x00003C23
			public Class3(byte[] byte_0)
			{
				this.class4_0 = new MyCryptoTransformer.Class4();
				this.class5_0 = new MyCryptoTransformer.Class5();
				this.int_4 = 2;
				this.class4_0.method_7(byte_0, 0, byte_0.Length);
			}

			// Token: 0x06000270 RID: 624 RVA: 0x0005B928 File Offset: 0x00059B28
			private bool method_0()
			{
				int i = this.class5_0.method_4();
				bool result;
				while (i >= 258)
				{
					int num;
					switch (this.int_4)
					{
					case 7:
						while (((num = this.class6_0.method_1(this.class4_0)) & -256) == 0)
						{
							this.class5_0.method_0(num);
							if (--i < 258)
							{
								result = true;
								return result;
							}
						}
						if (num >= 257)
						{
							this.int_6 = MyCryptoTransformer.Class3.int_0[num - 257];
							this.int_5 = MyCryptoTransformer.Class3.int_1[num - 257];
							goto IL_A8;
						}
						if (num < 0)
						{
							result = false;
							return result;
						}
						this.class6_1 = null;
						this.class6_0 = null;
						this.int_4 = 2;
						result = true;
						return result;
					case 8:
						goto IL_A8;
					case 9:
						goto IL_105;
					case 10:
						break;
					default:
						continue;
					}
					IL_13A:
					if (this.int_5 > 0)
					{
						this.int_4 = 10;
						int num2 = this.class4_0.method_0(this.int_5);
						if (num2 < 0)
						{
							result = false;
							return result;
						}
						this.class4_0.method_1(this.int_5);
						this.int_7 += num2;
					}
					this.class5_0.method_2(this.int_6, this.int_7);
					i -= this.int_6;
					this.int_4 = 7;
					continue;
					IL_105:
					num = this.class6_1.method_1(this.class4_0);
					if (num >= 0)
					{
						this.int_7 = MyCryptoTransformer.Class3.int_2[num];
						this.int_5 = MyCryptoTransformer.Class3.int_3[num];
						goto IL_13A;
					}
					result = false;
					return result;
					IL_A8:
					if (this.int_5 > 0)
					{
						this.int_4 = 8;
						int num3 = this.class4_0.method_0(this.int_5);
						if (num3 < 0)
						{
							result = false;
							return result;
						}
						this.class4_0.method_1(this.int_5);
						this.int_6 += num3;
					}
					this.int_4 = 9;
					goto IL_105;
				}
				result = true;
				return result;
			}

			// Token: 0x06000271 RID: 625 RVA: 0x0005BB38 File Offset: 0x00059D38
			private bool method_1()
			{
				bool result;
				switch (this.int_4)
				{
				case 2:
				{
					if (this.bool_0)
					{
						this.int_4 = 12;
						result = false;
						return result;
					}
					int num = this.class4_0.method_0(3);
					if (num < 0)
					{
						result = false;
						return result;
					}
					this.class4_0.method_1(3);
					if ((num & 1) != 0)
					{
						this.bool_0 = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.class4_0.method_4();
						this.int_4 = 3;
						break;
					case 1:
						this.class6_0 = MyCryptoTransformer.Class6.class6_0;
						this.class6_1 = MyCryptoTransformer.Class6.class6_1;
						this.int_4 = 7;
						break;
					case 2:
						this.class7_0 = new MyCryptoTransformer.Class7();
						this.int_4 = 6;
						break;
					}
					result = true;
					return result;
				}
				case 3:
					if ((this.int_8 = this.class4_0.method_0(16)) < 0)
					{
						result = false;
						return result;
					}
					this.class4_0.method_1(16);
					this.int_4 = 4;
					break;
				case 4:
					break;
				case 5:
					goto IL_165;
				case 6:
					if (!this.class7_0.method_0(this.class4_0))
					{
						result = false;
						return result;
					}
					this.class6_0 = this.class7_0.method_1();
					this.class6_1 = this.class7_0.method_2();
					this.int_4 = 7;
					goto IL_1F7;
				case 7:
				case 8:
				case 9:
				case 10:
					goto IL_1F7;
				case 11:
					result = false;
					return result;
				case 12:
					result = false;
					return result;
				default:
					result = false;
					return result;
				}
				int num2 = this.class4_0.method_0(16);
				if (num2 < 0)
				{
					result = false;
					return result;
				}
				this.class4_0.method_1(16);
				this.int_4 = 5;
				IL_165:
				int num3 = this.class5_0.method_3(this.class4_0, this.int_8);
				this.int_8 -= num3;
				if (this.int_8 == 0)
				{
					this.int_4 = 2;
					result = true;
					return result;
				}
				result = !this.class4_0.method_5();
				return result;
				IL_1F7:
				result = this.method_0();
				return result;
			}

			// Token: 0x06000272 RID: 626 RVA: 0x0005BD4C File Offset: 0x00059F4C
			public int method_2(byte[] byte_0, int int_9, int int_10)
			{
				int num = 0;
				while (true)
				{
					if (this.int_4 != 11)
					{
						int num2 = this.class5_0.method_6(byte_0, int_9, int_10);
						int_9 += num2;
						num += num2;
						int_10 -= num2;
						if (int_10 == 0)
						{
							goto Block_4;
						}
					}
					if (!this.method_1())
					{
						if (this.class5_0.method_5() <= 0)
						{
							break;
						}
						if (this.int_4 == 11)
						{
							break;
						}
					}
				}
				goto IL_67;
				Block_4:
				int result = num;
				return result;
				IL_67:
				result = num;
				return result;
			}

			// Token: 0x04000161 RID: 353
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

			// Token: 0x04000162 RID: 354
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

			// Token: 0x04000163 RID: 355
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

			// Token: 0x04000164 RID: 356
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

			// Token: 0x04000165 RID: 357
			private int int_4;

			// Token: 0x04000166 RID: 358
			private int int_5;

			// Token: 0x04000167 RID: 359
			private int int_6;

			// Token: 0x04000168 RID: 360
			private int int_7;

			// Token: 0x04000169 RID: 361
			private int int_8;

			// Token: 0x0400016A RID: 362
			private bool bool_0;

			// Token: 0x0400016B RID: 363
			private MyCryptoTransformer.Class4 class4_0;

			// Token: 0x0400016C RID: 364
			private MyCryptoTransformer.Class5 class5_0;

			// Token: 0x0400016D RID: 365
			private MyCryptoTransformer.Class7 class7_0;

			// Token: 0x0400016E RID: 366
			private MyCryptoTransformer.Class6 class6_0;

			// Token: 0x0400016F RID: 367
			private MyCryptoTransformer.Class6 class6_1;
		}

		// Token: 0x0200007C RID: 124
		public sealed class Class4
		{
			// Token: 0x06000274 RID: 628 RVA: 0x0005BE30 File Offset: 0x0005A030
			public int method_0(int int_3)
			{
				int result;
				if (this.int_2 < int_3)
				{
					if (this.int_0 == this.int_1)
					{
						result = -1;
						return result;
					}
					this.uint_0 |= (uint)((uint)((int)(this.byte_0[this.int_0++] & 255) | (int)(this.byte_0[this.int_0++] & 255) << 8) << this.int_2);
					this.int_2 += 16;
				}
				result = (int)((ulong)this.uint_0 & (ulong)((long)((1 << int_3) - 1)));
				return result;
			}

			// Token: 0x06000275 RID: 629 RVA: 0x00005A58 File Offset: 0x00003C58
			public void method_1(int int_3)
			{
				this.uint_0 >>= int_3;
				this.int_2 -= int_3;
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0005BEDC File Offset: 0x0005A0DC
			public int method_2()
			{
				return this.int_2;
			}

			// Token: 0x06000277 RID: 631 RVA: 0x0005BEF4 File Offset: 0x0005A0F4
			public int method_3()
			{
				return this.int_1 - this.int_0 + (this.int_2 >> 3);
			}

			// Token: 0x06000278 RID: 632 RVA: 0x00005A79 File Offset: 0x00003C79
			public void method_4()
			{
				this.uint_0 >>= (this.int_2 & 7);
				this.int_2 &= -8;
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00005AA2 File Offset: 0x00003CA2
			public bool method_5()
			{
				return this.int_0 == this.int_1;
			}

			// Token: 0x0600027A RID: 634 RVA: 0x0005BF1C File Offset: 0x0005A11C
			public int method_6(byte[] byte_1, int int_3, int int_4)
			{
				int num = 0;
				while (this.int_2 > 0 && int_4 > 0)
				{
					byte_1[int_3++] = (byte)this.uint_0;
					this.uint_0 >>= 8;
					this.int_2 -= 8;
					int_4--;
					num++;
				}
				int result;
				if (int_4 == 0)
				{
					result = num;
				}
				else
				{
					int num2 = this.int_1 - this.int_0;
					if (int_4 > num2)
					{
						int_4 = num2;
					}
					Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
					this.int_0 += int_4;
					if ((this.int_0 - this.int_1 & 1) != 0)
					{
						this.uint_0 = (uint)(this.byte_0[this.int_0++] & 255);
						this.int_2 = 8;
					}
					result = num + int_4;
				}
				return result;
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0005C004 File Offset: 0x0005A204
			public void method_7(byte[] byte_1, int int_3, int int_4)
			{
				if (this.int_0 < this.int_1)
				{
					throw new InvalidOperationException();
				}
				int num = int_3 + int_4;
				if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
				{
					if ((int_4 & 1) != 0)
					{
						this.uint_0 |= (uint)((uint)(byte_1[int_3++] & 255) << this.int_2);
						this.int_2 += 8;
					}
					this.byte_0 = byte_1;
					this.int_0 = int_3;
					this.int_1 = num;
					return;
				}
				throw new ArgumentOutOfRangeException();
			}

			// Token: 0x04000170 RID: 368
			private byte[] byte_0;

			// Token: 0x04000171 RID: 369
			private int int_0 = 0;

			// Token: 0x04000172 RID: 370
			private int int_1 = 0;

			// Token: 0x04000173 RID: 371
			private uint uint_0 = 0u;

			// Token: 0x04000174 RID: 372
			private int int_2 = 0;
		}

		// Token: 0x0200007D RID: 125
		public sealed class Class5
		{
			// Token: 0x0600027D RID: 637 RVA: 0x0005C09C File Offset: 0x0005A29C
			public void method_0(int int_4)
			{
				if (this.int_3++ == MyCryptoTransformer.Class5.int_0)
				{
					throw new InvalidOperationException();
				}
				this.byte_0[this.int_2++] = (byte)int_4;
				this.int_2 &= MyCryptoTransformer.Class5.int_1;
			}

			// Token: 0x0600027E RID: 638 RVA: 0x0005C0F8 File Offset: 0x0005A2F8
			private void method_1(int int_4, int int_5, int int_6)
			{
				while (int_5-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[int_4++];
					this.int_2 &= MyCryptoTransformer.Class5.int_1;
					int_4 &= MyCryptoTransformer.Class5.int_1;
				}
			}

			// Token: 0x0600027F RID: 639 RVA: 0x0005C154 File Offset: 0x0005A354
			public void method_2(int int_4, int int_5)
			{
				if ((this.int_3 += int_4) > MyCryptoTransformer.Class5.int_0)
				{
					throw new InvalidOperationException();
				}
				int num = this.int_2 - int_5 & MyCryptoTransformer.Class5.int_1;
				int num2 = MyCryptoTransformer.Class5.int_0 - int_4;
				if (num > num2 || this.int_2 >= num2)
				{
					this.method_1(num, int_4, int_5);
				}
				else if (int_4 <= int_5)
				{
					Array.Copy(this.byte_0, num, this.byte_0, this.int_2, int_4);
					this.int_2 += int_4;
				}
				else
				{
					while (int_4-- > 0)
					{
						this.byte_0[this.int_2++] = this.byte_0[num++];
					}
				}
			}

			// Token: 0x06000280 RID: 640 RVA: 0x0005C218 File Offset: 0x0005A418
			public int method_3(MyCryptoTransformer.Class4 class4_0, int int_4)
			{
				int_4 = Math.Min(Math.Min(int_4, MyCryptoTransformer.Class5.int_0 - this.int_3), class4_0.method_3());
				int num = MyCryptoTransformer.Class5.int_0 - this.int_2;
				int num2;
				if (int_4 > num)
				{
					num2 = class4_0.method_6(this.byte_0, this.int_2, num);
					if (num2 == num)
					{
						num2 += class4_0.method_6(this.byte_0, 0, int_4 - num);
					}
				}
				else
				{
					num2 = class4_0.method_6(this.byte_0, this.int_2, int_4);
				}
				this.int_2 = (this.int_2 + num2 & MyCryptoTransformer.Class5.int_1);
				this.int_3 += num2;
				return num2;
			}

			// Token: 0x06000281 RID: 641 RVA: 0x0005C2C8 File Offset: 0x0005A4C8
			public int method_4()
			{
				return MyCryptoTransformer.Class5.int_0 - this.int_3;
			}

			// Token: 0x06000282 RID: 642 RVA: 0x0005C2E4 File Offset: 0x0005A4E4
			public int method_5()
			{
				return this.int_3;
			}

			// Token: 0x06000283 RID: 643 RVA: 0x0005C2FC File Offset: 0x0005A4FC
			public int method_6(byte[] byte_1, int int_4, int int_5)
			{
				int num = this.int_2;
				if (int_5 > this.int_3)
				{
					int_5 = this.int_3;
				}
				else
				{
					num = (this.int_2 - this.int_3 + int_5 & MyCryptoTransformer.Class5.int_1);
				}
				int num2 = int_5;
				int num3 = int_5 - num;
				if (num3 > 0)
				{
					Array.Copy(this.byte_0, MyCryptoTransformer.Class5.int_0 - num3, byte_1, int_4, num3);
					int_4 += num3;
					int_5 = num;
				}
				Array.Copy(this.byte_0, num - int_5, byte_1, int_4, int_5);
				this.int_3 -= num2;
				if (this.int_3 < 0)
				{
					throw new InvalidOperationException();
				}
				return num2;
			}

			// Token: 0x04000175 RID: 373
			private static int int_0 = 32768;

			// Token: 0x04000176 RID: 374
			private static int int_1 = MyCryptoTransformer.Class5.int_0 - 1;

			// Token: 0x04000177 RID: 375
			private byte[] byte_0 = new byte[checked((uint)MyCryptoTransformer.Class5.int_0)];

			// Token: 0x04000178 RID: 376
			private int int_2 = 0;

			// Token: 0x04000179 RID: 377
			private int int_3 = 0;
		}

		// Token: 0x0200007E RID: 126
		public sealed class Class6
		{
			// Token: 0x06000286 RID: 646 RVA: 0x0005C3A0 File Offset: 0x0005A5A0
			static Class6()
			{
				byte[] array = new byte[288];
				int i = 0;
				while (i < 144)
				{
					array[i++] = 8;
				}
				while (i < 256)
				{
					array[i++] = 9;
				}
				while (i < 280)
				{
					array[i++] = 7;
				}
				while (i < 288)
				{
					array[i++] = 8;
				}
				MyCryptoTransformer.Class6.class6_0 = new MyCryptoTransformer.Class6(array);
				array = new byte[32];
				i = 0;
				while (i < 32)
				{
					array[i++] = 5;
				}
				MyCryptoTransformer.Class6.class6_1 = new MyCryptoTransformer.Class6(array);
			}

			// Token: 0x06000287 RID: 647 RVA: 0x00005B16 File Offset: 0x00003D16
			public Class6(byte[] byte_0)
			{
				this.method_0(byte_0);
			}

			// Token: 0x06000288 RID: 648 RVA: 0x0005C444 File Offset: 0x0005A644
			private void method_0(byte[] byte_0)
			{
				int[] array;
				int[] array2;
				checked
				{
					array = new int[(uint)(unchecked(MyCryptoTransformer.Class6.int_0 + 1))];
					array2 = new int[(uint)(unchecked(MyCryptoTransformer.Class6.int_0 + 1))];
				}
				for (int i = 0; i < byte_0.Length; i++)
				{
					int num = (int)byte_0[i];
					if (num > 0)
					{
						int[] array3;
						IntPtr value;
						(array3 = array)[(int)(value = (IntPtr)num)] = array3[(int)value] + 1;
					}
				}
				int num2 = 0;
				int num3 = 512;
				for (int j = 1; j <= MyCryptoTransformer.Class6.int_0; j++)
				{
					array2[j] = num2;
					num2 += array[j] << 16 - j;
					if (j >= 10)
					{
						int num4 = array2[j] & 130944;
						int num5 = num2 & 130944;
						num3 += num5 - num4 >> 16 - j;
					}
				}
				this.short_0 = new short[checked((uint)num3)];
				int num6 = 512;
				for (int k = MyCryptoTransformer.Class6.int_0; k >= 10; k--)
				{
					int num7 = num2 & 130944;
					num2 -= array[k] << 16 - k;
					int num8 = num2 & 130944;
					for (int l = num8; l < num7; l += 128)
					{
						this.short_0[(int)MyCryptoTransformer.Class8.smethod_0(l)] = (short)(-num6 << 4 | k);
						num6 += 1 << k - 9;
					}
				}
				for (int m = 0; m < byte_0.Length; m++)
				{
					int num9 = (int)byte_0[m];
					if (num9 != 0)
					{
						num2 = array2[num9];
						int num10 = (int)MyCryptoTransformer.Class8.smethod_0(num2);
						if (num9 <= 9)
						{
							do
							{
								this.short_0[num10] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < 512);
						}
						else
						{
							int num11 = (int)this.short_0[num10 & 511];
							int num12 = 1 << (num11 & 15);
							num11 = -(num11 >> 4);
							do
							{
								this.short_0[num11 | num10 >> 9] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < num12);
						}
						array2[num9] = num2 + (1 << 16 - num9);
					}
				}
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0005C678 File Offset: 0x0005A878
			public int method_1(MyCryptoTransformer.Class4 class4_0)
			{
				int num;
				int result;
				if ((num = class4_0.method_0(9)) >= 0)
				{
					int num2;
					if ((num2 = (int)this.short_0[num]) >= 0)
					{
						class4_0.method_1(num2 & 15);
						result = num2 >> 4;
					}
					else
					{
						int num3 = -(num2 >> 4);
						int int_ = num2 & 15;
						if ((num = class4_0.method_0(int_)) >= 0)
						{
							num2 = (int)this.short_0[num3 | num >> 9];
							class4_0.method_1(num2 & 15);
							result = num2 >> 4;
						}
						else
						{
							int num4 = class4_0.method_2();
							num = class4_0.method_0(num4);
							num2 = (int)this.short_0[num3 | num >> 9];
							if ((num2 & 15) <= num4)
							{
								class4_0.method_1(num2 & 15);
								result = num2 >> 4;
							}
							else
							{
								result = -1;
							}
						}
					}
				}
				else
				{
					int num5 = class4_0.method_2();
					num = class4_0.method_0(num5);
					int num2 = (int)this.short_0[num];
					if (num2 >= 0 && (num2 & 15) <= num5)
					{
						class4_0.method_1(num2 & 15);
						result = num2 >> 4;
					}
					else
					{
						result = -1;
					}
				}
				return result;
			}

			// Token: 0x0400017A RID: 378
			private static int int_0 = 15;

			// Token: 0x0400017B RID: 379
			private short[] short_0;

			// Token: 0x0400017C RID: 380
			public static MyCryptoTransformer.Class6 class6_0;

			// Token: 0x0400017D RID: 381
			public static MyCryptoTransformer.Class6 class6_1;
		}

		// Token: 0x0200007F RID: 127
		public sealed class Class7
		{
			// Token: 0x0600028A RID: 650 RVA: 0x0005C770 File Offset: 0x0005A970
			public bool method_0(MyCryptoTransformer.Class4 class4_0)
			{
				while (true)
				{
					switch (this.int_2)
					{
					case 0:
						this.int_3 = class4_0.method_0(5);
						if (this.int_3 >= 0)
						{
							this.int_3 += 257;
							class4_0.method_1(5);
							this.int_2 = 1;
							goto IL_1DE;
						}
						goto IL_2A7;
					case 1:
						goto IL_1DE;
					case 2:
						goto IL_18E;
					case 3:
						break;
					case 4:
						goto IL_92;
					case 5:
						goto IL_06;
					default:
						continue;
					}
					IL_153:
					while (this.int_8 < this.int_5)
					{
						int num = class4_0.method_0(3);
						if (num < 0)
						{
							goto IL_2B3;
						}
						class4_0.method_1(3);
						this.byte_0[MyCryptoTransformer.Class7.int_9[this.int_8]] = (byte)num;
						this.int_8++;
					}
					this.class6_0 = new MyCryptoTransformer.Class6(this.byte_0);
					this.byte_0 = null;
					this.int_8 = 0;
					this.int_2 = 4;
					goto IL_92;
					IL_06:
					int num2 = MyCryptoTransformer.Class7.int_1[this.int_7];
					int num3 = class4_0.method_0(num2);
					if (num3 < 0)
					{
						goto IL_2BF;
					}
					class4_0.method_1(num2);
					num3 += MyCryptoTransformer.Class7.int_0[this.int_7];
					while (num3-- > 0)
					{
						this.byte_1[this.int_8++] = this.byte_2;
					}
					if (this.int_8 != this.int_6)
					{
						this.int_2 = 4;
						continue;
					}
					goto IL_2C3;
					IL_92:
					int num4;
					while (((num4 = this.class6_0.method_1(class4_0)) & -16) == 0)
					{
						this.byte_1[this.int_8++] = (this.byte_2 = (byte)num4);
						if (this.int_8 == this.int_6)
						{
							goto IL_2BB;
						}
					}
					if (num4 >= 0)
					{
						if (num4 >= 17)
						{
							this.byte_2 = 0;
						}
						this.int_7 = num4 - 16;
						this.int_2 = 5;
						goto IL_06;
					}
					goto IL_2B7;
					IL_18E:
					this.int_5 = class4_0.method_0(4);
					if (this.int_5 >= 0)
					{
						this.int_5 += 4;
						class4_0.method_1(4);
						this.byte_0 = new byte[19];
						this.int_8 = 0;
						this.int_2 = 3;
						goto IL_153;
					}
					goto IL_2AF;
					IL_1DE:
					this.int_4 = class4_0.method_0(5);
					if (this.int_4 >= 0)
					{
						this.int_4++;
						class4_0.method_1(5);
						this.int_6 = this.int_3 + this.int_4;
						this.byte_1 = new byte[checked((uint)this.int_6)];
						this.int_2 = 2;
						goto IL_18E;
					}
					goto IL_2AB;
				}
				IL_2A7:
				bool result = false;
				return result;
				IL_2AB:
				result = false;
				return result;
				IL_2AF:
				result = false;
				return result;
				IL_2B3:
				result = false;
				return result;
				IL_2B7:
				result = false;
				return result;
				IL_2BB:
				result = true;
				return result;
				IL_2BF:
				result = false;
				return result;
				IL_2C3:
				result = true;
				return result;
			}

			// Token: 0x0600028B RID: 651 RVA: 0x0005CA44 File Offset: 0x0005AC44
			public MyCryptoTransformer.Class6 method_1()
			{
				byte[] destinationArray = new byte[checked((uint)this.int_3)];
				Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_3);
				return new MyCryptoTransformer.Class6(destinationArray);
			}

			// Token: 0x0600028C RID: 652 RVA: 0x0005CA7C File Offset: 0x0005AC7C
			public MyCryptoTransformer.Class6 method_2()
			{
				byte[] destinationArray = new byte[checked((uint)this.int_4)];
				Array.Copy(this.byte_1, this.int_3, destinationArray, 0, this.int_4);
				return new MyCryptoTransformer.Class6(destinationArray);
			}

			// Token: 0x0400017E RID: 382
			private static readonly int[] int_0 = new int[]
			{
				3,
				3,
				11
			};

			// Token: 0x0400017F RID: 383
			private static readonly int[] int_1 = new int[]
			{
				2,
				3,
				7
			};

			// Token: 0x04000180 RID: 384
			private byte[] byte_0;

			// Token: 0x04000181 RID: 385
			private byte[] byte_1;

			// Token: 0x04000182 RID: 386
			private MyCryptoTransformer.Class6 class6_0;

			// Token: 0x04000183 RID: 387
			private int int_2 = 0;

			// Token: 0x04000184 RID: 388
			private int int_3 = 0;

			// Token: 0x04000185 RID: 389
			private int int_4;

			// Token: 0x04000186 RID: 390
			private int int_5;

			// Token: 0x04000187 RID: 391
			private int int_6;

			// Token: 0x04000188 RID: 392
			private int int_7;

			// Token: 0x04000189 RID: 393
			private byte byte_2;

			// Token: 0x0400018A RID: 394
			private int int_8;

			// Token: 0x0400018B RID: 395
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

		// Token: 0x02000080 RID: 128
		public sealed class Class8
		{
			// Token: 0x0600028F RID: 655 RVA: 0x0005CB08 File Offset: 0x0005AD08
			public static short smethod_0(int int_9)
			{
				return (short)((int)MyCryptoTransformer.Class8.byte_0[int_9 & 15] << 12 | (int)MyCryptoTransformer.Class8.byte_0[int_9 >> 4 & 15] << 8 | (int)MyCryptoTransformer.Class8.byte_0[int_9 >> 8 & 15] << 4 | (int)MyCryptoTransformer.Class8.byte_0[int_9 >> 12]);
			}

			// Token: 0x06000290 RID: 656 RVA: 0x0005CB50 File Offset: 0x0005AD50
			static Class8()
			{
				int i;
				checked
				{
					MyCryptoTransformer.Class8.short_0 = new short[(uint)MyCryptoTransformer.Class8.int_1];
					MyCryptoTransformer.Class8.byte_1 = new byte[(uint)MyCryptoTransformer.Class8.int_1];
					i = 0;
				}
				while (i < 144)
				{
					MyCryptoTransformer.Class8.short_0[i] = MyCryptoTransformer.Class8.smethod_0(48 + i << 8);
					MyCryptoTransformer.Class8.byte_1[i++] = 8;
				}
				while (i < 256)
				{
					MyCryptoTransformer.Class8.short_0[i] = MyCryptoTransformer.Class8.smethod_0(256 + i << 7);
					MyCryptoTransformer.Class8.byte_1[i++] = 9;
				}
				while (i < 280)
				{
					MyCryptoTransformer.Class8.short_0[i] = MyCryptoTransformer.Class8.smethod_0(-256 + i << 9);
					MyCryptoTransformer.Class8.byte_1[i++] = 7;
				}
				while (i < MyCryptoTransformer.Class8.int_1)
				{
					MyCryptoTransformer.Class8.short_0[i] = MyCryptoTransformer.Class8.smethod_0(-88 + i << 8);
					MyCryptoTransformer.Class8.byte_1[i++] = 8;
				}
				checked
				{
					MyCryptoTransformer.Class8.short_1 = new short[(uint)MyCryptoTransformer.Class8.int_2];
					MyCryptoTransformer.Class8.byte_2 = new byte[(uint)MyCryptoTransformer.Class8.int_2];
				}
				for (i = 0; i < MyCryptoTransformer.Class8.int_2; i++)
				{
					MyCryptoTransformer.Class8.short_1[i] = MyCryptoTransformer.Class8.smethod_0(i << 11);
					MyCryptoTransformer.Class8.byte_2[i] = 5;
				}
			}

			// Token: 0x0400018C RID: 396
			private static int int_0 = 16384;

			// Token: 0x0400018D RID: 397
			private static int int_1 = 286;

			// Token: 0x0400018E RID: 398
			private static int int_2 = 30;

			// Token: 0x0400018F RID: 399
			private static int int_3 = 19;

			// Token: 0x04000190 RID: 400
			private static int int_4 = 16;

			// Token: 0x04000191 RID: 401
			private static int int_5 = 17;

			// Token: 0x04000192 RID: 402
			private static int int_6 = 18;

			// Token: 0x04000193 RID: 403
			private static int int_7 = 256;

			// Token: 0x04000194 RID: 404
			private static int[] int_8 = new int[]
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

			// Token: 0x04000195 RID: 405
			private static byte[] byte_0 = new byte[]
			{
				0,
				8,
				4,
				12,
				2,
				10,
				6,
				14,
				1,
				9,
				5,
				13,
				3,
				11,
				7,
				15
			};

			// Token: 0x04000196 RID: 406
			private static short[] short_0;

			// Token: 0x04000197 RID: 407
			private static byte[] byte_1;

			// Token: 0x04000198 RID: 408
			private static short[] short_1;

			// Token: 0x04000199 RID: 409
			private static byte[] byte_2;
		}

		// Token: 0x02000081 RID: 129
		public sealed class Stream0 : MemoryStream
		{
			// Token: 0x06000292 RID: 658 RVA: 0x0005CCF8 File Offset: 0x0005AEF8
			public int method_0()
			{
				return this.ReadByte() | this.ReadByte() << 8;
			}

			// Token: 0x06000293 RID: 659 RVA: 0x0005CD18 File Offset: 0x0005AF18
			public int method_1()
			{
				return this.method_0() | this.method_0() << 16;
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00005B3B File Offset: 0x00003D3B
			public Stream0(byte[] byte_0) : base(byte_0, false)
			{
			}
		}
	}
}
