using System;
using System.Security.Cryptography;

namespace ns32
{
	// Token: 0x02000503 RID: 1283
	public sealed class Class2462 : Class2461, IDisposable, ICryptoTransform
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x0000945D File Offset: 0x0000765D
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x0000945D File Offset: 0x0000765D
		public int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x0000945D File Offset: 0x0000765D
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x0000945D File Offset: 0x0000765D
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00013FE0 File Offset: 0x000121E0
		internal Class2462(byte[] byte_0)
		{
			base.method_1(byte_0);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000DB7F0 File Offset: 0x000D99F0
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000DB814 File Offset: 0x000D9A14
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			for (int i = inputOffset; i < inputOffset + inputCount; i++)
			{
				byte byte_ = inputBuffer[i];
				outputBuffer[outputOffset++] = (byte)(inputBuffer[i] ^ base.method_0());
				base.method_2(byte_);
			}
			return inputCount;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00013FEF File Offset: 0x000121EF
		public void Dispose()
		{
			base.method_3();
		}
	}
}
