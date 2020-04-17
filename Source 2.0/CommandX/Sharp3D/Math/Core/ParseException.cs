using System;
using System.Runtime.Serialization;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000340 RID: 832
	[Serializable]
	public sealed class ParseException : Sharp3DMathException
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x0000E191 File Offset: 0x0000C391
		public ParseException()
		{
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0000E199 File Offset: 0x0000C399
		public ParseException(string string_0) : base(string_0)
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0000E1A2 File Offset: 0x0000C3A2
		protected ParseException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
		{
		}
	}
}
