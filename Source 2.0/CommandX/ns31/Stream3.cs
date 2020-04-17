using System;
using System.IO;
using System.Text;
using ns32;

namespace ns31
{
	// Token: 0x020004A5 RID: 1189
	public sealed class Stream3 : Stream2
	{
		// Token: 0x06001F1F RID: 7967 RVA: 0x00012C6B File Offset: 0x00010E6B
		public Stream3(Stream stream_1) : base(stream_1, new Class2451(true))
		{
			this.delegate45_0 = new Stream3.Delegate45(this.method_7);
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00012CA5 File Offset: 0x00010EA5
		public void method_3(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000CD810 File Offset: 0x000CBA10
		public Class2437 method_4()
		{
			if (this.class2436_0 == null)
			{
				throw new InvalidOperationException("Closed.");
			}
			if (this.class2437_0 != null)
			{
				this.method_6();
			}
			int num = this.class2453_0.method_10();
			Class2437 result;
			if (num != 33639248 && num != 101010256 && num != 84233040 && num != 101075792)
			{
				if (num == 808471376 || num == 134695760)
				{
					num = this.class2453_0.method_10();
				}
				if (num != 67324752)
				{
					throw new Exception31("Wrong Local header signature: 0x" + string.Format("{0:X}", num));
				}
				short int_ = (short)this.class2453_0.method_9();
				this.int_1 = this.class2453_0.method_9();
				this.int_0 = this.class2453_0.method_9();
				uint num2 = (uint)this.class2453_0.method_10();
				int num3 = this.class2453_0.method_10();
				this.long_0 = (long)this.class2453_0.method_10();
				this.long_1 = (long)this.class2453_0.method_10();
				int num4 = this.class2453_0.method_9();
				int num5 = this.class2453_0.method_9();
				bool flag = (this.int_1 & 1) == 1;
				byte[] array = new byte[num4];
				this.class2453_0.method_5(array);
				string string_ = Class2438.smethod_2(array);
				this.class2437_0 = new Class2437(string_, (int)int_);
				this.class2437_0.method_1(this.int_1);
				bool arg_1C3_0;
				if (this.int_0 == 0)
				{
					if (!flag)
					{
						if (this.long_0 != this.long_1)
						{
							arg_1C3_0 = false;
							goto IL_1C3;
						}
					}
					arg_1C3_0 = (!flag || this.long_0 - 12L == this.long_1);
				}
				else
				{
					arg_1C3_0 = true;
				}
				IL_1C3:
				if (!arg_1C3_0)
				{
					throw new Exception31("Stored, but compressed != uncompressed");
				}
				if (this.int_0 != 0 && this.int_0 != 8)
				{
					throw new Exception31("Unknown compression method " + this.int_0);
				}
				this.class2437_0.method_14((Enum178)this.int_0);
				if ((this.int_1 & 8) == 0)
				{
					this.class2437_0.method_13((long)num3 & -1L);
					this.class2437_0.method_10(this.long_1 & -1L);
					this.class2437_0.method_11(this.long_0 & -1L);
				}
				else
				{
					if (num3 != 0)
					{
						this.class2437_0.method_13((long)num3 & -1L);
					}
					if (this.long_1 != 0L)
					{
						this.class2437_0.method_10(this.long_1 & -1L);
					}
					if (this.long_0 != 0L)
					{
						this.class2437_0.method_11(this.long_0 & -1L);
					}
				}
				this.class2437_0.method_6((long)((ulong)num2));
				if (num5 > 0)
				{
					byte[] array2 = new byte[num5];
					this.class2453_0.method_5(array2);
					this.class2437_0.method_15(array2);
				}
				this.delegate45_0 = new Stream3.Delegate45(this.method_7);
				result = this.class2437_0;
			}
			else
			{
				this.Close();
				result = null;
			}
			return result;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000CDB6C File Offset: 0x000CBD6C
		private void method_5()
		{
			if (this.class2453_0.method_10() != 134695760)
			{
				throw new Exception31("Data descriptor signature not found");
			}
			this.class2437_0.method_13((long)this.class2453_0.method_10() & -1L);
			this.long_0 = (long)this.class2453_0.method_10();
			this.long_1 = (long)this.class2453_0.method_10();
			this.class2437_0.method_10(this.long_1 & -1L);
			this.class2437_0.method_11(this.long_0 & -1L);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x000CDC14 File Offset: 0x000CBE14
		public void method_6()
		{
			if (this.class2436_0 == null)
			{
				throw new InvalidOperationException("Closed.");
			}
			if (this.class2437_0 != null)
			{
				if (this.int_0 == 8)
				{
					if ((this.int_1 & 8) != 0)
					{
						byte[] array = new byte[2048];
						while (this.Read(array, 0, array.Length) > 0)
						{
						}
						return;
					}
					this.long_0 -= (long)this.class2451_0.method_12();
					Class2453 class2453_ = this.class2453_0;
					class2453_.method_2(class2453_.method_1() - this.class2451_0.method_13());
				}
				if ((long)this.class2453_0.method_1() > this.long_0 && this.long_0 >= 0L)
				{
					this.class2453_0.method_2((int)((long)this.class2453_0.method_1() - this.long_0));
				}
				else
				{
					this.long_0 -= (long)this.class2453_0.method_1();
					this.class2453_0.method_2(0);
					while (this.long_0 != 0L)
					{
						int num = (int)base.method_1(this.long_0 & -1L);
						if (num <= 0)
						{
							throw new Exception31("Zip archive ends early.");
						}
						this.long_0 -= (long)num;
					}
				}
				this.long_1 = 0L;
				this.class2436_0.vmethod_0();
				if (this.int_0 == 8)
				{
					this.class2451_0.method_0();
				}
				this.class2437_0 = null;
			}
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000CDDC0 File Offset: 0x000CBFC0
		public override int ReadByte()
		{
			byte[] array = new byte[1];
			int result;
			if (this.Read(array, 0, 1) <= 0)
			{
				result = -1;
			}
			else
			{
				result = (int)(array[0] & 255);
			}
			return result;
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000CDDF4 File Offset: 0x000CBFF4
		private int method_7(byte[] byte_0, int int_2, int int_3)
		{
			if (this.class2437_0.method_4() > 20)
			{
				throw new Exception31("Libray cannot extract this entry version required (" + this.class2437_0.method_4().ToString() + ")");
			}
			if (this.class2437_0.method_0())
			{
				if (this.string_0 == null)
				{
					throw new Exception31("No password set.");
				}
				Class2460 @class = new Class2460();
				byte[] rgbKey = Class2459.smethod_0(Encoding.ASCII.GetBytes(this.string_0));
				this.class2453_0.method_11(@class.CreateDecryptor(rgbKey, null));
				byte[] array = new byte[12];
				this.class2453_0.method_7(array, 0, 12);
				if ((this.int_1 & 8) == 0)
				{
					if (array[11] != (byte)(this.class2437_0.method_12() >> 24))
					{
						throw new Exception31("Invalid password");
					}
				}
				else if (array[11] != (byte)(this.class2437_0.method_5() >> 8 & 255L))
				{
					throw new Exception31("Invalid password");
				}
				if (this.long_0 >= 12L)
				{
					this.long_0 -= 12L;
				}
			}
			else
			{
				this.class2453_0.method_11(null);
			}
			if (this.int_0 == 8 && this.class2453_0.method_1() > 0)
			{
				this.class2453_0.method_3(this.class2451_0);
			}
			this.delegate45_0 = new Stream3.Delegate45(this.method_8);
			return this.method_8(byte_0, int_2, int_3);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000CDF94 File Offset: 0x000CC194
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.delegate45_0(buffer, offset, count);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000CDFB4 File Offset: 0x000CC1B4
		public int method_8(byte[] byte_0, int int_2, int int_3)
		{
			if (this.class2436_0 == null)
			{
				throw new InvalidOperationException("Closed.");
			}
			int result;
			if (this.class2437_0 != null && int_3 > 0)
			{
				bool flag = false;
				int num = this.int_0;
				if (num != 0)
				{
					if (num == 8)
					{
						int_3 = base.Read(byte_0, int_2, int_3);
						if (int_3 <= 0)
						{
							if (!this.class2451_0.method_10())
							{
								throw new Exception31("Inflater not finished!?");
							}
							this.class2453_0.method_2(this.class2451_0.method_13());
							if ((this.int_1 & 8) == 0 && ((long)this.class2451_0.method_12() != this.long_0 || (long)this.class2451_0.method_11() != this.long_1))
							{
								throw new Exception31(string.Concat(new object[]
								{
									"size mismatch: ",
									this.long_0,
									";",
									this.long_1,
									" <-> ",
									this.class2451_0.method_12(),
									";",
									this.class2451_0.method_11()
								}));
							}
							this.class2451_0.method_0();
							flag = true;
						}
					}
				}
				else
				{
					if ((long)int_3 > this.long_0 && this.long_0 >= 0L)
					{
						int_3 = (int)this.long_0;
					}
					int_3 = this.class2453_0.method_7(byte_0, int_2, int_3);
					if (int_3 > 0)
					{
						this.long_0 -= (long)int_3;
						this.long_1 -= (long)int_3;
					}
					if (this.long_0 == 0L)
					{
						flag = true;
					}
					else if (int_3 < 0)
					{
						throw new Exception31("EOF in stored block");
					}
				}
				if (int_3 > 0)
				{
					this.class2436_0.vmethod_1(byte_0, int_2, int_3);
				}
				if (flag)
				{
					base.method_2();
					if ((this.int_1 & 8) != 0)
					{
						this.method_5();
					}
					if ((this.class2436_0.Value & -1L) != this.class2437_0.method_12() && this.class2437_0.method_12() != -1L)
					{
						throw new Exception31("CRC mismatch");
					}
					this.class2436_0.vmethod_0();
					this.class2437_0 = null;
				}
				result = int_3;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00012CAE File Offset: 0x00010EAE
		public override void Close()
		{
			base.Close();
			this.class2436_0 = null;
			this.class2437_0 = null;
		}

		// Token: 0x04000E69 RID: 3689
		private Stream3.Delegate45 delegate45_0;

		// Token: 0x04000E6A RID: 3690
		private Class2436 class2436_0 = new Class2436();

		// Token: 0x04000E6B RID: 3691
		private Class2437 class2437_0 = null;

		// Token: 0x04000E6C RID: 3692
		private long long_1;

		// Token: 0x04000E6D RID: 3693
		private int int_0;

		// Token: 0x04000E6E RID: 3694
		private int int_1;

		// Token: 0x04000E6F RID: 3695
		private string string_0 = null;

		// Token: 0x020004A6 RID: 1190
		// (Invoke) Token: 0x06001F2A RID: 7978
		private delegate int Delegate45(byte[] b, int offset, int length);
	}
}
