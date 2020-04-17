using System;

namespace ns6
{
	// Token: 0x02000C72 RID: 3186
	internal static class Class395
	{
		// Token: 0x060069FC RID: 27132 RVA: 0x0038F990 File Offset: 0x0038DB90
		public static int smethod_0(byte[] byte_0, int int_0, Enum118 enum118_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			if (int_0 + 4 > byte_0.Length)
			{
				throw new ArgumentException("startIndex invalid (not enough space in value to extract an integer", "startIndex");
			}
			int result;
			if (BitConverter.IsLittleEndian && enum118_0 == Enum118.const_0)
			{
				byte[] array = new byte[4];
				Array.Copy(byte_0, int_0, array, 0, 4);
				Array.Reverse(array);
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = BitConverter.ToInt32(byte_0, int_0);
			}
			return result;
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x0038FA0C File Offset: 0x0038DC0C
		public static double smethod_1(byte[] byte_0, int int_0, Enum118 enum118_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			if (int_0 + 8 > byte_0.Length)
			{
				throw new ArgumentException("startIndex invalid (not enough space in value to extract a double", "startIndex");
			}
			double result;
			if (BitConverter.IsLittleEndian && enum118_0 == Enum118.const_0)
			{
				byte[] array = new byte[8];
				Array.Copy(byte_0, int_0, array, 0, 8);
				Array.Reverse(array);
				result = BitConverter.ToDouble(array, 0);
			}
			else
			{
				result = BitConverter.ToDouble(byte_0, int_0);
			}
			return result;
		}
	}
}
