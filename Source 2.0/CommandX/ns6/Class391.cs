using System;

namespace ns6
{
	// Token: 0x02000C95 RID: 3221
	public sealed class Class391
	{
		// Token: 0x06006ABF RID: 27327 RVA: 0x003A0954 File Offset: 0x0039EB54
		public Class391()
		{
			this.int_10 = new int[640];
			this.int_11 = new int[128];
			this.int_12 = new int[40];
			this.int_13 = new int[320];
			this.int_14 = new int[15];
			this.int_15 = new int[15];
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x003A09CC File Offset: 0x0039EBCC
		private unsafe int method_0(int int_16)
		{
			int num = this.int_3;
			int i = this.int_4;
			while (i < int_16)
			{
				if (i < 8 && this.int_0 < this.int_1)
				{
					this.int_0 += 3;
					num |= ((int)(*this.pByte_0) | (int)this.pByte_0[1] << 8 | (int)this.pByte_0[2] << 16) << i;
					this.pByte_0 += 3;
					i += 24;
				}
				else if (this.int_0 < this.int_2)
				{
					this.int_0++;
					num |= (int)(*this.pByte_0) << i;
					this.pByte_0++;
					i += 8;
				}
				else
				{
					Exception3.smethod_2();
				}
			}
			this.int_3 = num >> int_16;
			this.int_4 = i - int_16;
			return num & (1 << int_16) - 1;
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x003A0AC8 File Offset: 0x0039ECC8
		private unsafe int method_1()
		{
			uint num = (uint)this.int_3;
			int num2 = this.int_4;
			if (num2 != 0)
			{
				num2--;
			}
			else if (this.int_0 < this.int_1)
			{
				this.int_0 += 4;
				num = *(uint*)this.pByte_0;
				this.pByte_0 += 4;
				num2 = 31;
			}
			else if (this.int_0 < this.int_2)
			{
				this.int_0++;
				num = (uint)(*this.pByte_0);
				this.pByte_0++;
				num2 = 7;
			}
			else
			{
				Exception3.smethod_2();
			}
			this.int_3 = (int)(num >> 1);
			this.int_4 = num2;
			return (int)(num & 1u);
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x003A0B84 File Offset: 0x0039ED84
		private unsafe int method_2(int* pInt_10)
		{
			int num = 1;
			int num2 = this.int_3;
			while (true)
			{
				if (this.int_4 == 0)
				{
					if (this.int_0 < this.int_1)
					{
						this.int_0 += 4;
						num2 = *(int*)this.pByte_0;
						this.pByte_0 += 4;
						num = pInt_10[num + (num2 & 1)];
						num2 = (int)((uint)num2 >> 1);
						this.int_4 = 31;
					}
					else if (this.int_0 < this.int_2)
					{
						this.int_0++;
						num2 = (int)(*this.pByte_0);
						this.pByte_0++;
						num = pInt_10[num + (num2 & 1)];
						num2 >>= 1;
						this.int_4 = 7;
					}
					else
					{
						Exception3.smethod_2();
					}
					if (num <= 0)
					{
						break;
					}
				}
				else
				{
					num = pInt_10[num + (num2 & 1)];
					num2 >>= 1;
					this.int_4--;
					if (num <= 0)
					{
						break;
					}
				}
			}
			this.int_3 = num2;
			return -num;
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x003A0C9C File Offset: 0x0039EE9C
		private unsafe void method_3()
		{
			Class390.smethod_2(0, this.pInt_4, 8);
			int num;
			for (int i = 0; i < 20; i++)
			{
				num = this.method_0(3);
				this.pInt_3[i] = num;
				this.pInt_4[num]++;
			}
			Class390.smethod_2(0, this.pInt_2, 40);
			this.pInt_5[1] = 0;
			num = (this.pInt_5[2] = this.pInt_4[1] << 1);
			num = (this.pInt_5[3] = num + this.pInt_4[2] << 1);
			num = (this.pInt_5[4] = num + this.pInt_4[3] << 1);
			num = (this.pInt_5[5] = num + this.pInt_4[4] << 1);
			num = (this.pInt_5[6] = num + this.pInt_4[5] << 1);
			this.pInt_5[7] = num + this.pInt_4[6] << 1;
			int num2 = 2;
			for (int i = 0; i < 20; i++)
			{
				num = this.pInt_3[i];
				if (num != 0)
				{
					int num3 = this.pInt_5[num];
					int num4 = (int)Class390.smethod_0((uint)num3, num);
					this.pInt_5[num] = num3 + 1;
					int num5 = 1;
					while (true)
					{
						num5 += (num4 & 1);
						num4 >>= 1;
						num--;
						if (num == 0)
						{
							break;
						}
						num3 = num5;
						num5 = this.pInt_2[num5];
						if (num5 == 0)
						{
							num5 = num2 + 1;
							num2 = num5 + 1;
							this.pInt_2[num3] = num5;
						}
					}
					this.pInt_2[num5] = -i;
				}
			}
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x003A0E6C File Offset: 0x0039F06C
		private unsafe void method_4(int int_16)
		{
			int num = 0;
			int* ptr = this.pInt_3;
			Class390.smethod_2(0, this.pInt_4, 15);
			while (int_16 > 0)
			{
				int num2 = this.method_2(this.pInt_2);
				if (num2 < 15)
				{
					*ptr = num2;
					this.pInt_4[num2]++;
					ptr++;
					num = num2;
					int_16--;
				}
				else
				{
					if (num2 < 17)
					{
						if (num2 == 15)
						{
							num2 = 2;
						}
						else
						{
							num2 = this.method_1() + 3;
						}
					}
					else if (num2 == 17)
					{
						num2 = this.method_0(2) + 5;
					}
					else if (num2 == 18)
					{
						num2 = this.method_0(3) + 9;
					}
					else
					{
						num2 = this.method_0(7) + 17;
					}
					int_16 -= num2;
					this.pInt_4[num] += num2;
					do
					{
						num2--;
						*ptr = num;
						ptr++;
					}
					while (num2 != 0);
				}
			}
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x003A0F60 File Offset: 0x0039F160
		private unsafe void method_5()
		{
			Class390.smethod_2(0, this.pInt_3, 320);
			this.method_4(this.method_0(6) + 257);
			Class390.smethod_2(0, this.pInt_0, 640);
			this.pInt_5[1] = 0;
			int num = this.pInt_5[2] = this.pInt_4[1] << 1;
			num = (this.pInt_5[3] = num + this.pInt_4[2] << 1);
			num = (this.pInt_5[4] = num + this.pInt_4[3] << 1);
			num = (this.pInt_5[5] = num + this.pInt_4[4] << 1);
			num = (this.pInt_5[6] = num + this.pInt_4[5] << 1);
			num = (this.pInt_5[7] = num + this.pInt_4[6] << 1);
			num = (this.pInt_5[8] = num + this.pInt_4[7] << 1);
			num = (this.pInt_5[9] = num + this.pInt_4[8] << 1);
			num = (this.pInt_5[10] = num + this.pInt_4[9] << 1);
			num = (this.pInt_5[11] = num + this.pInt_4[10] << 1);
			num = (this.pInt_5[12] = num + this.pInt_4[11] << 1);
			num = (this.pInt_5[13] = num + this.pInt_4[12] << 1);
			this.pInt_5[14] = num + this.pInt_4[13] << 1;
			int num2 = 2;
			for (int i = 0; i < 320; i++)
			{
				num = this.pInt_3[i];
				if (num != 0)
				{
					int num3 = this.pInt_5[num];
					int num4 = (int)Class390.smethod_0((uint)num3, num);
					this.pInt_5[num] = num3 + 1;
					int num5 = 1;
					while (true)
					{
						num5 += (num4 & 1);
						num4 >>= 1;
						num--;
						if (num == 0)
						{
							break;
						}
						num3 = num5;
						num5 = this.pInt_0[num5];
						if (num5 == 0)
						{
							num5 = num2 + 1;
							num2 = num5 + 1;
							this.pInt_0[num3] = num5;
						}
					}
					this.pInt_0[num5] = -i;
				}
			}
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x003A11E8 File Offset: 0x0039F3E8
		private unsafe void method_6()
		{
			Class390.smethod_2(0, this.pInt_3, 64);
			this.method_4(this.method_0(6) + 1);
			Class390.smethod_2(0, this.pInt_1, 128);
			this.pInt_5[1] = 0;
			int num = this.pInt_5[2] = this.pInt_4[1] << 1;
			num = (this.pInt_5[3] = num + this.pInt_4[2] << 1);
			num = (this.pInt_5[4] = num + this.pInt_4[3] << 1);
			num = (this.pInt_5[5] = num + this.pInt_4[4] << 1);
			num = (this.pInt_5[6] = num + this.pInt_4[5] << 1);
			num = (this.pInt_5[7] = num + this.pInt_4[6] << 1);
			num = (this.pInt_5[8] = num + this.pInt_4[7] << 1);
			num = (this.pInt_5[9] = num + this.pInt_4[8] << 1);
			num = (this.pInt_5[10] = num + this.pInt_4[9] << 1);
			num = (this.pInt_5[11] = num + this.pInt_4[10] << 1);
			num = (this.pInt_5[12] = num + this.pInt_4[11] << 1);
			num = (this.pInt_5[13] = num + this.pInt_4[12] << 1);
			this.pInt_5[14] = num + this.pInt_4[13] << 1;
			int num2 = 2;
			for (int i = 0; i < 64; i++)
			{
				num = this.pInt_3[i];
				if (num != 0)
				{
					int num3 = this.pInt_5[num];
					int num4 = (int)Class390.smethod_0((uint)num3, num);
					this.pInt_5[num] = num3 + 1;
					int num5 = 1;
					while (true)
					{
						num5 += (num4 & 1);
						num4 >>= 1;
						num--;
						if (num == 0)
						{
							break;
						}
						num3 = num5;
						num5 = this.pInt_1[num5];
						if (num5 == 0)
						{
							num5 = num2 + 1;
							num2 = num5 + 1;
							this.pInt_1[num3] = num5;
						}
					}
					this.pInt_1[num5] = -i;
				}
			}
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0002DE19 File Offset: 0x0002C019
		private void method_7()
		{
			this.int_6 = 8192;
			if (this.method_1() == 0)
			{
				this.method_8();
			}
			else
			{
				this.method_3();
				this.method_5();
				this.method_6();
			}
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x003A1468 File Offset: 0x0039F668
		private unsafe void method_8()
		{
			this.int_6 += this.method_0(8);
			int num = this.int_4;
			while (this.int_6 > 0 && this.int_5 > 0)
			{
				int num2 = this.int_3;
				if (num < 8)
				{
					if (this.int_0 < this.int_1)
					{
						this.int_0 += 3;
						num2 |= ((int)(*this.pByte_0) | (int)this.pByte_0[1] << 8 | (int)this.pByte_0[2] << 16) << num;
						this.pByte_0 += 3;
						num += 24;
					}
					else if (this.int_0 < this.int_2)
					{
						this.int_0++;
						num2 |= (int)(*this.pByte_0) << num;
						this.pByte_0++;
						num += 8;
					}
					else
					{
						Exception3.smethod_2();
					}
				}
				this.int_3 = num2 >> 8;
				num -= 8;
				*this.pByte_1 = (byte)num2;
				this.int_6--;
				this.int_5--;
				this.pByte_1++;
			}
			this.int_4 = num;
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x003A15C0 File Offset: 0x0039F7C0
		public unsafe static int smethod_0(byte[] byte_0, int int_16)
		{
			if (byte_0 == null)
			{
				Exception3.smethod_0("sourceBytes");
			}
            //ZSP int num = *(int*)(&byte_0[int_16]);

            byte[] tmpbyte = byte_0;

            int num = 0;

            fixed (byte* ptr = &byte_0[int_16])
            {
                num = *(int*)ptr;
            }

            int result;
			if (num >= 0)
			{
				result = num;
			}
			else
			{
				result = -num;
			}
			return result;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x003A15FC File Offset: 0x0039F7FC
		public unsafe byte[] method_9(byte[] byte_0, int int_16, int int_17, int int_18)
		{
			if (byte_0 == null)
			{
				Exception3.smethod_0("sourceBytes");
			}
			int num;
			fixed (byte* ptr = &byte_0[int_16])
			{
				num = *(int*)ptr;
			}
			if (num < 0)
			{
				num = -num;
			}
			byte[] array = new byte[num + int_17 + int_18];
			if (num != 0)
			{
				this.method_10(byte_0, int_16, array, int_17);
			}
			return array;
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x003A165C File Offset: 0x0039F85C
		public unsafe int method_10(byte[] byte_0, int int_16, byte[] byte_1, int int_17)
		{
			if (byte_0 == null)
			{
				Exception3.smethod_0("sourceBytes");
			}
			int result;
			if (byte_1 == null)
			{
				result = Class391.smethod_0(byte_0, int_16);
			}
			else
			{
				try
				{
					fixed (byte* ptr = &byte_0[int_16])
					{
						try
						{
							fixed (byte* ptr2 = &byte_1[int_17])
							{
								this.pByte_0 = ptr;
								this.pByte_1 = ptr2;
								int num = *(int*)this.pByte_0;
								if (num <= 0)
								{
									int num2 = -num;
									if (byte_1.Length - int_17 < num2)
									{
										Exception3.smethod_1();
									}
									if (num2 > 0)
									{
										Buffer.BlockCopy(byte_0, int_16 + 4, byte_1, int_17, num2);
									}
									result = num2;
								}
								else
								{
									if (byte_1.Length - int_17 < num)
									{
										Exception3.smethod_1();
									}
									try
									{
										fixed (int* ptr3 = &this.int_10[0])
										{
											try
											{
												fixed (int* ptr4 = &this.int_11[0])
												{
													try
													{
														fixed (int* ptr5 = &this.int_12[0])
														{
															try
															{
																fixed (int* ptr6 = &this.int_13[0])
																{
																	try
																	{
																		fixed (int* ptr7 = &this.int_14[0])
																		{
																			try
																			{
																				fixed (int* ptr8 = &this.int_15[0])
																				{
																					try
																					{
																						fixed (int* ptr9 = &Class393.int_0[0])
																						{
																							try
																							{
																								fixed (int* ptr10 = &Class393.int_1[0])
																								{
																									try
																									{
																										fixed (int* ptr11 = &Class393.int_2[0])
																										{
																											try
																											{
																												fixed (int* ptr12 = &Class393.int_3[0])
																												{
																													this.pInt_0 = ptr3;
																													this.pInt_1 = ptr4;
																													this.pInt_2 = ptr5;
																													this.pInt_3 = ptr6;
																													this.pInt_4 = ptr7;
																													this.pInt_5 = ptr8;
																													this.pInt_6 = ptr9;
																													this.pInt_7 = ptr10;
																													this.pInt_8 = ptr11;
																													this.pInt_9 = ptr12;
																													this.int_4 = 0;
																													this.int_3 = 0;
																													this.int_0 = int_16 + 4;
																													this.pByte_0 += 4;
																													this.int_2 = byte_0.Length;
																													this.int_1 = this.int_2 - 3;
																													this.int_5 = num;
																													while (this.int_5 > 0)
																													{
																														this.method_7();
																														while (this.int_6 > 0 && this.int_5 > 0)
																														{
																															int num3 = this.method_2(this.pInt_0);
																															this.int_6--;
																															if (num3 < 256)
																															{
																																*this.pByte_1 = (byte)num3;
																																this.int_5--;
																																this.pByte_1++;
																															}
																															else
																															{
																																int num4 = num3 - 272;
																																int num5 = (num4 >= 0) ? (this.method_0(this.pInt_6[num4]) + this.pInt_7[num4]) : (num4 + 19);
																																int num6 = this.method_2(this.pInt_1);
																																int num7;
																																if (num6 < 3)
																																{
																																	if (num6 == 0)
																																	{
																																		num7 = this.int_7;
																																	}
																																	else if (num6 == 1)
																																	{
																																		num7 = this.int_8;
																																		this.int_8 = this.int_7;
																																		this.int_7 = num7;
																																	}
																																	else
																																	{
																																		num7 = this.int_9;
																																		this.int_9 = this.int_7;
																																		this.int_7 = num7;
																																	}
																																}
																																else
																																{
																																	num7 = this.pInt_9[num6];
																																	if (num6 >= 5)
																																	{
																																		num7 += this.method_0(this.pInt_8[num6]);
																																		this.int_9 = this.int_8;
																																		this.int_8 = this.int_7;
																																		this.int_7 = num7;
																																	}
																																}
																																Class390.smethod_1(this.pByte_1 - num7, this.pByte_1, num5);
																																this.int_5 -= num5;
																																this.pByte_1 += num5;
																															}
																														}
																													}
																												}
																											}
																											finally
																											{
																												int* ptr12 = null;
																											}
																										}
																									}
																									finally
																									{
																										int* ptr11 = null;
																									}
																								}
																							}
																							finally
																							{
																								int* ptr10 = null;
																							}
																						}
																					}
																					finally
																					{
																						int* ptr9 = null;
																					}
																				}
																			}
																			finally
																			{
																				int* ptr8 = null;
																			}
																		}
																	}
																	finally
																	{
																		int* ptr7 = null;
																	}
																}
															}
															finally
															{
																int* ptr6 = null;
															}
														}
													}
													finally
													{
														int* ptr5 = null;
													}
												}
											}
											finally
											{
												int* ptr4 = null;
											}
										}
									}
									finally
									{
										int* ptr3 = null;
									}
									result = num;
								}
							}
						}
						finally
						{
							byte* ptr2 = null;
						}
					}
				}
				finally
				{
					byte* ptr = null;
				}
			}
			return result;
		}

		// Token: 0x04003C44 RID: 15428
		private int int_0;

		// Token: 0x04003C45 RID: 15429
		private int int_1;

		// Token: 0x04003C46 RID: 15430
		private int int_2 = 0;

		// Token: 0x04003C47 RID: 15431
		private int int_3 = 0;

		// Token: 0x04003C48 RID: 15432
		private int int_4;

		// Token: 0x04003C49 RID: 15433
		private int int_5;

		// Token: 0x04003C4A RID: 15434
		private int int_6;

		// Token: 0x04003C4B RID: 15435
		private int int_7;

		// Token: 0x04003C4C RID: 15436
		private int int_8;

		// Token: 0x04003C4D RID: 15437
		private int int_9;

		// Token: 0x04003C4E RID: 15438
		private unsafe byte* pByte_0;

		// Token: 0x04003C4F RID: 15439
		private unsafe byte* pByte_1;

		// Token: 0x04003C50 RID: 15440
		private unsafe int* pInt_0;

		// Token: 0x04003C51 RID: 15441
		private unsafe int* pInt_1;

		// Token: 0x04003C52 RID: 15442
		private unsafe int* pInt_2;

		// Token: 0x04003C53 RID: 15443
		private unsafe int* pInt_3;

		// Token: 0x04003C54 RID: 15444
		private unsafe int* pInt_4;

		// Token: 0x04003C55 RID: 15445
		private unsafe int* pInt_5;

		// Token: 0x04003C56 RID: 15446
		private int[] int_10;

		// Token: 0x04003C57 RID: 15447
		private int[] int_11;

		// Token: 0x04003C58 RID: 15448
		private int[] int_12;

		// Token: 0x04003C59 RID: 15449
		private int[] int_13;

		// Token: 0x04003C5A RID: 15450
		private int[] int_14;

		// Token: 0x04003C5B RID: 15451
		private int[] int_15;

		// Token: 0x04003C5C RID: 15452
		private unsafe int* pInt_6;

		// Token: 0x04003C5D RID: 15453
		private unsafe int* pInt_7;

		// Token: 0x04003C5E RID: 15454
		private unsafe int* pInt_8;

		// Token: 0x04003C5F RID: 15455
		private unsafe int* pInt_9;
	}
}
