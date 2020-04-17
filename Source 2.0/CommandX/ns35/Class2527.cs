using System;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace ns35
{
	// Token: 0x02000AF3 RID: 2803
	public sealed class Class2527 : IDisposable
	{
		// Token: 0x06005A80 RID: 23168 RVA: 0x00282A60 File Offset: 0x00280C60
		public SafeFileHandle method_0()
		{
			return this.safeFileHandle_0;
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x00028AD8 File Offset: 0x00026CD8
		protected  void vmethod_0(bool bool_1)
		{
			if (!this.bool_0 && bool_1)
			{
				this.method_0().Close();
			}
			this.bool_0 = true;
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x00028AFD File Offset: 0x00026CFD
		public void Dispose()
		{
			this.vmethod_0(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04002CEB RID: 11499
		private SafeFileHandle safeFileHandle_0;

		// Token: 0x04002CEC RID: 11500
		private bool bool_0;

		// Token: 0x02000AF4 RID: 2804
		private sealed class Class2528 : IAsyncResult
		{
			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x06005A84 RID: 23172 RVA: 0x00028B0C File Offset: 0x00026D0C
			public bool IsCompleted
			{
				get
				{
					return this.bool_0;
				}
			}

			// Token: 0x1700047C RID: 1148
			// (get) Token: 0x06005A85 RID: 23173 RVA: 0x00282A78 File Offset: 0x00280C78
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return this.waitHandle_0;
				}
			}

			// Token: 0x1700047D RID: 1149
			// (get) Token: 0x06005A86 RID: 23174 RVA: 0x00282A90 File Offset: 0x00280C90
			public object AsyncState
			{
				get
				{
					return this.object_0;
				}
			}

			// Token: 0x1700047E RID: 1150
			// (get) Token: 0x06005A87 RID: 23175 RVA: 0x00028B14 File Offset: 0x00026D14
			public bool CompletedSynchronously
			{
				get
				{
					return this.bool_1;
				}
			}

			// Token: 0x04002CED RID: 11501
			private WaitHandle waitHandle_0;

			// Token: 0x04002CEE RID: 11502
			private object object_0;

			// Token: 0x04002CEF RID: 11503
			private bool bool_0;

			// Token: 0x04002CF0 RID: 11504
			private bool bool_1;
		}
	}
}
