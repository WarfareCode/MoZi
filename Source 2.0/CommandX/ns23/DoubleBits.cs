using System;
using ns28;

namespace ns23
{
	// Token: 0x0200068A RID: 1674
	public sealed class DoubleBits
	{
		// Token: 0x06002A84 RID: 10884 RVA: 0x000173B3 File Offset: 0x000155B3
		public DoubleBits(double double_1)
		{
			this._x = double_1;
			this._xBits = BitConverter.DoubleToInt64Bits(double_1);
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x000FEBC8 File Offset: 0x000FCDC8
		public  int GetBiasedExponent()
		{
			int num = (int)(this._xBits >> 52);
			return num & 2047;
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x000FEBEC File Offset: 0x000FCDEC
		public  int GetExponent()
		{
			return this.GetBiasedExponent() - 1023;
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000FEC08 File Offset: 0x000FCE08
		public static double PowerOf2(int exp)
		{
			if (exp > 1023 || exp < -1022)
			{
				throw new ArgumentException("Exponent out of bounds");
			}
			long num = (long)(exp + 1023);
			long value = num << 52;
			return BitConverter.Int64BitsToDouble(value);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000FEC50 File Offset: 0x000FCE50
		public static int GetExponent(double d)
		{
			DoubleBits doubleBits = new DoubleBits(d);
			return doubleBits.GetExponent();
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x000FEC6C File Offset: 0x000FCE6C
		public override string ToString()
		{
			string str = HexConverter.ConvertAny2Any(this._xBits.ToString(), 10, 2);
			string text = "0000000000000000000000000000000000000000000000000000000000000000" + str;
			string text2 = text.Substring(text.Length - 64);
			return string.Concat(new object[]
			{
				text2.Substring(0, 1),
				"  ",
				text2.Substring(1, 12),
				"(",
				this.GetExponent(),
				") ",
				text2.Substring(12),
				" [ ",
				this._x,
				" ]"
			});
		}

		// Token: 0x04001444 RID: 5188
		private readonly double _x;

		// Token: 0x04001445 RID: 5189
		private long _xBits;
	}
}
