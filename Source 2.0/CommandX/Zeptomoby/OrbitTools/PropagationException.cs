using System;
using System.Runtime.Serialization;

namespace Zeptomoby.OrbitTools
{
	// Token: 0x0200041A RID: 1050
	[Serializable]
	public class PropagationException : Exception
	{
		// Token: 0x06001A95 RID: 6805 RVA: 0x0001111F File Offset: 0x0000F31F
		public PropagationException()
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00006F02 File Offset: 0x00005102
		public PropagationException(string string_0) : base(string_0)
		{
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00011127 File Offset: 0x0000F327
		protected PropagationException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
		{
		}
	}
}
