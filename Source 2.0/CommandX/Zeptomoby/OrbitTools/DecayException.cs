using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Zeptomoby.OrbitTools
{
	// Token: 0x0200041B RID: 1051
	[Serializable]
	public sealed class DecayException : PropagationException
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x00004BC2 File Offset: 0x00002DC2
		[CompilerGenerated]
		private void method_0(DateTime dateTime_0)
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00004BC2 File Offset: 0x00002DC2
		[CompilerGenerated]
		private void method_1(string string_0)
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00011131 File Offset: 0x0000F331
		public DecayException()
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00011139 File Offset: 0x0000F339
		public DecayException(DateTime dateTime_0, string string_0)
		{
			this.method_0(dateTime_0);
			this.method_1(string_0);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0001114F File Offset: 0x0000F34F
		private DecayException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
		{
		}
	}
}
