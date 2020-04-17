using System;

namespace ns6
{
	// Token: 0x02000CB1 RID: 3249
	public sealed class Class392
	{
		// Token: 0x06006B3D RID: 27453 RVA: 0x003A5FB4 File Offset: 0x003A41B4
		public Class392()
		{
			this.int_23 = new int[321];
			this.int_24 = new int[640];
			this.int_25 = new int[640];
			this.int_26 = new int[15];
			this.int_35 = new int[8192];
			this.int_36 = new int[8192];
			this.int_37 = new int[8192];
			this.int_38 = new int[8192];
			this.int_43 = new int[15];
			this.int_44 = new int[640];
			this.int_45 = new int[640];
			this.int_46 = new int[320];
			this.int_47 = new int[320];
			this.int_48 = new int[15];
			this.int_49 = new int[128];
			this.int_50 = new int[128];
			this.int_51 = new int[64];
			this.int_52 = new int[64];
			this.int_53 = new int[8];
			this.int_54 = new int[40];
			this.int_55 = new int[40];
			this.int_56 = new int[20];
			this.int_21 = new int[262144];
			this.int_22 = new int[262144];
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x003A613C File Offset: 0x003A433C
		private void method_0()
		{
			if (this.object_0 == null)
			{
				this.object_0 = new object[16];
				this.object_0[0] = this.uint_0;
			}
			else
			{
				int num = (this.int_27 >> 17) - 1;
				int num2 = this.object_0.Length;
				if (num == num2)
				{
					object[] destinationArray = new object[num2 * 2];
					Array.Copy(this.object_0, 0, destinationArray, 0, num2);
					this.object_0 = destinationArray;
				}
				this.object_0[num] = this.uint_0;
			}
			this.uint_0 = new uint[32768];
			this.int_29 = 0;
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x003A61D8 File Offset: 0x003A43D8
		private unsafe bool method_1(int int_57)
		{
			bool result;
			if (this.int_30 != 0)
			{
				this.uint_1 |= (uint)((uint)int_57 << 32 - this.int_30);
				this.int_30--;
				result = true;
			}
			else
			{
				this.int_27 += 4;
				if (this.int_27 <= this.int_28)
				{
					if (this.bool_0)
					{
						if (this.int_29 == 32768)
						{
							this.method_0();
						}
						this.uint_0[this.int_29] = this.uint_1;
						this.int_29++;
					}
					else if (!this.bool_1)
					{
						*(int*)this.pByte_1 = (int)this.uint_1;
						this.pByte_1 += 4;
					}
					this.uint_1 = (uint)int_57;
					this.int_30 = 31;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x003A62C0 File Offset: 0x003A44C0
		private unsafe bool method_2(int int_57, uint uint_2)
		{
			int num = this.int_30;
			bool result;
			if (num >= int_57)
			{
				this.uint_1 |= uint_2 << 32 - num;
				this.int_30 = num - int_57;
				result = true;
			}
			else
			{
				if (num != 0)
				{
					this.uint_1 |= uint_2 << 32 - num;
					uint_2 >>= num;
				}
				this.int_27 += 4;
				if (this.int_27 <= this.int_28)
				{
					if (this.bool_0)
					{
						if (this.int_29 == 32768)
						{
							this.method_0();
						}
						this.uint_0[this.int_29] = this.uint_1;
						this.int_29++;
					}
					else if (!this.bool_1)
					{
						*(int*)this.pByte_1 = (int)this.uint_1;
						this.pByte_1 += 4;
					}
					this.uint_1 = uint_2;
					this.int_30 = 32 + num - int_57;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x003A63CC File Offset: 0x003A45CC
		private unsafe void method_3(int int_57)
		{
			int* ptr = this.pInt_2 + 1;
			int* ptr2 = this.pInt_3;
			this.int_14 = 0;
			this.int_13 = -1;
			int i = 0;
			while (i < int_57)
			{
				if (*ptr2 != 0)
				{
					*ptr = i;
					this.int_13 = i;
					this.pInt_5[i] = 0;
					this.int_14++;
					ptr++;
				}
				else
				{
					this.pInt_4[i] = 0;
				}
				i++;
				ptr2++;
			}
			if (this.int_14 <= 1)
			{
				if (this.int_14 > 0)
				{
					if (this.int_13 == 0)
					{
						this.int_13 = 1;
						i = 1;
					}
					else
					{
						i = 0;
					}
					*ptr = i;
					this.pInt_3[i] = 1;
					this.pInt_5[i] = 0;
				}
				else
				{
					this.int_13 = 1;
					*ptr = 0;
					ptr[1] = 1;
					*this.pInt_3 = 1;
					this.pInt_3[1] = 1;
					*this.pInt_5 = 0;
					this.pInt_5[1] = 0;
				}
				this.int_14 = 2;
			}
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x003A64E4 File Offset: 0x003A46E4
		private unsafe void method_4(int int_57, int int_58)
		{
			int* ptr = this.pInt_2;
			int* ptr2 = this.pInt_3;
			int num;
			do
			{
				num = int_57;
				int num2 = int_58;
				int i = ptr2[ptr[int_57 + int_58 >> 1]];
				while (true)
				{
					if (ptr2[ptr[num]] >= i)
					{
						while (i < ptr2[ptr[num2]])
						{
							num2--;
						}
						if (num <= num2)
						{
							int num3 = ptr[num];
							ptr[num] = ptr[num2];
							ptr[num2] = num3;
							num++;
							num2--;
						}
						if (num > num2)
						{
							break;
						}
					}
					else
					{
						num++;
					}
				}
				if (int_57 < num2)
				{
					this.method_4(int_57, num2);
				}
				int_57 = num;
			}
			while (num < int_58);
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x003A65A4 File Offset: 0x003A47A4
		private unsafe void method_5()
		{
			int* ptr = this.pInt_2;
			int num = ptr[1];
			int num2 = this.pInt_3[num];
			int num3 = 1;
			for (int i = 2; i <= this.int_14; i <<= 1)
			{
				int num4 = ptr[i];
				int num5 = this.pInt_3[num4];
				if (i < this.int_14)
				{
					int num6 = ptr[i + 1];
					int num7 = this.pInt_3[num6];
					if (num7 < num5 || (num7 == num5 && this.pInt_5[num6] <= this.pInt_5[num4]))
					{
						i++;
						num4 = num6;
						num5 = num7;
					}
				}
				if (num2 < num5 || (num2 == num5 && this.pInt_5[num] <= this.pInt_5[num4]))
				{
					break;
				}
				ptr[num3] = ptr[i];
				num3 = i;
			}
			ptr[num3] = num;
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x003A66B8 File Offset: 0x003A48B8
		private unsafe int method_6(int int_57)
		{
			int num = 0;
			int* ptr = this.pInt_2 + 1;
			int* ptr2 = this.pInt_6;
			do
			{
				int num2 = *ptr;
				*ptr = this.pInt_2[this.int_14];
				this.int_14--;
				this.method_5();
				int num3 = *ptr;
				*ptr2 = num2;
				ptr2[1] = num3;
				num += 2;
				ptr2 += 2;
				this.pInt_4[num2] = (this.pInt_4[num3] = int_57);
				this.pInt_3[int_57] = this.pInt_3[num2] + this.pInt_3[num3];
				num2 = this.pInt_5[num2];
				num3 = this.pInt_5[num3];
				this.pInt_5[int_57] = ((num2 > num3) ? num2 : num3) + 1;
				*ptr = int_57;
				int_57++;
				this.method_5();
			}
			while (this.int_14 > 1);
			this.pInt_4[*ptr] = 0;
			return num;
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x003A67C4 File Offset: 0x003A49C4
		private unsafe int method_7()
		{
			this.pInt_3 = this.pInt_13;
			this.pInt_4 = this.pInt_14;
			this.method_3(320);
			this.method_4(1, this.int_14);
			int num = this.method_6(320);
			Class390.smethod_2(0, this.pInt_12, 15);
			int num2 = 0;
			int num3 = 0;
			int* ptr = this.pInt_6 + num;
			do
			{
				ptr--;
				int num4 = *ptr;
				int num5 = this.pInt_14[this.pInt_14[num4]] + 1;
				if (num5 > 14)
				{
					num5 = 14;
					num2++;
				}
				this.pInt_14[num4] = num5;
				if (num4 < 320)
				{
					num3 += num5 * this.pInt_13[num4];
					this.pInt_12[num5]++;
				}
				num--;
			}
			while (num > 0);
			int result;
			if (num2 == 0)
			{
				result = num3;
			}
			else
			{
				do
				{
					num = 13;
					while (this.pInt_12[num] == 0)
					{
						num--;
					}
					this.pInt_12[num]--;
					this.pInt_12[num + 1] += 2;
					this.pInt_12[14]--;
					num2 -= 2;
				}
				while (num2 > 0);
				num2 = 14;
				do
				{
					int num4 = this.pInt_12[num2];
					while (num4 != 0)
					{
						int num5 = *ptr;
						ptr++;
						if (num5 < 320)
						{
							num3 += (num2 - this.pInt_14[num5]) * this.pInt_13[num5];
							this.pInt_14[num5] = num2;
							num4--;
						}
					}
					num2--;
				}
				while (num2 != 0);
				result = num3;
			}
			return result;
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x003A699C File Offset: 0x003A4B9C
		private unsafe int method_8()
		{
			this.pInt_3 = this.pInt_18;
			this.pInt_4 = this.pInt_19;
			this.method_3(64);
			this.method_4(1, this.int_14);
			int num = this.method_6(64);
			Class390.smethod_2(0, this.pInt_17, 15);
			int num2 = 0;
			int num3 = 0;
			int* ptr = this.pInt_6 + num;
			do
			{
				ptr--;
				int num4 = *ptr;
				int num5 = this.pInt_19[this.pInt_19[num4]] + 1;
				if (num5 > 14)
				{
					num5 = 14;
					num2++;
				}
				this.pInt_19[num4] = num5;
				if (num4 < 64)
				{
					num3 += num5 * this.pInt_18[num4];
					this.pInt_17[num5]++;
				}
				num--;
			}
			while (num > 0);
			int result;
			if (num2 == 0)
			{
				result = num3;
			}
			else
			{
				do
				{
					num = 13;
					while (this.pInt_17[num] == 0)
					{
						num--;
					}
					this.pInt_17[num]--;
					this.pInt_17[num + 1] += 2;
					this.pInt_17[14]--;
					num2 -= 2;
				}
				while (num2 > 0);
				num2 = 14;
				do
				{
					int num4 = this.pInt_17[num2];
					while (num4 != 0)
					{
						int num5 = *ptr;
						ptr++;
						if (num5 < 64)
						{
							num3 += (num2 - this.pInt_19[num5]) * this.pInt_18[num5];
							this.pInt_19[num5] = num2;
							num4--;
						}
					}
					num2--;
				}
				while (num2 != 0);
				result = num3;
			}
			return result;
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x003A6B68 File Offset: 0x003A4D68
		private unsafe int method_9()
		{
			int* ptr = this.pInt_14;
			int* ptr2 = this.pInt_15;
			this.int_39 = 0;
			int num = 0;
			int num2 = 0;
			if (this.int_13 > 255)
			{
				this.int_41 = this.int_13 + 1;
			}
			else
			{
				this.int_41 = 257;
				this.int_13 = 256;
			}
			Class390.smethod_2(0, this.pInt_16, this.int_41);
			int num3 = 0;
			while (true)
			{
				int num4 = *ptr;
				ptr++;
				if (num4 != num)
				{
					goto IL_73;
				}
				if (num4 != *ptr)
				{
					goto IL_73;
				}
				int num5;
				if (num2 + 144 > this.int_13)
				{
					num5 = this.int_41;
				}
				else
				{
					num5 = num2 + 144;
				}
				int num6 = num2;
				num2 += 2;
				ptr++;
				while (num2 < num5 && num4 == *ptr)
				{
					ptr++;
					num2++;
				}
				num6 = num2 - num6;
				if (num6 == 2)
				{
					*ptr2 = 15;
				}
				else if (num6 < 5)
				{
					*ptr2 = 16;
					this.pInt_16[this.int_39] = num6 - 3;
					num3++;
				}
				else if (num6 < 9)
				{
					*ptr2 = 17;
					this.pInt_16[this.int_39] = num6 - 5;
					num3 += 2;
				}
				else if (num6 < 17)
				{
					*ptr2 = 18;
					this.pInt_16[this.int_39] = num6 - 9;
					num3 += 3;
				}
				else
				{
					*ptr2 = 19;
					this.pInt_16[this.int_39] = num6 - 17;
					num3 += 7;
				}
				IL_193:
				this.int_39++;
				ptr2++;
				if (num2 < this.int_13)
				{
					continue;
				}
				break;
				IL_73:
				num = (*ptr2 = num4);
				num2++;
				goto IL_193;
			}
			if (num2 == this.int_13)
			{
				*ptr2 = *ptr;
				this.int_39++;
			}
			return num3;
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x003A6D64 File Offset: 0x003A4F64
		private unsafe int method_10()
		{
			int* ptr = this.pInt_19;
			int* ptr2 = this.pInt_20;
			this.int_40 = 0;
			int num = 0;
			int num2 = 0;
			this.int_42 = this.int_13 + 1;
			Class390.smethod_2(0, this.pInt_21, this.int_42);
			int num3 = 0;
			while (true)
			{
				int num4 = *ptr;
				ptr++;
				if (num4 != num)
				{
					goto IL_49;
				}
				if (num4 != *ptr)
				{
					goto IL_49;
				}
				int num5 = num2;
				num2 += 2;
				ptr++;
				while (num2 < this.int_42 && num4 == *ptr)
				{
					ptr++;
					num2++;
				}
				num5 = num2 - num5;
				if (num5 == 2)
				{
					*ptr2 = 15;
				}
				else if (num5 < 5)
				{
					*ptr2 = 16;
					this.pInt_21[this.int_40] = num5 - 3;
					num3++;
				}
				else if (num5 < 9)
				{
					*ptr2 = 17;
					this.pInt_21[this.int_40] = num5 - 5;
					num3 += 2;
				}
				else if (num5 < 17)
				{
					*ptr2 = 18;
					this.pInt_21[this.int_40] = num5 - 9;
					num3 += 3;
				}
				else
				{
					*ptr2 = 19;
					this.pInt_21[this.int_40] = num5 - 17;
					num3 += 7;
				}
				IL_143:
				this.int_40++;
				ptr2++;
				if (num2 < this.int_13)
				{
					continue;
				}
				break;
				IL_49:
				num = (*ptr2 = num4);
				num2++;
				goto IL_143;
			}
			if (num2 == this.int_13)
			{
				*ptr2 = *ptr;
				this.int_40++;
			}
			return num3;
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x003A6F10 File Offset: 0x003A5110
		private unsafe void method_11()
		{
			int* ptr = this.pInt_23;
			Class390.smethod_2(0, ptr, 20);
			int* ptr2 = this.pInt_15;
			int i;
			for (i = 7; i < this.int_39; i += 8)
			{
				ptr[*ptr2]++;
				ptr[ptr2[1]]++;
				ptr[ptr2[2]]++;
				ptr[ptr2[3]]++;
				ptr[ptr2[4]]++;
				ptr[ptr2[5]]++;
				ptr[ptr2[6]]++;
				ptr[ptr2[7]]++;
				ptr2 += 8;
			}
			for (i -= 7; i < this.int_39; i++)
			{
				ptr[*ptr2]++;
				ptr2++;
			}
			ptr2 = this.pInt_20;
			for (i = 7; i < this.int_40; i += 8)
			{
				ptr[*ptr2]++;
				ptr[ptr2[1]]++;
				ptr[ptr2[2]]++;
				ptr[ptr2[3]]++;
				ptr[ptr2[4]]++;
				ptr[ptr2[5]]++;
				ptr[ptr2[6]]++;
				ptr[ptr2[7]]++;
				ptr2 += 8;
			}
			for (i -= 7; i < this.int_40; i++)
			{
				ptr[*ptr2]++;
				ptr2++;
			}
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x003A70BC File Offset: 0x003A52BC
		private unsafe int method_12()
		{
			this.pInt_3 = this.pInt_23;
			this.pInt_4 = this.pInt_24;
			this.method_3(20);
			this.method_4(1, this.int_14);
			int num = this.method_6(20);
			Class390.smethod_2(0, this.pInt_22, 8);
			int num2 = 0;
			int num3 = 0;
			int* ptr = this.pInt_6 + num;
			do
			{
				ptr--;
				int num4 = *ptr;
				int num5 = this.pInt_24[this.pInt_24[num4]] + 1;
				if (num5 > 7)
				{
					num5 = 7;
					num2++;
				}
				this.pInt_24[num4] = num5;
				if (num4 < 20)
				{
					num3 += num5 * this.pInt_23[num4];
					this.pInt_22[num5]++;
				}
				num--;
			}
			while (num > 0);
			int result;
			if (num2 == 0)
			{
				result = num3;
			}
			else
			{
				do
				{
					num = 6;
					while (this.pInt_22[num] == 0)
					{
						num--;
					}
					this.pInt_22[num]--;
					this.pInt_22[num + 1] += 2;
					this.pInt_22[7]--;
					num2 -= 2;
				}
				while (num2 > 0);
				num2 = 7;
				do
				{
					int num4 = this.pInt_22[num2];
					while (num4 != 0)
					{
						int num5 = *ptr;
						ptr++;
						if (num5 < 20)
						{
							num3 += (num2 - this.pInt_24[num5]) * this.pInt_23[num5];
							this.pInt_24[num5] = num2;
							num4--;
						}
					}
					num2--;
				}
				while (num2 != 0);
				result = num3;
			}
			return result;
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x003A7284 File Offset: 0x003A5484
		private unsafe bool method_13(uint uint_2, int int_57, int int_58)
		{
			bool result;
			if (!this.method_1(0))
			{
				result = false;
			}
			else
			{
				int num = this.int_30;
				while (true)
				{
					if (num >= 8)
					{
						this.uint_1 |= uint_2 << 32 - num;
						num -= 8;
					}
					else
					{
						if (num != 0)
						{
							this.uint_1 |= uint_2 << 32 - num;
							uint_2 >>= num;
						}
						this.int_27 += 4;
						if (this.int_27 > this.int_28)
						{
							break;
						}
						if (this.bool_0)
						{
							if (this.int_29 == 32768)
							{
								this.method_0();
							}
							this.uint_0[this.int_29] = this.uint_1;
							this.int_29++;
						}
						else if (!this.bool_1)
						{
							*(int*)this.pByte_1 = (int)this.uint_1;
							this.pByte_1 += 4;
						}
						this.uint_1 = uint_2;
						num += 24;
					}
					if (int_57 >= int_58)
					{
						goto IL_11D;
					}
					uint_2 = (uint)this.pByte_0[int_57];
					int_57++;
				}
				result = false;
				return result;
				IL_11D:
				this.int_30 = num;
				result = true;
			}
			return result;
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x003A73B8 File Offset: 0x003A55B8
		private unsafe bool method_14()
		{
			int i = 0;
			bool result;
			while (i < this.int_34)
			{
				int num = this.pInt_8[i];
				if (this.method_2(this.pInt_14[num], (uint)this.pInt_13[num]))
				{
					if (num >= 256)
					{
						num -= 272;
						if (num >= 0 && !this.method_2(this.pInt_25[num], (uint)(this.pInt_9[i] - this.pInt_26[num])))
						{
							result = false;
							return result;
						}
						num = this.pInt_10[i];
						int num2 = this.pInt_19[num];
						if (num < 5)
						{
							if (!this.method_2(num2, (uint)this.pInt_18[num]))
							{
								result = false;
								return result;
							}
						}
						else if (!this.method_2(num2 + this.pInt_27[num], (uint)(this.pInt_18[num] | this.pInt_11[i] << num2)))
						{
							result = false;
							return result;
						}
					}
					i++;
					continue;
				}
				result = false;
				return result;
			}
			result = true;
			return result;
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x003A74DC File Offset: 0x003A56DC
		private unsafe void method_15()
		{
			int* ptr = this.pInt_7;
			ptr[1] = 0;
			int num = this.pInt_22[1] << 1;
			ptr[2] = num;
			ptr += 3;
			int* ptr2 = this.pInt_22 + 2;
			for (int i = 5; i > 0; i--)
			{
				num = (*ptr = num + *ptr2 << 1);
				ptr2++;
				ptr++;
			}
			ptr = this.pInt_7;
			int* ptr3 = this.pInt_23;
			ptr2 = this.pInt_24;
			for (int i = 20; i > 0; i--)
			{
				num = *ptr2;
				if (num != 0)
				{
					int num2 = ptr[num];
					*ptr3 = (int)Class390.smethod_0((uint)num2, num);
					ptr[num] = num2 + 1;
				}
				ptr2++;
				ptr3++;
			}
			ptr = this.pInt_7;
			ptr[1] = 0;
			num = this.pInt_12[1] << 1;
			ptr[2] = num;
			ptr += 3;
			ptr2 = this.pInt_12 + 2;
			for (int i = 12; i > 0; i--)
			{
				num = (*ptr = num + *ptr2 << 1);
				ptr2++;
				ptr++;
			}
			ptr = this.pInt_7;
			ptr3 = this.pInt_13;
			ptr2 = this.pInt_14;
			for (int i = 320; i > 0; i--)
			{
				num = *ptr2;
				if (num != 0)
				{
					int num2 = ptr[num];
					*ptr3 = (int)Class390.smethod_0((uint)num2, num);
					ptr[num] = num2 + 1;
				}
				ptr2++;
				ptr3++;
			}
			ptr = this.pInt_7;
			ptr[1] = 0;
			num = this.pInt_17[1] << 1;
			ptr[2] = num;
			ptr += 3;
			ptr2 = this.pInt_17 + 2;
			for (int i = 12; i > 0; i--)
			{
				num = (*ptr = num + *ptr2 << 1);
				ptr2++;
				ptr++;
			}
			ptr = this.pInt_7;
			ptr3 = this.pInt_18;
			ptr2 = this.pInt_19;
			for (int i = 64; i > 0; i--)
			{
				num = *ptr2;
				if (num != 0)
				{
					int num2 = ptr[num];
					*ptr3 = (int)Class390.smethod_0((uint)num2, num);
					ptr[num] = num2 + 1;
				}
				ptr2++;
				ptr3++;
			}
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x003A76FC File Offset: 0x003A58FC
		private unsafe bool method_16()
		{
			this.method_15();
			bool result;
			if (!this.method_1(1))
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < 20; i++)
				{
					if (!this.method_2(3, (uint)this.pInt_24[i]))
					{
						result = false;
						return result;
					}
				}
				if (!this.method_2(6, (uint)(this.int_41 - 257)))
				{
					result = false;
				}
				else
				{
					for (int i = 0; i < this.int_39; i++)
					{
						int num = this.pInt_15[i];
						int num2 = this.pInt_24[num];
						if (!this.method_2(num2 + this.pInt_29[num], (uint)(this.pInt_23[num] | this.pInt_16[i] << num2)))
						{
							result = false;
							return result;
						}
					}
					if (!this.method_2(6, (uint)(this.int_42 - 1)))
					{
						result = false;
					}
					else
					{
						for (int i = 0; i < this.int_40; i++)
						{
							int num = this.pInt_20[i];
							int num2 = this.pInt_24[num];
							if (!this.method_2(num2 + this.pInt_29[num], (uint)(this.pInt_23[num] | this.pInt_21[i] << num2)))
							{
								result = false;
								return result;
							}
						}
						result = this.method_14();
					}
				}
			}
			return result;
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x003A7850 File Offset: 0x003A5A50
		private unsafe bool method_17()
		{
			int num = 16 + this.method_7();
			num += this.method_9();
			num += this.method_8();
			num += this.method_10();
			this.method_11();
			num += this.method_12() + 60;
			num += this.int_31;
			int num2 = this.int_33 - this.int_32;
			bool result;
			if (num2 <= 8447 && (num2 << 3) + 10 <= num)
			{
				if (!this.method_13((uint)((num2 < 8192) ? 0 : (num2 - 8192)), this.int_32, this.int_33))
				{
					result = false;
					return result;
				}
				this.int_15 = this.int_18;
				this.int_16 = this.int_19;
				this.int_17 = this.int_20;
			}
			else
			{
				if (!this.method_16())
				{
					result = false;
					return result;
				}
				this.int_18 = this.int_15;
				this.int_19 = this.int_16;
				this.int_20 = this.int_17;
			}
			Class390.smethod_2(0, this.pInt_13, 320);
			Class390.smethod_2(0, this.pInt_18, 64);
			this.int_31 = 0;
			this.int_32 = this.int_33;
			this.int_34 = 0;
			result = true;
			return result;
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x003A7980 File Offset: 0x003A5B80
		private int method_18(int int_57)
		{
			int result;
			if (int_57 < 19)
			{
				result = int_57 + 253;
			}
			else if (int_57 < 115)
			{
				if (int_57 < 51)
				{
					this.int_31++;
					result = (int_57 - 19 >> 1) + 272;
				}
				else
				{
					this.int_31 += 2;
					result = (int_57 - 51 >> 2) + 288;
				}
			}
			else if (int_57 < 243)
			{
				if (int_57 < 179)
				{
					this.int_31 += 3;
					result = (int_57 - 115 >> 3) + 304;
				}
				else
				{
					this.int_31 += 4;
					result = (int_57 - 179 >> 4) + 312;
				}
			}
			else if (int_57 < 371)
			{
				this.int_31 += 6;
				result = (int_57 - 243 >> 6) + 316;
			}
			else if (int_57 < 627)
			{
				this.int_31 += 8;
				result = 318;
			}
			else
			{
				this.int_31 += 14;
				result = 319;
			}
			return result;
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x003A7AB8 File Offset: 0x003A5CB8
		private int method_19(int int_57)
		{
			int result;
			if (int_57 < 3)
			{
				result = int_57 + 2;
			}
			else if (int_57 == this.int_15)
			{
				result = 0;
			}
			else if (int_57 == this.int_16)
			{
				this.int_16 = this.int_15;
				this.int_15 = int_57;
				result = 1;
			}
			else if (int_57 == this.int_17)
			{
				this.int_17 = this.int_15;
				this.int_15 = int_57;
				result = 2;
			}
			else
			{
				this.int_17 = this.int_16;
				this.int_16 = this.int_15;
				this.int_15 = int_57;
				if (int_57 < 1025)
				{
					if (int_57 < 65)
					{
						if (int_57 < 17)
						{
							result = (int_57 - 3 >> 1) + 5;
						}
						else if (int_57 < 33)
						{
							result = (int_57 - 17 >> 2) + 12;
						}
						else
						{
							result = (int_57 - 33 >> 3) + 16;
						}
					}
					else if (int_57 < 257)
					{
						if (int_57 < 129)
						{
							result = (int_57 - 65 >> 4) + 20;
						}
						else
						{
							result = (int_57 - 129 >> 5) + 24;
						}
					}
					else if (int_57 < 513)
					{
						result = (int_57 - 257 >> 6) + 28;
					}
					else
					{
						result = (int_57 - 513 >> 7) + 32;
					}
				}
				else if (int_57 < 16385)
				{
					if (int_57 < 4097)
					{
						if (int_57 < 2049)
						{
							result = (int_57 - 1025 >> 8) + 36;
						}
						else
						{
							result = (int_57 - 2049 >> 9) + 40;
						}
					}
					else if (int_57 < 8193)
					{
						result = (int_57 - 4097 >> 10) + 44;
					}
					else
					{
						result = (int_57 - 8193 >> 11) + 48;
					}
				}
				else if (int_57 < 65537)
				{
					if (int_57 < 32769)
					{
						result = (int_57 - 16385 >> 12) + 52;
					}
					else
					{
						result = (int_57 - 32769 >> 14) + 56;
					}
				}
				else if (int_57 < 131073)
				{
					result = (int_57 - 65537 >> 15) + 58;
				}
				else if (int_57 < 262145)
				{
					result = (int_57 - 131073 >> 16) + 60;
				}
				else
				{
					result = (int_57 - 262145 >> 17) + 62;
				}
			}
			return result;
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x003A7D24 File Offset: 0x003A5F24
		private unsafe bool method_20(int int_57)
		{
			bool result;
			if (this.int_34 == 8192 && !this.method_17())
			{
				result = false;
			}
			else
			{
				this.pInt_13[int_57]++;
				this.pInt_8[this.int_34] = int_57;
				this.int_34++;
				result = true;
			}
			return result;
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x003A7D80 File Offset: 0x003A5F80
		private unsafe bool method_21()
		{
			bool result;
			if (this.int_34 == 8192 && !this.method_17())
			{
				result = false;
			}
			else
			{
				int num = this.int_34;
				int num2 = this.method_18(this.int_1);
				this.pInt_13[num2]++;
				this.pInt_8[num] = num2;
				this.pInt_9[num] = this.int_1;
				num2 = this.method_19(this.int_2);
				if (num2 >= 5)
				{
					this.pInt_11[num] = this.int_2 - this.pInt_28[num2];
					this.int_31 += this.pInt_27[num2];
				}
				this.pInt_18[num2]++;
				this.pInt_10[num] = num2;
				this.int_34 = num + 1;
				result = true;
			}
			return result;
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x003A7E64 File Offset: 0x003A6064
		private unsafe int method_22()
		{
			int result;
			fixed (int* ptr = &this.int_22[0], ptr2 = &this.int_21[0], ptr3 = &this.int_26[0], ptr4 = &this.int_23[0], ptr5 = &this.int_24[0], ptr6 = &this.int_25[0], ptr7 = &this.int_35[0], ptr8 = &this.int_36[0], ptr9 = &this.int_37[0], ptr10 = &this.int_38[0], ptr11 = &this.int_43[0], ptr12 = &this.int_44[0], ptr13 = &this.int_45[0], ptr14 = &this.int_46[0], ptr15 = &this.int_47[0], ptr16 = &this.int_48[0], ptr17 = &this.int_49[0], ptr18 = &this.int_50[0], ptr19 = &this.int_51[0], ptr20 = &this.int_52[0], ptr21 = &this.int_53[0], ptr22 = &this.int_54[0], ptr23 = &this.int_55[0], ptr24 = &Class393.int_0[0], ptr25 = &Class393.int_1[0], ptr26 = &Class393.int_2[0], ptr27 = &Class393.int_3[0], ptr28 = &Class393.int_4[0])
			{
				this.pInt_1 = ptr;
				this.pInt_0 = ptr2;
				this.pInt_7 = ptr3;
				this.pInt_2 = ptr4;
				this.pInt_5 = ptr5;
				this.pInt_6 = ptr6;
				this.pInt_8 = ptr7;
				this.pInt_9 = ptr8;
				this.pInt_10 = ptr9;
				this.pInt_11 = ptr10;
				this.pInt_12 = ptr11;
				this.pInt_13 = ptr12;
				this.pInt_14 = ptr13;
				this.pInt_15 = ptr14;
				this.pInt_16 = ptr15;
				this.pInt_17 = ptr16;
				this.pInt_18 = ptr17;
				this.pInt_19 = ptr18;
				this.pInt_20 = ptr19;
				this.pInt_21 = ptr20;
				this.pInt_22 = ptr21;
				this.pInt_23 = ptr22;
				this.pInt_24 = ptr23;
				this.pInt_25 = ptr24;
				this.pInt_26 = ptr25;
				this.pInt_27 = ptr26;
				this.pInt_28 = ptr27;
				this.pInt_29 = ptr28;
				Class390.smethod_2(-524289, this.pInt_0, this.int_6);
				Class390.smethod_2(0, this.pInt_13, 320);
				Class390.smethod_2(0, this.pInt_18, 64);
				this.int_32 = 0;
				this.int_34 = 0;
				this.int_31 = 0;
				this.int_15 = 0;
				this.int_16 = 0;
				this.int_17 = 0;
				this.int_18 = 0;
				this.int_19 = 0;
				this.int_20 = 0;
				*this.pInt_1 = -524289;
				int num = ((int)(*this.pByte_0) << this.int_5 + this.int_5 ^ (int)this.pByte_0[1] << this.int_5 ^ (int)this.pByte_0[2]) & this.int_7;
				this.pInt_0[num] = 0;
				this.int_27 = 0;
				this.method_20((int)(*this.pByte_0));
				this.int_30 = 32;
				this.uint_1 = 0u;
				int i = 1;
				while (i < this.int_11 - 2)
				{
					num = ((num << this.int_5 ^ (int)this.pByte_0[i + 2]) & this.int_7);
					this.pInt_1[i & this.int_4] = (this.int_0 = this.pInt_0[num]);
					this.pInt_0[num] = i;
					this.int_33 = i;
					this.int_12 = this.int_8;
					this.int_9 = i - this.int_3;
					int num3;
					if (this.int_0 >= (this.int_10 = i - 524288) && this.method_23(i))
					{
						int num2 = i + this.int_1;
						if (this.int_0 > this.int_9 && (this.int_0 = this.pInt_1[this.int_0 & this.int_4]) >= this.int_10 && num2 < this.int_11 && this.int_1 < 17010)
						{
							this.method_24(i);
							num2 = i + this.int_1;
						}
						while (this.int_1 < 32 && num2 < this.int_11)
						{
							i++;
							num = ((num << this.int_5 ^ (int)this.pByte_0[i + 2]) & this.int_7);
							this.pInt_1[i & this.int_4] = (this.int_0 = this.pInt_0[num]);
							this.pInt_0[num] = i;
							this.int_12 = this.int_8;
							this.int_9 = i - this.int_3;
							if (this.int_0 < (this.int_10 = i - 524288) || !this.method_24(i))
							{
								break;
							}
							if (!this.method_20((int)this.pByte_0[i - 1]))
							{
								result = -1;
								return result;
							}
							num2 = i + this.int_1;
							this.int_33 = i;
						}
						if (this.method_21())
						{
							if (num2 >= this.int_11 - 2)
							{
								i = num2;
								continue;
							}
							i++;
							do
							{
								num = ((num << this.int_5 ^ (int)this.pByte_0[i + 2]) & this.int_7);
								this.pInt_1[i & this.int_4] = (this.int_0 = this.pInt_0[num]);
								this.pInt_0[num] = i;
								i++;
							}
							while (i < num2);
							continue;
						}
						else
						{
							num3 = -1;
						}
					}
					else
					{
						if (this.method_20((int)this.pByte_0[i]))
						{
							i++;
							continue;
						}
						num3 = -1;
					}
					result = num3;
					return result;
				}
				while (i < this.int_11)
				{
					this.int_33 = i;
					if (!this.method_20((int)this.pByte_0[i]))
					{
						result = -1;
						return result;
					}
					i++;
				}
				this.int_33 = i;
				if (!this.method_25())
				{
					result = -1;
					return result;
				}
			}
			result = this.int_27;
			return result;
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x003A85B4 File Offset: 0x003A67B4
		private unsafe bool method_23(int int_57)
		{
			byte* ptr = this.pByte_0;
			uint num = (uint)((int)ptr[int_57] | (int)ptr[int_57 + 1] << 8 | (int)ptr[int_57 + 2] << 16);
			int num2 = this.int_0;
			int num3 = this.int_11;
			int num4 = num3 - 8;
			int num5 = this.int_12;
			int num6;
			int num7;
			while (true)
			{
				if ((*(uint*)(ptr + num2) & 16777215u) == num)
				{
					num6 = num2 + 3;
					num7 = int_57 + 3;
					if (num7 < num3 && ptr[num6] == ptr[num7])
					{
						num6++;
						num7++;
						if (num7 < num3 && ptr[num6] == ptr[num7])
						{
							break;
						}
						if (int_57 - num2 <= 32768)
						{
							goto Block_8;
						}
					}
					else if (int_57 - num2 <= 4096)
					{
						goto Block_9;
					}
				}
				if (num2 <= this.int_9)
				{
					goto IL_2A4;
				}
				num2 = (this.int_0 = this.pInt_1[num2 & this.int_4]);
				if (num2 < this.int_10)
				{
					goto IL_2A9;
				}
				num5 = (this.int_12 = num5 - 1);
				if (num5 == 0)
				{
					goto Block_3;
				}
			}
			while (num7 < num4 && ptr[++num6] == ptr[++num7] && ptr[++num6] == ptr[++num7] && ptr[++num6] == ptr[++num7] && ptr[++num6] == ptr[++num7] && ptr[++num6] == ptr[++num7] && ptr[++num6] == ptr[++num7] && ptr[++num6] == ptr[++num7])
			{
				if (ptr[++num6] != ptr[++num7])
				{
					break;
				}
			}
			if (ptr[num6] == ptr[num7])
			{
				num6++;
				num7++;
				while (num7 < num3 && ptr[num6] == ptr[num7])
				{
					num6++;
					num7++;
				}
			}
			num7 -= int_57;
			if (num7 < 17010)
			{
				this.int_1 = num7;
			}
			else
			{
				this.int_1 = 17010;
			}
			this.int_2 = int_57 - num2;
			bool result = true;
			return result;
			Block_3:
			result = false;
			return result;
			Block_8:
			this.int_1 = 4;
			this.int_2 = int_57 - num2;
			result = true;
			return result;
			Block_9:
			this.int_1 = 3;
			this.int_2 = int_57 - num2;
			result = true;
			return result;
			IL_2A4:
			result = false;
			return result;
			IL_2A9:
			result = false;
			return result;
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x003A8874 File Offset: 0x003A6A74
		private unsafe bool method_24(int int_57)
		{
			byte* ptr = this.pByte_0;
			int num = this.int_0;
			int num2 = this.int_1;
			int num3 = this.int_11;
			int num4 = num3 - 8;
			int num5 = this.int_12;
			uint num6 = *(uint*)(ptr + int_57 + num2 - 3);
			bool flag = false;
			do
			{
				if (*(uint*)(ptr + num + num2 - 3) == num6 && ptr[int_57] == ptr[num] && ptr[int_57 + 1] == ptr[num + 1])
				{
					int num7 = num + 1;
					int num8 = int_57 + 1;
					if (num2 > 4)
					{
						int num9 = num2 - 1 >> 2;
						while (*(uint*)(ptr + num7 + 1) == *(uint*)(ptr + num8 + 1))
						{
							num7 += 4;
							num8 += 4;
							num9--;
							if (num9 <= 0)
							{
								goto IL_161;
							}
						}
						goto IL_248;
					}
					IL_161:
					while (num8 < num4 && ptr[++num7] == ptr[++num8] && ptr[++num7] == ptr[++num8] && ptr[++num7] == ptr[++num8] && ptr[++num7] == ptr[++num8] && ptr[++num7] == ptr[++num8] && ptr[++num7] == ptr[++num8] && ptr[++num7] == ptr[++num8])
					{
						if (ptr[++num7] != ptr[++num8])
						{
							break;
						}
					}
					if (ptr[num7] == ptr[num8])
					{
						num7++;
						num8++;
						while (num8 < num3 && ptr[num7] == ptr[num8])
						{
							num7++;
							num8++;
						}
					}
					num7 = num8 - int_57;
					int_57 -= num;
					if (num7 - num2 > 2 || (num7 - num2 == 1 && (int_57 < 1025 || Class392.smethod_0(int_57, this.int_2))) || (num7 - num2 == 2 && (int_57 < 32769 || Class392.smethod_1(int_57, this.int_2))))
					{
						num2 = (this.int_1 = num7);
						this.int_2 = int_57;
						flag = true;
						if (num2 >= 17010)
						{
							goto IL_2BB;
						}
						if (num8 == num3)
						{
							break;
						}
						num6 = *(uint*)(ptr + num8 - 3);
					}
					int_57 += num;
				}
				IL_248:
				if (num <= this.int_9)
				{
					break;
				}
				num = this.pInt_1[num & this.int_4];
				if (num < this.int_10)
				{
					break;
				}
			}
			while (--num5 != 0);
			goto IL_2CC;
			IL_2BB:
			this.int_1 = 17010;
			bool result = flag;
			return result;
			IL_2CC:
			result = flag;
			return result;
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x003A8B54 File Offset: 0x003A6D54
		private static bool smethod_0(int int_57, int int_58)
		{
			bool result;
			if (int_57 < 16385)
			{
				if (int_57 < 4097)
				{
					if (int_57 < 2049)
					{
						if (int_58 < 3)
						{
							result = false;
							return result;
						}
					}
					else if (int_58 < 17)
					{
						result = false;
						return result;
					}
				}
				else if (int_57 < 8193)
				{
					if (int_58 < 33)
					{
						result = false;
						return result;
					}
				}
				else if (int_58 < 65)
				{
					result = false;
					return result;
				}
			}
			else if (int_57 < 65537)
			{
				if (int_57 < 32769)
				{
					if (int_58 < 129)
					{
						result = false;
						return result;
					}
				}
				else if (int_58 < 513)
				{
					result = false;
					return result;
				}
			}
			else if (int_57 < 131073)
			{
				if (int_58 < 2049)
				{
					result = false;
					return result;
				}
			}
			else if (int_57 < 262145)
			{
				if (int_58 < 4097)
				{
					result = false;
					return result;
				}
			}
			else if (int_58 < 8193)
			{
				result = false;
				return result;
			}
			result = true;
			return result;
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x003A8C70 File Offset: 0x003A6E70
		private static bool smethod_1(int int_57, int int_58)
		{
			bool result;
			if (int_57 < 131073)
			{
				if (int_57 < 65537 && int_58 < 3)
				{
					result = false;
					return result;
				}
				if (int_58 < 17)
				{
					result = false;
					return result;
				}
			}
			if (int_57 < 262145)
			{
				if (int_58 < 33)
				{
					result = false;
					return result;
				}
			}
			else if (int_58 < 65)
			{
				result = false;
				return result;
			}
			result = true;
			return result;
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x003A8CDC File Offset: 0x003A6EDC
		private unsafe bool method_25()
		{
			bool result;
			if (this.method_17())
			{
				this.int_27 += 4 - (this.int_30 >> 3);
				if (this.int_27 <= this.int_28)
				{
					if (this.bool_0)
					{
						if (this.int_29 == 32768)
						{
							this.method_0();
						}
						this.uint_0[this.int_29] = this.uint_1;
						this.int_29++;
					}
					else if (!this.bool_1)
					{
						switch (this.int_30 >> 3)
						{
						case 0:
							*(int*)this.pByte_1 = (int)this.uint_1;
							break;
						case 1:
							*this.pByte_1 = (byte)this.uint_1;
							this.pByte_1[1] = (byte)(this.uint_1 >> 8);
							this.pByte_1[2] = (byte)(this.uint_1 >> 16);
							break;
						case 2:
							*this.pByte_1 = (byte)this.uint_1;
							this.pByte_1[1] = (byte)(this.uint_1 >> 8);
							break;
						case 3:
							*this.pByte_1 = (byte)this.uint_1;
							break;
						}
					}
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x003A8E14 File Offset: 0x003A7014
		public unsafe byte[] method_26(byte[] byte_1, int int_57, int int_58, Enum117 enum117_0, int int_59, int int_60)
		{
			byte[] result;
			if (int_58 == 0)
			{
				result = new byte[int_59 + int_60 + 4];
			}
			else
			{
				if (byte_1 == null)
				{
					Exception3.smethod_0("sourceBytes");
				}
				this.bool_0 = true;
				this.bool_1 = false;
				this.object_0 = null;
				this.uint_0 = new uint[32768];
				this.int_29 = 0;
				this.int_28 = int_58;
				this.int_11 = int_58;
				this.pByte_1 = null;
				byte[] array;
				fixed (byte* ptr = &byte_1[int_57])
				{
					this.pByte_0 = ptr;
					int num = -1;
					if (int_58 > 3 && enum117_0 != Enum117.const_0)
					{
						this.method_27(enum117_0);
						num = this.method_22();
					}
					if (num > 0)
					{
						array = new byte[int_59 + 4 + num + int_60];
						fixed (byte* ptr2 = &array[int_59])
						{
							*(int*)ptr2 = int_58;
						}
						int_59 += 4;
						num--;
						int num2 = num >> 17;
						for (int i = 0; i < num2; i++)
						{
							Buffer.BlockCopy((uint[])this.object_0[i], 0, array, int_59, 131072);
							int_59 += 131072;
						}
						Buffer.BlockCopy(this.uint_0, 0, array, int_59, (num & 131071) + 1);
						this.object_0 = null;
						this.uint_0 = null;
					}
					else
					{
						this.object_0 = null;
						this.uint_0 = null;
						array = new byte[int_59 + 4 + int_58 + int_60];
						fixed (byte* ptr3 = &array[int_59])
						{
							*(int*)ptr3 = -int_58;
						}
						Buffer.BlockCopy(byte_1, int_57, array, int_59 + 4, int_58);
					}
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x003A8FA4 File Offset: 0x003A71A4
		private void method_27(Enum117 enum117_0)
		{
			switch (enum117_0)
			{
			case Enum117.const_1:
				this.int_6 = 4096;
				this.int_7 = 4095;
				this.int_3 = 8192;
				this.int_4 = 8191;
				this.int_8 = 2;
				this.int_5 = 4;
				break;
			case Enum117.const_2:
				this.int_6 = 32768;
				this.int_7 = 32767;
				this.int_3 = 65536;
				this.int_4 = 65535;
				this.int_8 = 8;
				this.int_5 = 5;
				break;
			case Enum117.const_3:
				this.int_6 = 262144;
				this.int_7 = 262143;
				this.int_3 = 262144;
				this.int_4 = 262143;
				this.int_8 = 32;
				this.int_5 = 6;
				break;
			case Enum117.const_4:
				this.int_6 = 262144;
				this.int_7 = 262143;
				this.int_3 = 262144;
				this.int_4 = 262143;
				this.int_8 = 96;
				this.int_5 = 6;
				break;
			}
		}

		// Token: 0x04003D19 RID: 15641
		private int int_0;

		// Token: 0x04003D1A RID: 15642
		private int int_1;

		// Token: 0x04003D1B RID: 15643
		private int int_2 = 0;

		// Token: 0x04003D1C RID: 15644
		private int int_3 = 0;

		// Token: 0x04003D1D RID: 15645
		private int int_4;

		// Token: 0x04003D1E RID: 15646
		private int int_5;

		// Token: 0x04003D1F RID: 15647
		private int int_6;

		// Token: 0x04003D20 RID: 15648
		private int int_7;

		// Token: 0x04003D21 RID: 15649
		private int int_8;

		// Token: 0x04003D22 RID: 15650
		private int int_9;

		// Token: 0x04003D23 RID: 15651
		private int int_10;

		// Token: 0x04003D24 RID: 15652
		private int int_11;

		// Token: 0x04003D25 RID: 15653
		private int int_12;

		// Token: 0x04003D26 RID: 15654
		private int int_13;

		// Token: 0x04003D27 RID: 15655
		private int int_14;

		// Token: 0x04003D28 RID: 15656
		private int int_15;

		// Token: 0x04003D29 RID: 15657
		private int int_16;

		// Token: 0x04003D2A RID: 15658
		private int int_17;

		// Token: 0x04003D2B RID: 15659
		private int int_18;

		// Token: 0x04003D2C RID: 15660
		private int int_19;

		// Token: 0x04003D2D RID: 15661
		private int int_20;

		// Token: 0x04003D2E RID: 15662
		private unsafe int* pInt_0;

		// Token: 0x04003D2F RID: 15663
		private unsafe int* pInt_1;

		// Token: 0x04003D30 RID: 15664
		private unsafe int* pInt_2;

		// Token: 0x04003D31 RID: 15665
		private unsafe int* pInt_3;

		// Token: 0x04003D32 RID: 15666
		private unsafe int* pInt_4;

		// Token: 0x04003D33 RID: 15667
		private unsafe int* pInt_5;

		// Token: 0x04003D34 RID: 15668
		private unsafe int* pInt_6;

		// Token: 0x04003D35 RID: 15669
		private unsafe int* pInt_7;

		// Token: 0x04003D36 RID: 15670
		private int[] int_21;

		// Token: 0x04003D37 RID: 15671
		private int[] int_22;

		// Token: 0x04003D38 RID: 15672
		private int[] int_23;

		// Token: 0x04003D39 RID: 15673
		private int[] int_24;

		// Token: 0x04003D3A RID: 15674
		private int[] int_25;

		// Token: 0x04003D3B RID: 15675
		private int[] int_26;

		// Token: 0x04003D3C RID: 15676
		private int int_27;

		// Token: 0x04003D3D RID: 15677
		private int int_28;

		// Token: 0x04003D3E RID: 15678
		private int int_29;

		// Token: 0x04003D3F RID: 15679
		private uint[] uint_0;

		// Token: 0x04003D40 RID: 15680
		private object[] object_0;

		// Token: 0x04003D41 RID: 15681
		private int int_30;

		// Token: 0x04003D42 RID: 15682
		private uint uint_1;

		// Token: 0x04003D43 RID: 15683
		private unsafe byte* pByte_0;

		// Token: 0x04003D44 RID: 15684
		private unsafe byte* pByte_1;

		// Token: 0x04003D45 RID: 15685
		private int int_31;

		// Token: 0x04003D46 RID: 15686
		private int int_32;

		// Token: 0x04003D47 RID: 15687
		private int int_33;

		// Token: 0x04003D48 RID: 15688
		private int int_34;

		// Token: 0x04003D49 RID: 15689
		private unsafe int* pInt_8;

		// Token: 0x04003D4A RID: 15690
		private unsafe int* pInt_9;

		// Token: 0x04003D4B RID: 15691
		private unsafe int* pInt_10;

		// Token: 0x04003D4C RID: 15692
		private unsafe int* pInt_11;

		// Token: 0x04003D4D RID: 15693
		private int[] int_35;

		// Token: 0x04003D4E RID: 15694
		private int[] int_36;

		// Token: 0x04003D4F RID: 15695
		private int[] int_37;

		// Token: 0x04003D50 RID: 15696
		private int[] int_38;

		// Token: 0x04003D51 RID: 15697
		private int int_39;

		// Token: 0x04003D52 RID: 15698
		private int int_40;

		// Token: 0x04003D53 RID: 15699
		private int int_41;

		// Token: 0x04003D54 RID: 15700
		private int int_42;

		// Token: 0x04003D55 RID: 15701
		private unsafe int* pInt_12;

		// Token: 0x04003D56 RID: 15702
		private unsafe int* pInt_13;

		// Token: 0x04003D57 RID: 15703
		private unsafe int* pInt_14;

		// Token: 0x04003D58 RID: 15704
		private unsafe int* pInt_15;

		// Token: 0x04003D59 RID: 15705
		private unsafe int* pInt_16;

		// Token: 0x04003D5A RID: 15706
		private unsafe int* pInt_17;

		// Token: 0x04003D5B RID: 15707
		private unsafe int* pInt_18;

		// Token: 0x04003D5C RID: 15708
		private unsafe int* pInt_19;

		// Token: 0x04003D5D RID: 15709
		private unsafe int* pInt_20;

		// Token: 0x04003D5E RID: 15710
		private unsafe int* pInt_21;

		// Token: 0x04003D5F RID: 15711
		private unsafe int* pInt_22;

		// Token: 0x04003D60 RID: 15712
		private unsafe int* pInt_23;

		// Token: 0x04003D61 RID: 15713
		private unsafe int* pInt_24;

		// Token: 0x04003D62 RID: 15714
		private int[] int_43;

		// Token: 0x04003D63 RID: 15715
		private int[] int_44;

		// Token: 0x04003D64 RID: 15716
		private int[] int_45;

		// Token: 0x04003D65 RID: 15717
		private int[] int_46;

		// Token: 0x04003D66 RID: 15718
		private int[] int_47;

		// Token: 0x04003D67 RID: 15719
		private int[] int_48;

		// Token: 0x04003D68 RID: 15720
		private int[] int_49;

		// Token: 0x04003D69 RID: 15721
		private int[] int_50;

		// Token: 0x04003D6A RID: 15722
		private int[] int_51;

		// Token: 0x04003D6B RID: 15723
		private int[] int_52;

		// Token: 0x04003D6C RID: 15724
		private int[] int_53;

		// Token: 0x04003D6D RID: 15725
		private int[] int_54;

		// Token: 0x04003D6E RID: 15726
		private int[] int_55;

		// Token: 0x04003D6F RID: 15727
		private int[] int_56;

		// Token: 0x04003D70 RID: 15728
		private unsafe int* pInt_25;

		// Token: 0x04003D71 RID: 15729
		private unsafe int* pInt_26;

		// Token: 0x04003D72 RID: 15730
		private unsafe int* pInt_27;

		// Token: 0x04003D73 RID: 15731
		private unsafe int* pInt_28;

		// Token: 0x04003D74 RID: 15732
		private unsafe int* pInt_29;

		// Token: 0x04003D75 RID: 15733
		private bool bool_0;

		// Token: 0x04003D76 RID: 15734
		private bool bool_1;

		// Token: 0x04003D77 RID: 15735
		private static byte[] byte_0 = new byte[1];
	}
}
