using System;
using System.IO;

namespace ns14
{
	// Token: 0x02000463 RID: 1123
	public sealed class Class661 : BinaryReader
	{
		// Token: 0x06001CCB RID: 7371 RVA: 0x00011EF0 File Offset: 0x000100F0
		public Class661(Stream stream_0) : base(stream_0)
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000B5994 File Offset: 0x000B3B94
		public int method_0()
		{
			byte[] array = new byte[4];
			this.Read(array, 0, 4);
			Array.Reverse(array);
			return BitConverter.ToInt32(array, 0);
		}
	}
}
