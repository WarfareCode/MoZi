using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Nini.Ini
{
	// Token: 0x020000FD RID: 253
	[Serializable]
	public sealed class IniException : SystemException
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00067470 File Offset: 0x00065670
		public override string Message
		{
			get
			{
				string result;
				if (this.iniReader == null)
				{
					result = base.Message;
				}
				else
				{
					result = string.Format(CultureInfo.InvariantCulture, "{0} - Line: {1}, Position: {2}.", new object[]
					{
						this.message,
						this.method_1(),
						this.method_0()
					});
				}
				return result;
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000674DC File Offset: 0x000656DC
		public int method_0()
		{
			return (this.iniReader == null) ? 0 : this.iniReader.method_4();
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00067504 File Offset: 0x00065704
		public int method_1()
		{
			return (this.iniReader == null) ? 0 : this.iniReader.method_3();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00006F81 File Offset: 0x00005181
		public IniException()
		{
			this.message = "An error has occurred";
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00006FA6 File Offset: 0x000051A6
		public IniException(string string_0) : base(string_0)
		{
			this.message = string_0;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00006FC8 File Offset: 0x000051C8
		internal IniException(IniReader iniReader_0, string string_0) : this(string_0)
		{
			this.iniReader = iniReader_0;
			this.message = string_0;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00006FDF File Offset: 0x000051DF
		protected IniException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0006752C File Offset: 0x0006572C
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (this.iniReader != null)
			{
				info.AddValue("lineNumber", this.iniReader.method_3());
				info.AddValue("linePosition", this.iniReader.method_4());
			}
		}

		// Token: 0x04000285 RID: 645
		private IniReader iniReader = null;

		// Token: 0x04000286 RID: 646
		private string message = "";
	}
}
