using System;
using System.IO;
using System.Security.Cryptography;
using ns31;

namespace ns32
{
	// Token: 0x020004DB RID: 1243
	public sealed class Class2453
	{
		// Token: 0x06002052 RID: 8274 RVA: 0x00013768 File Offset: 0x00011968
		public Class2453(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.byte_0 = new byte[4096];
			this.byte_1 = this.byte_0;
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000D3ADC File Offset: 0x000D1CDC
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x000D3AF4 File Offset: 0x000D1CF4
		public int method_1()
		{
			return this.int_2;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0001379A File Offset: 0x0001199A
		public void method_2(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x000137A3 File Offset: 0x000119A3
		public void method_3(Class2451 class2451_0)
		{
			if (this.int_2 > 0)
			{
				class2451_0.method_6(this.byte_1, this.int_1 - this.int_2, this.int_2);
				this.int_2 = 0;
			}
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x000D3B0C File Offset: 0x000D1D0C
		public void method_4()
		{
			this.int_0 = 0;
			int i = this.byte_0.Length;
			while (i > 0)
			{
				int num = this.stream_0.Read(this.byte_0, this.int_0, i);
				if (num > 0)
				{
					this.int_0 += num;
					i -= num;
				}
				else
				{
					if (this.int_0 == 0)
					{
						throw new Exception30("Unexpected EOF");
					}
					if (this.icryptoTransform_0 != null)
					{
						this.int_1 = this.icryptoTransform_0.TransformBlock(this.byte_0, 0, this.int_0, this.byte_1, 0);
					}
					else
					{
						this.int_1 = this.int_0;
					}
					this.int_2 = this.int_1;
					return;
				}
			}
			if (this.icryptoTransform_0 != null)
			{
				this.int_1 = this.icryptoTransform_0.TransformBlock(this.byte_0, 0, this.int_0, this.byte_1, 0);
			}
			else
			{
				this.int_1 = this.int_0;
			}
			this.int_2 = this.int_1;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000D3C14 File Offset: 0x000D1E14
		public int method_5(byte[] byte_3)
		{
			return this.method_6(byte_3, 0, byte_3.Length);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000D3C30 File Offset: 0x000D1E30
		public int method_6(byte[] byte_3, int int_3, int int_4)
		{
			if (int_4 <= 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			int num = int_3;
			int i = int_4;
			int result;
			while (i > 0)
			{
				if (this.int_2 <= 0)
				{
					this.method_4();
					if (this.int_2 <= 0)
					{
						result = 0;
						return result;
					}
				}
				int num2 = Math.Min(i, this.int_2);
				Array.Copy(this.byte_0, this.int_0 - this.int_2, byte_3, num, num2);
				num += num2;
				i -= num2;
				this.int_2 -= num2;
			}
			result = int_4;
			return result;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000D3CBC File Offset: 0x000D1EBC
		public int method_7(byte[] byte_3, int int_3, int int_4)
		{
			if (int_4 <= 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			int num = int_3;
			int i = int_4;
			int result;
			while (i > 0)
			{
				if (this.int_2 <= 0)
				{
					this.method_4();
					if (this.int_2 <= 0)
					{
						result = 0;
						return result;
					}
				}
				int num2 = Math.Min(i, this.int_2);
				Array.Copy(this.byte_1, this.int_1 - this.int_2, byte_3, num, num2);
				num += num2;
				i -= num2;
				this.int_2 -= num2;
			}
			result = int_4;
			return result;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000D3D48 File Offset: 0x000D1F48
		public int method_8()
		{
			if (this.int_2 <= 0)
			{
				this.method_4();
				if (this.int_2 <= 0)
				{
					throw new Exception31("EOF in header");
				}
			}
			byte result = (byte)(this.byte_0[this.int_0 - this.int_2] & 255);
			this.int_2--;
			return (int)result;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000D3DAC File Offset: 0x000D1FAC
		public int method_9()
		{
			return this.method_8() | this.method_8() << 8;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000D3DCC File Offset: 0x000D1FCC
		public int method_10()
		{
			return this.method_9() | this.method_9() << 16;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000D3DEC File Offset: 0x000D1FEC
		public void method_11(ICryptoTransform icryptoTransform_1)
		{
			this.icryptoTransform_0 = icryptoTransform_1;
			if (this.icryptoTransform_0 != null)
			{
				if (this.byte_0 == this.byte_1)
				{
					if (this.byte_2 == null)
					{
						this.byte_2 = new byte[4096];
					}
					this.byte_1 = this.byte_2;
				}
				this.int_1 = this.int_0;
				if (this.int_2 > 0)
				{
					this.icryptoTransform_0.TransformBlock(this.byte_0, this.int_0 - this.int_2, this.int_2, this.byte_1, this.int_0 - this.int_2);
				}
			}
			else
			{
				this.byte_1 = this.byte_0;
				this.int_1 = this.int_0;
			}
		}

		// Token: 0x04000FB7 RID: 4023
		private int int_0;

		// Token: 0x04000FB8 RID: 4024
		private byte[] byte_0;

		// Token: 0x04000FB9 RID: 4025
		private int int_1;

		// Token: 0x04000FBA RID: 4026
		private byte[] byte_1;

		// Token: 0x04000FBB RID: 4027
		private byte[] byte_2;

		// Token: 0x04000FBC RID: 4028
		private int int_2 = 0;

		// Token: 0x04000FBD RID: 4029
		private ICryptoTransform icryptoTransform_0;

		// Token: 0x04000FBE RID: 4030
		private Stream stream_0;
	}
}
