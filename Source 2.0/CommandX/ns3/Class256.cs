using System;
using System.IO;
using Command_Core;
using ns31;
using ns6;
using SevenZip;

namespace ns3
{
	// Token: 0x02000BC6 RID: 3014
	public sealed class Class256
	{
		// Token: 0x06006403 RID: 25603 RVA: 0x00316064 File Offset: 0x00314264
		public static Stream1 CompressStream(Stream stream_, CompressionLevel compressionLevel_)
		{
			Stream1 stream = new Stream1();
			new SevenZipCompressor
			{
				CompressionMethod = CompressionMethod.Lzma,
				CompressionLevel = compressionLevel_
			}.CompressStream(stream_, stream, GameGeneral.strPassword);
			return stream;
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x0031609C File Offset: 0x0031429C
		public static byte[] smethod_1(Stream stream_0, Enum117 enum117_0)
		{
			byte[] array = new byte[(int)stream_0.Length + 1];
			if (stream_0.GetType() == typeof(Stream1))
			{
				array = ((Stream1)stream_0).ToArray();
			}
			else if (stream_0.GetType() == typeof(MemoryStream))
			{
				array = ((MemoryStream)stream_0).GetBuffer();
			}
			return new Class392().method_26(array, 0, array.Length, enum117_0, 0, 0);
		}
	}
}
