using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns35
{
	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	public sealed class Class2541
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x000588FC File Offset: 0x00056AFC
		public static uint smethod_0(string string_0)
		{
			uint num = 2166136261u;
			if (string_0 != null)
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					num = ((uint)string_0[i] ^ num) * 16777619u;
				}
			}
			return num;
		}

		// Token: 0x04000090 RID: 144
		public static readonly Class2541.Struct89 struct89_0;

		// Token: 0x04000091 RID: 145
		public static readonly Class2541.Struct89 struct89_1;

		// Token: 0x02000020 RID: 32
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		public struct Struct89
		{
		}
	}
}
