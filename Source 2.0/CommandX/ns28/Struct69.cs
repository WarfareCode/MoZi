using System;

namespace ns28
{
	// Token: 0x02000806 RID: 2054
	internal sealed class Struct69
	{
		// Token: 0x060032BD RID: 12989 RVA: 0x0001B32E File Offset: 0x0001952E
		public Struct69(long long_1, ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
			this.long_0 = long_1;
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x0001B344 File Offset: 0x00019544
		public static bool smethod_0(Struct69 struct69_0, Struct69 struct69_1)
		{
			return struct69_0 == struct69_1 || (struct69_0 != null && struct69_1 != null && struct69_0.long_0 == struct69_1.long_0 && struct69_0.ulong_0 == struct69_1.ulong_0);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00118D38 File Offset: 0x00116F38
		public override bool Equals(object obj)
		{
			bool result;
			if (obj != null && obj is Struct69)
			{
				Struct69 @struct = (Struct69)obj;
				result = (@struct.long_0 == this.long_0 && @struct.ulong_0 == this.ulong_0);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00118D88 File Offset: 0x00116F88
		public override int GetHashCode()
		{
			return this.long_0.GetHashCode() ^ this.ulong_0.GetHashCode();
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x00118DB0 File Offset: 0x00116FB0
		public static Struct69 smethod_1(Struct69 struct69_0)
		{
			Struct69 result;
			if (struct69_0.ulong_0 == 0uL)
			{
				result = new Struct69(-struct69_0.long_0, 0uL);
			}
			else
			{
				result = new Struct69(~struct69_0.long_0, ~struct69_0.ulong_0 + 1uL);
			}
			return result;
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00118E0C File Offset: 0x0011700C
		public static Struct69 smethod_2(long long_1, long long_2)
		{
			bool flag = long_1 < 0L != long_2 < 0L;
			if (long_1 < 0L)
			{
				long_1 = -long_1;
			}
			if (long_2 < 0L)
			{
				long_2 = -long_2;
			}
			ulong num = (ulong)long_1 >> 32;
			ulong num2 = (ulong)(long_1 & -1L);
			ulong num3 = (ulong)long_2 >> 32;
			ulong num4 = (ulong)(long_2 & -1L);
			ulong num5 = num * num3;
			ulong num6 = num2 * num4;
			ulong num7 = num * num4 + num2 * num3;
			long num8 = (long)(num5 + (num7 >> 32));
			ulong num9 = (num7 << 32) + num6;
			if (num9 < num6)
			{
				num8 += 1L;
			}
			Struct69 @struct = new Struct69(num8, num9);
			Struct69 result;
			if (!flag)
			{
				result = @struct;
			}
			else
			{
				result = Struct69.smethod_1(@struct);
			}
			return result;
		}

		// Token: 0x0400179E RID: 6046
		private long long_0;

		// Token: 0x0400179F RID: 6047
		private ulong ulong_0;
	}
}
