using System;

namespace ns13
{
	// Token: 0x0200042C RID: 1068
	public sealed class Class642
	{
		// Token: 0x06001B6B RID: 7019 RVA: 0x000B0EF0 File Offset: 0x000AF0F0
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00011491 File Offset: 0x0000F691
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000B0F08 File Offset: 0x000AF108
		public char method_2()
		{
			return this.char_0;
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0001149A File Offset: 0x0000F69A
		public void method_3(char char_1)
		{
			this.char_0 = char_1;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000114A3 File Offset: 0x0000F6A3
		public void method_4(int int_3)
		{
			this.int_0 = int_3;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000B0F20 File Offset: 0x000AF120
		public int method_5()
		{
			return this.int_1;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000114AC File Offset: 0x0000F6AC
		public void method_6(int int_3)
		{
			this.int_1 = int_3;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000114B5 File Offset: 0x0000F6B5
		public void method_7(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000B0F38 File Offset: 0x000AF138
		public Type method_8()
		{
			char c = this.char_0;
			switch (c)
			{
			case 'B':
			{
				Type typeFromHandle = typeof(byte[]);
				Type result = typeFromHandle;
				return result;
			}
			case 'C':
			{
				Type typeFromHandle = typeof(string);
				Type result = typeFromHandle;
				return result;
			}
			case 'D':
			{
				Type typeFromHandle = typeof(DateTime);
				Type result = typeFromHandle;
				return result;
			}
			case 'E':
				break;
			case 'F':
			{
				Type typeFromHandle = typeof(float);
				Type result = typeFromHandle;
				return result;
			}
			default:
				switch (c)
				{
				case 'L':
				{
					Type typeFromHandle = typeof(bool);
					Type result = typeFromHandle;
					return result;
				}
				case 'N':
				{
					Type typeFromHandle = typeof(double);
					Type result = typeFromHandle;
					return result;
				}
				}
				break;
			}
			throw new NotSupportedException("Do not know how to parse Field type " + this.char_0);
		}

		// Token: 0x04000BBB RID: 3003
		private string string_0;

		// Token: 0x04000BBC RID: 3004
		private char char_0;

		// Token: 0x04000BBD RID: 3005
		private int int_0;

		// Token: 0x04000BBE RID: 3006
		private int int_1;

		// Token: 0x04000BBF RID: 3007
		private int int_2 = 0;
	}
}
