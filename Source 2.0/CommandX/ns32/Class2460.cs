using System;
using System.Security.Cryptography;

namespace ns32
{
	// Token: 0x0200050F RID: 1295
	public sealed class Class2460 : Class2459
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0001413B File Offset: 0x0001233B
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x0001413E File Offset: 0x0001233E
		public override int BlockSize
		{
			get
			{
				return 8;
			}
			set
			{
				if (value != 8)
				{
					throw new CryptographicException();
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000DC27C File Offset: 0x000DA47C
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x0001414C File Offset: 0x0001234C
		public override byte[] Key
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x000DC294 File Offset: 0x000DA494
		public override KeySizes[] LegalBlockSizes
		{
			get
			{
				return new KeySizes[]
				{
					new KeySizes(8, 8, 0)
				};
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x000DC2B8 File Offset: 0x000DA4B8
		public override KeySizes[] LegalKeySizes
		{
			get
			{
				return new KeySizes[]
				{
					new KeySizes(96, 96, 0)
				};
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void GenerateIV()
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000DC2DC File Offset: 0x000DA4DC
		public override void GenerateKey()
		{
			this.byte_0 = new byte[12];
			Random random = new Random();
			random.NextBytes(this.byte_0);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000DC308 File Offset: 0x000DA508
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return new Class2462(rgbKey);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000DC320 File Offset: 0x000DA520
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return new Class2463(rgbKey);
		}

		// Token: 0x04001055 RID: 4181
		private byte[] byte_0;
	}
}
