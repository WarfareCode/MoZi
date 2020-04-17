using System;
using System.IO;
using ns13;

namespace ns12
{
	// Token: 0x0200038D RID: 909
	public sealed class Class591
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x0008D228 File Offset: 0x0008B428
		public int method_0()
		{
			return this.int_5;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0008D240 File Offset: 0x0008B440
		public int method_1()
		{
			return this.int_2;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0008D258 File Offset: 0x0008B458
		public int method_2()
		{
			return this.int_4;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0008D270 File Offset: 0x0008B470
		public int method_3()
		{
			return this.int_3;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0008D288 File Offset: 0x0008B488
		public void method_4(BinaryReader binaryReader_0)
		{
			this.int_1 = (int)binaryReader_0.ReadByte();
			if (this.int_1 != 3)
			{
				throw new NotSupportedException("Unsupported DBF reader Type " + this.int_1);
			}
			int num = (int)binaryReader_0.ReadByte();
			int month = (int)binaryReader_0.ReadByte();
			int day = (int)binaryReader_0.ReadByte();
			this.dateTime_0 = new DateTime(num + 1900, month, day);
			this.int_2 = binaryReader_0.ReadInt32();
			this.int_3 = (int)binaryReader_0.ReadInt16();
			this.int_4 = (int)binaryReader_0.ReadInt16();
			binaryReader_0.ReadBytes(20);
			this.int_5 = (this.int_3 - this.int_0 - 1) / this.int_0;
			this.class642_0 = new Class642[this.int_5];
			for (int i = 0; i < this.int_5; i++)
			{
				this.class642_0[i] = new Class642();
				char[] value = new char[11];
				value = binaryReader_0.ReadChars(11);
				string text = new string(value);
				int num2 = text.IndexOf('\0');
				if (num2 != -1)
				{
					text = text.Substring(0, num2);
				}
				this.class642_0[i].method_1(text);
				this.class642_0[i].method_3((char)binaryReader_0.ReadByte());
				this.class642_0[i].method_4(binaryReader_0.ReadInt32());
				int num3 = (int)binaryReader_0.ReadByte();
				if (num3 < 0)
				{
					num3 += 256;
				}
				this.class642_0[i].method_6(num3);
				this.class642_0[i].method_7((int)binaryReader_0.ReadByte());
				binaryReader_0.ReadBytes(14);
			}
			binaryReader_0.ReadBytes(1);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x0008D430 File Offset: 0x0008B630
		public Class642[] method_5()
		{
			return this.class642_0;
		}

		// Token: 0x04000921 RID: 2337
		private int int_0 = 32;

		// Token: 0x04000922 RID: 2338
		private int int_1 = 3;

		// Token: 0x04000923 RID: 2339
		private DateTime dateTime_0;

		// Token: 0x04000924 RID: 2340
		private int int_2 = 0;

		// Token: 0x04000925 RID: 2341
		private int int_3 = 0;

		// Token: 0x04000926 RID: 2342
		private int int_4;

		// Token: 0x04000927 RID: 2343
		private int int_5;

		// Token: 0x04000928 RID: 2344
		private Class642[] class642_0;
	}
}
