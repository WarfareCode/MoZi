using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace DiskQueue.Implementation
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public sealed class PendingWriteException : Exception
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00004AE2 File Offset: 0x00002CE2
		public PendingWriteException(Exception[] pendingWritesExceptions) : base("Error during pending writes")
		{
			this.pendingWritesExceptions = pendingWritesExceptions;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00055B6C File Offset: 0x00053D6C
		public Exception[] PendingWritesExceptions
		{
			get
			{
				return this.pendingWritesExceptions;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00055B84 File Offset: 0x00053D84
		public override string Message
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder(base.Message).Append(":");
				Exception[] array = this.pendingWritesExceptions;
				for (int i = 0; i < array.Length; i++)
				{
					Exception ex = array[i];
					stringBuilder.AppendLine().Append(" - ").Append(ex.Message);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00055BE8 File Offset: 0x00053DE8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(base.Message).Append(":");
			Exception[] array = this.pendingWritesExceptions;
			for (int i = 0; i < array.Length; i++)
			{
				Exception value = array[i];
				stringBuilder.AppendLine().Append(" - ").Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004AF6 File Offset: 0x00002CF6
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("PendingWritesExceptions", this.PendingWritesExceptions);
		}

		// Token: 0x0400003B RID: 59
		private readonly Exception[] pendingWritesExceptions;
	}
}
