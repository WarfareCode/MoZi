using System;
using System.Runtime.Serialization;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000335 RID: 821
	[Serializable]
	public class Sharp3DMathException : ApplicationException
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x0000DF86 File Offset: 0x0000C186
		public Sharp3DMathException()
		{
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0000DF8E File Offset: 0x0000C18E
		public Sharp3DMathException(string string_0) : base(string_0)
		{
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0000DF97 File Offset: 0x0000C197
		protected Sharp3DMathException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
		{
		}
	}
}
