using System;

namespace ns6
{
	// Token: 0x02000C91 RID: 3217
	public sealed class Class390
	{
		// Token: 0x06006AA4 RID: 27300 RVA: 0x00393C5C File Offset: 0x00391E5C
		internal static uint smethod_0(uint uint_0, int int_0)
		{
			uint_0 = ((uint_0 & 65535u) << 16 | uint_0 >> 16);
			uint_0 = ((uint_0 & 16711935u) << 8 | (uint_0 & 4278255360u) >> 8);
			uint_0 = ((uint_0 & 252645135u) << 4 | (uint_0 & 4042322160u) >> 4);
			uint_0 = ((uint_0 & 858993459u) << 2 | (uint_0 & 3435973836u) >> 2);
			uint_0 = ((uint_0 & 1431655765u) << 1 | (uint_0 & 2863311530u) >> 1);
			return uint_0 >> 32 - int_0;
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00393CDC File Offset: 0x00391EDC
		internal unsafe static void smethod_1(byte* pByte_0, byte* pByte_1, int int_0)
		{
			while (int_0 >= 16)
			{
				*pByte_1 = *pByte_0;
				pByte_1[1] = pByte_0[1];
				pByte_1[2] = pByte_0[2];
				pByte_1[3] = pByte_0[3];
				pByte_1[4] = pByte_0[4];
				pByte_1[5] = pByte_0[5];
				pByte_1[6] = pByte_0[6];
				pByte_1[7] = pByte_0[7];
				pByte_1[8] = pByte_0[8];
				pByte_1[9] = pByte_0[9];
				pByte_1[10] = pByte_0[10];
				pByte_1[11] = pByte_0[11];
				pByte_1[12] = pByte_0[12];
				pByte_1[13] = pByte_0[13];
				pByte_1[14] = pByte_0[14];
				pByte_1[15] = pByte_0[15];
				int_0 -= 16;
				pByte_0 += 16;
				pByte_1 += 16;
			}
			while (int_0 >= 4)
			{
				*pByte_1 = *pByte_0;
				pByte_1[1] = pByte_0[1];
				pByte_1[2] = pByte_0[2];
				pByte_1[3] = pByte_0[3];
				int_0 -= 4;
				pByte_0 += 4;
				pByte_1 += 4;
			}
			if (int_0 < 2)
			{
				if (int_0 == 1)
				{
					*pByte_1 = *pByte_0;
				}
			}
			else if (int_0 == 2)
			{
				*pByte_1 = *pByte_0;
				pByte_1[1] = pByte_0[1];
			}
			else
			{
				*pByte_1 = *pByte_0;
				pByte_1[1] = pByte_0[1];
				pByte_1[2] = pByte_0[2];
			}
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00393E40 File Offset: 0x00392040
		internal unsafe static void smethod_2(int int_0, int* pInt_0, int int_1)
		{
			while (int_1 >= 16)
			{
				*pInt_0 = int_0;
				pInt_0[1] = int_0;
				pInt_0[2] = int_0;
				pInt_0[3] = int_0;
				pInt_0[4] = int_0;
				pInt_0[5] = int_0;
				pInt_0[6] = int_0;
				pInt_0[7] = int_0;
				pInt_0[8] = int_0;
				pInt_0[9] = int_0;
				pInt_0[10] = int_0;
				pInt_0[11] = int_0;
				pInt_0[12] = int_0;
				pInt_0[13] = int_0;
				pInt_0[14] = int_0;
				pInt_0[15] = int_0;
				int_1 -= 16;
				pInt_0 += 16;
			}
			while (int_1 >= 4)
			{
				*pInt_0 = int_0;
				pInt_0[1] = int_0;
				pInt_0[2] = int_0;
				pInt_0[3] = int_0;
				int_1 -= 4;
				pInt_0 += 4;
			}
			if (int_1 < 2)
			{
				if (int_1 == 1)
				{
					*pInt_0 = int_0;
				}
			}
			else if (int_1 == 2)
			{
				*pInt_0 = int_0;
				pInt_0[1] = int_0;
			}
			else
			{
				*pInt_0 = int_0;
				pInt_0[1] = int_0;
				pInt_0[2] = int_0;
			}
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class390()
		{
		}
	}
}
