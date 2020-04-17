using System;
using System.Security.Cryptography;
using ns31;

namespace ns32
{
	// Token: 0x02000501 RID: 1281
	public abstract class Class2459 : SymmetricAlgorithm
	{
		// Token: 0x06002170 RID: 8560 RVA: 0x000DB558 File Offset: 0x000D9758
		public static byte[] smethod_0(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("seed");
			}
			if (byte_0.Length == 0)
			{
				throw new ArgumentException("seed");
			}
			uint[] array = new uint[]
			{
				305419896u,
				591751049u,
				878082192u
			};
			for (int i = 0; i < byte_0.Length; i++)
			{
				array[0] = Class2436.smethod_0(array[0], byte_0[i]);
				array[1] = array[1] + (uint)((byte)array[0]);
				array[1] = array[1] * 134775813u + 1u;
				array[2] = Class2436.smethod_0(array[2], (byte)(array[1] >> 24));
			}
			return new byte[]
			{
				(byte)(array[0] & 255u),
				(byte)(array[0] >> 8 & 255u),
				(byte)(array[0] >> 16 & 255u),
				(byte)(array[0] >> 24 & 255u),
				(byte)(array[1] & 255u),
				(byte)(array[1] >> 8 & 255u),
				(byte)(array[1] >> 16 & 255u),
				(byte)(array[1] >> 24 & 255u),
				(byte)(array[2] & 255u),
				(byte)(array[2] >> 8 & 255u),
				(byte)(array[2] >> 16 & 255u),
				(byte)(array[2] >> 24 & 255u)
			};
		}
	}
}
