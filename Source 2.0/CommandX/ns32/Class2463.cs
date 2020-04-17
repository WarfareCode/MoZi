using System;
using System.Security.Cryptography;

namespace ns32
{
	// Token: 0x0200050B RID: 1291
	public sealed class Class2463 : Class2461, IDisposable, ICryptoTransform
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x0000945D File Offset: 0x0000765D
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x0000945D File Offset: 0x0000765D
		public int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x0000945D File Offset: 0x0000765D
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0000945D File Offset: 0x0000765D
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00013FE0 File Offset: 0x000121E0
		internal Class2463(byte[] byte_0)
		{
			base.method_1(byte_0);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000DBFA0 File Offset: 0x000DA1A0
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000DBFC4 File Offset: 0x000DA1C4
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			for (int i = inputOffset; i < inputOffset + inputCount; i++)
			{
				byte b = (byte)(inputBuffer[i] ^ base.method_0());
				outputBuffer[outputOffset++] = b;
				base.method_2(b);
			}
			return inputCount;
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00013FEF File Offset: 0x000121EF
		public void Dispose()
		{
			base.method_3();
		}
	}
}
