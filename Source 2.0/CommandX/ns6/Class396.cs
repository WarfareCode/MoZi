using System;

namespace ns6
{
	// Token: 0x02000C77 RID: 3191
	public sealed class Class396
	{
		// Token: 0x06006A09 RID: 27145 RVA: 0x0038FD28 File Offset: 0x0038DF28
		public Class396(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("headerBytes");
			}
			if (byte_0.Length != 100)
			{
				throw new InvalidOperationException(string.Format("headerBytes must be {0} bytes long", 100));
			}
			this.int_0 = Class395.smethod_0(byte_0, 0, Enum118.const_0);
			if (this.int_0 != 9994)
			{
				throw new InvalidOperationException(string.Format("Header File code is {0}, expected {1}", this.int_0, 9994));
			}
			this.int_2 = Class395.smethod_0(byte_0, 28, Enum118.const_1);
			if (this.int_2 != 1000)
			{
				throw new InvalidOperationException(string.Format("Header version is {0}, expected {1}", this.int_2, 1000));
			}
			this.int_1 = Class395.smethod_0(byte_0, 24, Enum118.const_0);
			this.enum119_0 = (Enum119)Class395.smethod_0(byte_0, 32, Enum118.const_1);
			this.double_0 = Class395.smethod_1(byte_0, 36, Enum118.const_1);
			this.double_1 = Class395.smethod_1(byte_0, 44, Enum118.const_1);
			this.double_2 = Class395.smethod_1(byte_0, 52, Enum118.const_1);
			this.double_3 = Class395.smethod_1(byte_0, 60, Enum118.const_1);
			this.double_4 = Class395.smethod_1(byte_0, 68, Enum118.const_1);
			this.double_5 = Class395.smethod_1(byte_0, 76, Enum118.const_1);
			this.double_6 = Class395.smethod_1(byte_0, 84, Enum118.const_1);
			this.double_7 = Class395.smethod_1(byte_0, 92, Enum118.const_1);
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x0038FEEC File Offset: 0x0038E0EC
		public int method_0()
		{
			return this.int_1;
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x0038FF04 File Offset: 0x0038E104
		public Enum119 method_1()
		{
			return this.enum119_0;
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x0038FF1C File Offset: 0x0038E11C
		public double method_2()
		{
			return this.double_0;
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x0038FF34 File Offset: 0x0038E134
		public double method_3()
		{
			return this.double_1;
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x0038FF4C File Offset: 0x0038E14C
		public double method_4()
		{
			return this.double_2;
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x0038FF64 File Offset: 0x0038E164
		public double method_5()
		{
			return this.double_3;
		}

		// Token: 0x04003BC5 RID: 15301
		private int int_0;

		// Token: 0x04003BC6 RID: 15302
		private int int_1;

		// Token: 0x04003BC7 RID: 15303
		private int int_2 = 0;

		// Token: 0x04003BC8 RID: 15304
		private Enum119 enum119_0;

		// Token: 0x04003BC9 RID: 15305
		private double double_0;

		// Token: 0x04003BCA RID: 15306
		private double double_1;

		// Token: 0x04003BCB RID: 15307
		private double double_2 = 0.0;

		// Token: 0x04003BCC RID: 15308
		private double double_3 = 0.0;

		// Token: 0x04003BCD RID: 15309
		private double double_4 = 0.0;

		// Token: 0x04003BCE RID: 15310
		private double double_5 = 0.0;

		// Token: 0x04003BCF RID: 15311
		private double double_6 = 0.0;

		// Token: 0x04003BD0 RID: 15312
		private double double_7 = 0.0;
	}
}
