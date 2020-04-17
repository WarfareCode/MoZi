using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x02000021 RID: 33
	[CompilerGenerated]
	public sealed class Class382
	{
		// Token: 0x060000EB RID: 235 RVA: 0x000588FC File Offset: 0x00056AFC
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

		// Token: 0x04000092 RID: 146
		public static readonly Class382.Struct41 struct41_0;

		// Token: 0x04000093 RID: 147
		public static readonly Class382.Struct42 struct42_0;

		// Token: 0x04000094 RID: 148
		public static readonly Class382.Struct40 struct40_0;

		// Token: 0x04000095 RID: 149
		public static readonly Class382.Struct42 struct42_1;

		// Token: 0x02000022 RID: 34
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
		public struct Struct40
		{
		}

		// Token: 0x02000023 RID: 35
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
		public struct Struct41
		{
		}

		// Token: 0x02000024 RID: 36
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 52)]
		public struct Struct42
		{
		}
	}
}
